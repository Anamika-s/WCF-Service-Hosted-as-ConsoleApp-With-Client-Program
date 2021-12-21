using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    public class Functions : IFunctions
    {
        public string Combine(string s1, string s2)
        {
            return s1 + " " + s2;
        }
    }
}
