﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bnn.Service
{
    class ErrorResponse
    {
        public int status { get; set; }

        public string message { get; set; }

        public Dictionary<string, string> error { get; set; }
    }
}
