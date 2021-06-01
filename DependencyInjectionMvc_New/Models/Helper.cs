using DependencyInjectionMvc_New.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionMvc_New.Models
{
    public  class Helper:IDatabaseStrategy
    {
        private readonly Helper _helper;
        public Helper(Helper helper)
        {
            _helper = helper;
        }
        public Helper(string value) => Value = value;

        public string Value { get; }

        public void Log(string message)
        {
            var sql = "Insert into dbo.Log (LoggedText) VALUES (@message)";
            using (var connection = new SqlConnection(_helper.Value))
            {
                connection.Open();
                //connection.Execute(sql);
            }

        }
    }
}
