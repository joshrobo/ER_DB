using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EREntry
{
    class DatabaseConnect
    {
        string ERConnectionString = "Server=http://132.160.49.90:7012;Database=Dujeet_DB;Uid=root;Pwd=Bahaghari20$;";
        string connect()
        {
            return ERConnectionString;
        }
    }
}
