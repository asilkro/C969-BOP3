using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Silkroski_C969.Models;
using Silkroski_C969.Forms;

namespace Silkroski_C969.DB
{
    partial class DBHelper
    {
        private static DbConnection _dbConnection = new DbConnection();

        public string checkLogin_string = "SELECT userId, password FROM user WHERE userId = " + "TODO"
            + " AND password = " + "TODO/";
    }
}