using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using test.Models.ProQuote;

namespace test
{
    class ProQuoteDataHelper
    {
        public static Quote GetQuote(string name)
        {
            Quote quote = null;
            name = GetQuoteByName(name);
            if (name != null) quote = new Quote { Name = name };
            return quote;
        }

        public static List<QuoteItem> GetPartsByQuoteName(string name)
        {
            // todo:  query parts from db
            return new List<QuoteItem>();
        }

        static string GetQuoteByName(string name)
        {
            //string name = null;
            var connectionString = ConfigurationHelper.ProQuoteConnectionString;
            var cmdText = $"select top 1 [name] from tblquote_main where [name] = '{name}'";

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

        public static List<Quote> GetQuotes()
        {
            // https://dapper-tutorial.net/

            const int daysSinceCreated = 10;
            var sql = $@"
                select qm.*--, qi.*, st.[status]
                from tblquote_main qm
                    left outer join tblquote_status st on qm.quote_id = st.quote_id
                    left outer join tblquote_sections se on qm.quote_id = se.section_id
                    --left outer join tblquoteitem_main qi on qm.quote_id = qi.section_id
                where st.[status] = 'Accepted'
	                and qm.createdon > dateadd(day, -{daysSinceCreated}, getdate())
                    and orderdate is null
                order by st.changedon"; // TODO: make stored proc?

            List<Quote> quotes = null;
            var connectionString = ConfigurationHelper.ProQuoteConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                quotes = connection.Query<Quote>(sql).ToList();
                //FiddleHelper.WriteTable(results);
            }
            foreach (Quote quote in quotes)
            {
                quote.Items = GetQuoteItems(quote.Quote_ID);
            }
            return quotes;
        }

        public static List<QuoteItem> GetQuoteItems(int quoteId)
        {
            // https://dapper-tutorial.net/
            
            var sql = $@"
                select qi.*
                from tblquote_sections se
                    left outer join tblquoteitem_main qi on se.quote_id = qi.section_id
                where se.quote_id = {quoteId}"; // TODO: make stored proc?

            List<QuoteItem> results = null;
            var connectionString = ConfigurationHelper.ProQuoteConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                results = connection.Query<QuoteItem>(sql).ToList();
                //FiddleHelper.WriteTable(results);
            }
            return results;
        }
    }
}
