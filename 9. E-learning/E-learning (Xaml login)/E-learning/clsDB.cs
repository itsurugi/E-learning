using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace E_learning
{
    class clsDB
    {
        MySqlConnection DBconnection = new MySqlConnection("server=localhost; database=ziekenhuisdb; uid=root; pwd=;");
    }
}
