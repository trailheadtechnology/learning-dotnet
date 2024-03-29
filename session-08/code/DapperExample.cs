﻿using System;
using Microsoft.Data.SqlClient;
using Dapper;

namespace session_08
{
    public class DapperExample
    {
        public static void Example()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=AdventureWorks;"))
            {
                conn.Open();

                // DON'T DO THIS WITHOUT A WHERE CLAUSE
                var results = conn.Query<Customer>("SELECT * FROM SalesLT.Customer");
                // => lambda expression, LINQ
                foreach (var result in results)
                {
                    Console.WriteLine(result.FullName);
                }
            }

        }
    }

    public class Customer
    {
        public string FullName {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string FirstName { get; set; }   
        public string LastName { get; set; }
    }
}
