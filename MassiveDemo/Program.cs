using System;
using Massive;

namespace MassiveDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //BasicQuery();
            AdHocQuery();

        }

        private static void BasicQuery()
        {
            /* initialize dynamic model */
            var tbl = new DynamicModel("MyConnection", tableName: "Customers", primaryKeyField: "CustomerID");

            /* retrieve all records */
            var customers = tbl.All();

            /* iterate over result set */
            foreach (var customer in customers)
            {
                Console.WriteLine("{0} {1} {2} {3}", customer.Title, customer.FirstName, customer.LastName, customer.Suffix);
            }

            /* pause output */
            Console.ReadLine();
        }

        private static void AdHocQuery()
        {
            /* initialize dynamic model */
            var tbl = new DynamicModel("MyConnection", tableName: "Customers", primaryKeyField: "CustomerID");

            /* retrieve all records via ad-hoc query */
            var customers = tbl.Query("SELECT * FROM CUSTOMERS");

            /* iterate over result set */
            foreach (var customer in customers)
            {
                Console.WriteLine("{0} {1} {2} {3}", customer.Title, customer.FirstName, customer.LastName, customer.Suffix);
            }

            /* pause output */
            Console.ReadLine();
        }
    }
}
