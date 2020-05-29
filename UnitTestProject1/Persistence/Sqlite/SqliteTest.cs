//using EntityFrameworkCoreExample;
//using Microsoft.Data.Sqlite;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Data.Common;
//using System.Text;

//namespace UnitTest.Persistence.Sqlite
//{
//    [TestClass]
//    public class Class1 : BloggingContext, IDisposable
//    {
//        private readonly DbConnection _dbConnection;

//        protected override void OnConfiguring(DbContextOptionsBuilder options)
//        {
//            options.UseSqlite(CreateInMemoryDatabase());
//        }

//        private static DbConnection CreateInMemoryDatabase()
//        {
//            var connection = new SqliteConnection("Filename=:memory:");

//            connection.Open();

//            return connection;
//        }
//        public Class1() 
//        {
//            _connection = RelationalOptionsExtension.Extract(ContextOptions).Connection;
//        }

//        //[TestCleanup]
//        //public void Dispose()
//        //{
//        //    throw new NotImplementedException();
//        //}

//        [TestMethod]
//        public void TestConnection() {
        
//        }
//    }
//}
