using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Billing.OSE.Data
{
    public  class DataAccess
    {
        public IDbConnection DBConnection {
            get
            {
                var cnxString = ConfigurationManager.ConnectionStrings["cnxBilling"].ConnectionString;
                return new SqlConnection(cnxString);
            }
        }
    }
}
