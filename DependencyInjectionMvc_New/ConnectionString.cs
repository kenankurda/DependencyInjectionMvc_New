﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionMvc_New
{
    public class ConnectionString
    {
        //public ConnectionString(string value) => Value = value;

        public ConnectionString(string value) => Value = value;

        public string Value { get; }
    }
}
