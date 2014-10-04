using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaDB
{
    class StringDBOperation : DBOperation
    {
        private Dictionary<string, string> inMemoryStore;
        private static volatile StringDBOperation instance = null;
        private static object syncRoot = new Object();



        private StringDBOperation()
        {
            inMemoryStore=new Dictionary<string,string>();
        }

        public static StringDBOperation getDBOperation()
        {

            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new StringDBOperation();
                }
            }


            return instance;
        }

        public void store(string key, string value)
        {
            inMemoryStore.Add(StringDBOperation.hash(key), value);

        }

        public string fetch(string key)
        {
            var internalKey = StringDBOperation.hash(key);
            if (inMemoryStore.ContainsKey(internalKey))
            {
                return inMemoryStore[internalKey];
             }
            return null;
        }

        public static string hash(string value)
        {
            int hashValue = 0;
            foreach (char c in value)
            {
                hashValue = (hashValue << 5) - hashValue + c;
            }
            return hashValue.ToString();
        }
    }
}
