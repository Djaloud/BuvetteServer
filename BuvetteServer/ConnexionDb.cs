﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BuvetteServer
{
    class ConnexionDb
    {
        public static SqlConnection GetDBConnection()
        {
            
            //String strConn = "Data Source =yh20.database.windows.net; Initial Catalog = Buvette;User Id= yh20 ;Password =Buvette20302030";
            String strConn = "Data Source =DESKTOP-6QI30NU\\SQLEXPRESS; Initial Catalog = Buvette; Integrated security = true";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConn;
            return conn;
        }

    }
}