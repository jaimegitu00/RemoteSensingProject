using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RemoteSensingProject.Models
{
    public class DataFactory
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public DataFactory() { 
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            cmd = new SqlCommand();
        }
    }
}