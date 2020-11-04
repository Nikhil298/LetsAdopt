using System;
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
           

        }
        public Label MyLabel
        {
            get
            {
                return this.uname;
            }
        }

        public LinkButton MasterPageButtonProperty
        {
            get
            {
                return MasterPageButton;
            }
            set
            {
                MasterPageButton = value;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
 }
 