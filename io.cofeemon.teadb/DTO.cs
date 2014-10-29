using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaDB.io.cofeemon.teadb
{
    class DTO
    {
      
        string key_;
        string value_;
        public char TopFolder { get; private set;}
        public char SubFolder { get; private set;  }
        public string key { get { return key_; } }
        public string value { get { return value_; } }
        //public string value { get; } igy ctorba nem tudok  this.value = value;

        public DTO(string key,string value)
        {
            TopFolder = key[0];
            SubFolder_ = key[1];
            key_ = key;
            value_ = value;
            
        }

        public DTO(string key)
        {
            TopFolder_ = key[0];
            SubFolder_ = key[1];
            key_ = key;
           
        }

        public string dirpath() {
            return string.Join("/", topFolder, subFolder);
        }

        public string filepath()
        {
            return string.Join("/", topFolder, subFolder, key);
        }

        public string toString() {
            return topFolder_ + " " + subFolder_ + " " + key + " " + value;
        }

       
    }
}
