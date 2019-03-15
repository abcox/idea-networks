using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace test
{
    class ProQuoteDataHelper
    {
        public static Quote GetQuote(string quoteNumber)
        {
            var name = GetQuoteName(18);
            return new Quote { name = name };
        }

        public static List<QuotePart> GetPartsByQuoteNumber(string quoteNumber)
        {
            // todo:  query parts from db
            return new List<QuotePart>();
        }

        static string GetQuoteName(int id)
        {
            string name = null;
            var connectionString = ConfigurationHelper.ProQuoteConnectionString;
            var cmdText = $"select top 1 [name] from tblquote_main where quote_id = {id}"; // "CREATE TABLE Dogs1 (Weight INT, Name TEXT, Breed TEXT)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(cmdText, sqlConnection))
                {
                    try
                    {
                        //command.ExecuteNonQuery();
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            name = reader.GetValue(reader.GetOrdinal("name")) as string;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Table not created.");
                    }
                }
            }
            return name;
        }
    }

    class QuotePart
    {
        public int number { get; set; }
    }

    class Quote
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
