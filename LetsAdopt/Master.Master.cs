﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.EnterpriseServices;
using MySql.Data.MySqlClient;

namespace LetsAdopt
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConnectionState();
            }

        }
        private void ConnectionState()
        {
            string conc = "server = localhost; Uid = root; password = ; database = letsadopt";
            using (MySqlConnection cn = new MySqlConnection(conc))
            {
                cn.Open();
                

            }

        }
    }
}