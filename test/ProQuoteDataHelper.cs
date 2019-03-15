using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace test
{
    class ProQuoteDataHelper
    {
        public static Quote GetQuote(string name)
        {
            Quote quote = null;
            name = GetQuoteByName(name);
            if (name != null) quote = new Quote { name = name };
            return quote;
        }

        public static List<QuotePart> GetPartsByQuoteName(string name)
        {
            // todo:  query parts from db
            return new List<QuotePart>();
        }

        static string GetQuoteByName(string name)
        {
            //string name = null;
            var connectionString = ConfigurationHelper.ProQuoteConnectionString;
            var cmdText = $"select top 1 [name] from tblquote_main where [name] = '{name}'"; // "CREATE TABLE Dogs1 (Weight INT, Name TEXT, Breed TEXT)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(cmdText, sqlConnection))
                {
                    try
                    {
                        //command.ExecuteNonQuery();
                        var reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                name = reader.GetValue(reader.GetOrdinal("name")) as string;
                            }
                        }
                        else
                        {
                            //name = reader.HasRows ? null : name;
                            name = null;
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
