using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaDB
{
    interface DBOperation
    {
        void store(String key, String value);
        String fetch(String key);
    }
}
