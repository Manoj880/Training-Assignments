<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CaseStudy
{
    class SQLConnection
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getcon()
        {
            con = new SqlConnection("data source = RMGW58ZLPC0943\\SQLEXPRESS ; Initial catalog = Casestudy ; " + "user id= sa; password = Temp1234");
            con.Open();
            return con;
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CaseStudy
{
    class SQLConnection
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getcon()
        {
            con = new SqlConnection("data source = RMGW58ZLPC0943\\SQLEXPRESS ; Initial catalog = Casestudy ; " + "user id= sa; password = Temp1234");
            con.Open();
            return con;
        }
    }
>>>>>>> 96ffd256c7a5cd6aa08a817f19cfaa91ab2c3d80
}