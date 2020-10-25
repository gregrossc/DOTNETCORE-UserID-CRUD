﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace anabolicdata.Models
{
    public class Helper
    {
        public static string ToUnderscoreCase(string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
    }
}
