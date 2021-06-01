using Dapper;
using DependencyInjectionMvc_New.Interfaces;
using DependencyInjectionMvc_New.Models;
using System.Data.SqlClient;

namespace DependencyInjectionMvc_New.Repositories
{
    public class LogToSql:IDatabaseStrategy
    {
        private readonly ConnectionString _connectionString;
        public LogToSql(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }

        public string Value { get; }

        public void Log(string message)
        {
            using (var conn = new SqlConnection("Server=LAPTOP-5KTTCAE1;Database=Logs;Trusted_Connection=True;"))
            {
                conn.Open();
                conn.Execute(@"INSERT INTO Log (LoggedText)
                     VALUES (@LoggedText)",
                   new Log
                   {
                       LoggedText = message
                   });
            }
        }
    }
}
