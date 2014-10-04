using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaDB
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDBOperation teaDB = StringDBOperation.getDBOperation();
            teaDB.store("alma", "korte");
            System.Console.WriteLine(teaDB.fetch("alma"));
            System.Console.ReadKey();
        }
    }
}
