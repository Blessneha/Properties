using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bookstore b = new Bookstore(123, "abc", "efc", 5, 100, "le");
            Bookstore r = new Bookstore(231, "hgd", "yed", 3, 11, "oytt");
            b.show();

        }
    }
}
