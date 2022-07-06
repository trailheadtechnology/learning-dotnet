using System;
using System.Data.SqlClient;
using System.Transactions;

namespace session_10
{
    public class TransactionExample
    {
        public static string ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=SSPI;Initial Catalog=AdventureWorks;";

        public static void Example()
        {
            try
            {
                Console.WriteLine("Before Transaction");
                GetQuantities();
                QuantityTransfer2();
                Console.WriteLine("After Transaction");
                GetQuantities();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong" + e.Message);
            }
            Console.ReadKey();
        }

        private static void QuantityTransfer()
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                // The connection needs to be open before we begin a transaction
                cn.Open();

                // Create the transaction object by calling the BeginTransaction method on connection object
                SqlTransaction tx = cn.BeginTransaction();

                try
                {
                    // Associate the first update command with the transaction
                    SqlCommand cmd = new SqlCommand("UPDATE SalesLT.SalesOrderDetail SET OrderQty = OrderQty + 1 WHERE SalesOrderID = 71780 AND ProductID = 905", cn, tx);
                    cmd.ExecuteNonQuery();

                    // Associate the second update command with the transaction
                    cmd = new SqlCommand("UPDATE SalesLT.Product SET QtyOnHand = QtyOnHand - 1 WHERE ProductID = 905", cn, tx);
                    cmd.ExecuteNonQuery();

                    // If everything goes well then commit the transaction
                    tx.Commit();
                    Console.WriteLine("Transaction Committed");
                }
                catch
                {
                    // If anything goes wrong, rollback the transaction
                    tx.Rollback();
                    Console.WriteLine("Transaction Rollback");
                }
            }
        }

        private static void QuantityTransfer2()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    // The connection needs to be open before we begin a transaction
                    cn.Open();

                    try
                    {
                        // Associate the first update command with the transaction
                        SqlCommand cmd = new SqlCommand("UPDATE SalesLT.SalesOrderDetail SET OrderQty = OrderQty + 1 WHERE SalesOrderID = 71780 AND ProductID = 905", cn);
                        cmd.ExecuteNonQuery();

                        // Associate the second update command with the transaction
                        cmd = new SqlCommand("UPDATE SalesLT.Product SET QtyOnHand = QtyOnHand - 1 WHERE ProductID = 905", cn);
                        cmd.ExecuteNonQuery();

                        // If everything goes well then commit the transaction
                        scope.Complete();
                        Console.WriteLine("Transaction Committed");
                    }
                    catch
                    {
                        Console.WriteLine("Something Failed");
                    }
                }
            }
        }

        private static void GetQuantities()
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SalesLT.SalesOrderDetail WHERE SalesOrderID = 71780 AND ProductID = 905", cn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["SalesOrderID"] + ",  " + dr["OrderQty"] + ",  " + dr["UnitPrice"]);
                        }
                    }
                }

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SalesLT.Product WHERE ProductID = 905", cn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr["ProductID"] + ",  " + dr["QtyOnHand"]);
                        }
                    }
                }
            }
        }
    }
}
