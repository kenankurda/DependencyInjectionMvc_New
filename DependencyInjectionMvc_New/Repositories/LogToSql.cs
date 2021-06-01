using Dapper;
using DependencyInjectionMvc_New.Interfaces;
using DependencyInjectionMvc_New.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DependencyInjectionMvc_New.Repositories
{
    public class LogToSql:IDatabaseStrategy
    {
       
        public void Log(string message, string media)
        {

            using (IDbConnection db = new SqlConnection(media))
            {
                db.Open();
                db.Execute(@"INSERT INTO Log (LoggedText)
                     VALUES (@LoggedText)",
                   new Log
                   {
                       LoggedText = message
                   });
            }
        }

     
    }
}
