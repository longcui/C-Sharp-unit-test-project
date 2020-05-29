using System;
using System.Diagnostics;
using System.IO;

namespace EntityFrameworkCoreExample
{
    class Program
    {
        /// <summary>
        /// Followed https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=visual-studio
        /// important is to set <StartWorkingDirectory>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using var db = new BloggingContext();
            db.Add(new Blog()
            {
                //If Id field is left empty, SQLite will auto generate it, otherwise use the one specified below
                BlogId = 555,
                Url = "test"
            });
            db.SaveChanges();
        }
    }
}
