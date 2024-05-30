using abstractClassDemo.DemoLibrary;
using System;

namespace abstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDataAccess> databases = new List<IDataAccess>();
       
            if (!databases.Any()) {
                databases.Add(new SqlDataAccess());
                databases.Add(new SqliteDataAccess());
            }
        

            foreach (var db in databases)
            {
                db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                db.SaveData("insert into table");
                Console.WriteLine("Running the loop");
            }
            Console.WriteLine("exiting the loop");
        
        }
    }
}
