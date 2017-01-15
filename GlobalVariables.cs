using AspNetCoreExample3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreExample3
{
    public class GlobalVariables
    {
        public static List<Game> Games { get; set; } = new List<Game>();
    }
}
