using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaDB.io.cofeemon.teadb
{
    class Persister
    {
        public static void save(DTO toPersist) {
            System.IO.Directory.CreateDirectory(toPersist.dirpath());
            System.IO.File.WriteAllText(toPersist.filepath(), toPersist.value);
        }

        public static string load(DTO toLoad) {
            string filepath=toLoad.filepath();
            if (System.IO.File.Exists(filepath))
            {
                return System.IO.File.ReadAllText(filepath);
            }
            else return null;
        }
    }
}
