using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaDB.io.cofeemon.teadb
{
    class Persister
    {
        
        public const string BASE_DIRECTORY = "tea.db/";
        public static string basedir = BASE_DIRECTORY;
        public static void save(DTO toPersist) {
           		//Save to db
                System.IO.Directory.CreateDirectory(basedir + toPersist.dirpath());
                System.IO.File.WriteAllText(basedir + toPersist.filepath(), toPersist.value);
         
        }

        public static string load(DTO toLoad) {
            

                string filepath = basedir + toLoad.filepath();
                if (System.IO.File.Exists(filepath))
                {
                    return System.IO.File.ReadAllText(filepath);
                }
                else return null;
           
        }
    }
}
