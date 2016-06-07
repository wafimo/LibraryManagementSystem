using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAL.Gateway
{
    public class BaseGateway
    {
        public SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["lms"].ConnectionString);

    }
}
