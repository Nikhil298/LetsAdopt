using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace LetsAdopt
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; Uid = root; password =''; database = letsadopt");
            con.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String sql = "";
            sql = "select count(*) from user where email='" + email.Text + "'";
            command = new MySqlCommand(sql, con);
            int t = Convert.ToInt32(command.ExecuteScalar().ToString());
            if (t == 1)
            {
                
                string cpass = "select password from user where email='" + email.Text + "'";
                string name= "select name from user where email = '" + email.Text + "'";
                MySqlCommand pass = new MySqlCommand(cpass, con);
                MySqlCommand nm = new MySqlCommand(name, con);

                string psd = pass.ExecuteScalar().ToString();
                string nms = nm.ExecuteScalar().ToString();

                if (psd == password.Text)
                {
                    Session["New"] = nms;
                    Response.Write("welcome "+ Session["New"].ToString());
                }
                else
                {
                    Response.Write("wrong password");

                }
            }
            else
            {
                Response.Write("wrong password");

            }


        }
    }
}