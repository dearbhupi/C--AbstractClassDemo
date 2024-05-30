﻿using abstractClassDemo.DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace abstractClassDemo.DemoLibrary
{
    public class SqliteDataAccess : IDataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load connection string");
            return "testConnectionString";
        }

        public void LoadData(string sql)
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite Server");
        }
    }
}