using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestQuotesBlazor.Data
{
    public class QuoteService : IQuoteService
    {
        private readonly string _connectionString;

        public QuoteService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("Default");
        }

        public async Task<List<Quote>> GetQuotes()
        {
            var sql = "SELECT Content,Category,Grade FROM Quotes";
            using (var connection = new MySqlConnection(_connectionString))
            {
                var rows = await connection.QueryAsync<Quote>(sql);
                return rows.ToList();
            }
        }

        public Task AddQuote(Quote quote)
        {
            var sql = "INSERT INTO Quotes (Content,Category,Grade) Values(@Content, @Category, @Grade);";
            using (var connection = new MySqlConnection(_connectionString))
            {
                return connection.ExecuteAsync(sql, new { Content = quote.Content, Category = quote.Category, quote.Grade });

            }
        }


    }
}
