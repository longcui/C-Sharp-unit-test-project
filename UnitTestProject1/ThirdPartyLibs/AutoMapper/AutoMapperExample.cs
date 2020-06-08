using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest.ThirdPartyLibs.AutoMapper
{
    /// <summary>
    /// Install: https://automapper.org/
    /// Use: https://docs.automapper.org/en/latest/Getting-started.html
    /// </summary>
    [TestClass]
    public class AutoMapperExample
    {
        [TestMethod]
        public void Test() {
            const int ID = 54;
            const int AGE = 5;
            string NAME = "BOB";

            Foo foo = new Foo(ID) {
                Age = AGE,
                InnerFoos = new List<InnerFoo>() {
                    new InnerFoo() { Name = NAME }
                }
            };


            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Foo, FooDto>()
                    .ForMember(dest => dest.InnerFooDtos, opt => opt.MapFrom(src => src.InnerFoos));
                cfg.CreateMap<InnerFoo, InnerFooDto>();
            });
            // only during development, validate your mappings; remove it before release
            configuration.AssertConfigurationIsValid();
            // use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
            var mapper = configuration.CreateMapper();

            var fooDto = mapper.Map<FooDto>(foo);

            Assert.AreEqual(ID, fooDto.GetId());
            Assert.AreEqual(AGE, fooDto.Age);
            Assert.AreEqual(NAME, fooDto.InnerFooDtos[0].Name);
        }

        class Foo
        {
            private readonly int _id;

            public Foo(int id)
            {
                _id = id;
            }

            public int GetId() => _id;
            public List<InnerFoo> InnerFoos { get; set; }

            public int Age { get; set; }
        }

        class InnerFoo
        {
            public string Name { get; set; }
        }
        class FooDto
        {
            private readonly int _id;

            public FooDto(int id)
            {
                _id = id;
            }

            public List<InnerFooDto> InnerFooDtos { get; set; }

            public int Age { get; set; }
            public int GetId() => _id;
        }
        class InnerFooDto
        {
            public string Name { get; set; }
        }
    }
}
