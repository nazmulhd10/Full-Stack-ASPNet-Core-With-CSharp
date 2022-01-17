using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleCode
{
    public class IndexOf_MethodExample
    {
        public static void Main(string[] args)
        {
            var x = " My First Day at programming";
            Console.WriteLine(x.IndexOf("at")); // result is 14
            Console.WriteLine(x.IndexOf("Bangladesh")); // result is -1
        }
    }
}
