using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaDB.io.cofeemon.teadb;

namespace TeaDB
{
    class Program
    {
        const int NR_OF_TRIES=100;
        const int MB = 1048576;
        static void Main(string[] args)
        {
            StringDBOperation connection = StringDBOperation.getDBOperation("something1/");
            String str = getMBString(MB);

           
            Stopwatch watch = new Stopwatch();
            var res=performInserts(connection, str, watch);
            calculateAndPrintAvgs(res);
            
            
            System.Console.ReadKey();

            

           
        }

        private static void calculateAndPrintAvgs(double[] insertResult)
        {
            double sum = 0;
            for (int i = 1; i < NR_OF_TRIES; i++)
            {
                sum += insertResult[i];
            }
            Console.WriteLine("min:" + insertResult.Min() + " max:" + insertResult.Max() + " avg:" + sum / NR_OF_TRIES);
        }

        private static double[] performInserts(StringDBOperation connection, String str, Stopwatch watch)
        {
            double[] insertResult = new double[NR_OF_TRIES];
            for (int i = 1; i < NR_OF_TRIES; i++)
            {
                var randomKey = Get8CharacterRandomString();
                watch.Start();
                connection.store(randomKey, str);
                watch.Stop();
                insertResult[i] = watch.Elapsed.TotalMilliseconds;
                //Console.WriteLine("IsHighResolution: " + Stopwatch.IsHighResolution + " Freq:" + Stopwatch.Frequency.ToString() + " " + "Measured time: " + watch.Elapsed.TotalMilliseconds + " ms.");
                watch.Reset();
            }

            return insertResult;
        }

        private static string getMBString(long lenght)
        {
            char[] data = new char[lenght];
            for (int i = 0; i < lenght; i++)
            {
                data[i] = 'f';
            }
            String str = new String(data);
            return str;
        }

        private static string Get8CharacterRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", ""); // Remove period.
            return path.Substring(0, 8);  // Return 8 character string
        }
    }
}
