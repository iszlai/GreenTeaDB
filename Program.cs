using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaDB.io.cofeemon.teadb;

namespace TeaDB
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDBOperation connection = StringDBOperation.getDBOperation();
            connection.store("alma", "korte1");
            connection.store("alma1", "korte1");
            connection.store("alma2", "korte1");
            connection.store("alma3", "korte1");
            System.Console.WriteLine(connection.fetch("alma2"));
            System.Console.WriteLine(connection.fetch("alma3"));
            System.Console.WriteLine(connection.fetch("alma1"));
            System.Console.ReadKey();
            

           
        }
    }
}
