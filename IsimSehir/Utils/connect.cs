using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsimSehir.Utils
{
    internal class connect
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data source=C:\\Users\\orcun\\OneDrive\\Masaüstü\\isimsehirdb.db;Version=3;");

    }
}
