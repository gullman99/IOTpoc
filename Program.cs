//querying SQL database using C#
//https://docs.microsoft.com/en-us/azure/sql-database/sql-database-connect-query-dotnet-core
//https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader?view=netframework-4.8


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_query
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "gullman99.database.windows.net";
                builder.UserID = "gullman99";
                builder.Password = "password";
                builder.InitialCatalog = "my database";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();
                    //StringBuilder sb = new StringBuilder();
                    //sb.Append("SELECT *");
                    //sb.Append("FROM Users");
                    //sb.Append("SELECT TOP 20 pc.Name as CategoryName, p.name as ProductName ");
                    //sb.Append("FROM [SalesLT].[ProductCategory] pc ");
                    //sb.Append("JOIN [SalesLT].[Product] p ");
                    //sb.Append("ON pc.productcategoryid = p.productcategoryid;");
                 
    
    
                    String sql = "SELECT * FROM Users;";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //ReadSingleRow((IDataRecord)reader);
                                Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();
        }
    }
}
*/
