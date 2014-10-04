using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaDB.io.cofeemon.teadb
{
    class DTO
    {
        char topFolder_;
        char subFolder_;
        string key_;
        string value_;
        public char topFolder { get { return topFolder_; } }
        public char subFolder { get { return subFolder_; } }
        public string key { get { return key_; } }
        public string value { get { return value_; } }
        //public string value { get; } igy ctorba nem tudok  this.value = value;

        public DTO(string key,string value)
        {
            topFolder_ = key[0];
            subFolder_ = key[1];
            key_ = key;
            value_ = value;
        }

        public DTO(string key)
        {
            topFolder_ = key[0];
            subFolder_ = key[1];
            key_ = key;
        }

        public string dirpath() {
            return string.Join("/", topFolder, subFolder);
        }

        public string filepath()
        {
            return string.Join("/", topFolder, subFolder, key);
        }

       
    }
}
