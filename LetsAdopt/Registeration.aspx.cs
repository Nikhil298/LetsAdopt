using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data;
using System.EnterpriseServices;
using MySql.Data.MySqlClient;

namespace LetsAdopt
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }
       
        protected void submit_Click(object sender, EventArgs e)
        {
            if (Name.Text=="" || Email.Text == "" || password.Text == "" || cpassword.Text == "" )
            {
                string msg = "All fields are mandatory.";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);


            }
            else
            {
                MySqlConnection con = new MySqlConnection("server = localhost; Uid = root; password =''; database = letsadopt");
                con.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                string sql1 = "select count(*) from user where email='" + Email.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                int t = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                if (t == 1)
                {
                    Response.Write("User Already Exist");
                }

                else
                {

                    string sql = "Insert into user(name,email,password) value('" + Name.Text + "','" + Email.Text + "','" + cpassword.Text + "')";
                    MySqlCommand command = new MySqlCommand(sql, con);
                    adapter.InsertCommand = new MySqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();

                    string sql2 = "Insert into address(name,email) value('"+Name.Text +"','" + Email.Text + "')";
                    MySqlCommand command1 = new MySqlCommand(sql2, con);
                    adapter.InsertCommand = new MySqlCommand(sql2, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command1.Dispose();

                    con.Close();

                    string sc = "Successfully Registered!";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + sc + "');", true);
                    Name.Text = "";
                    Email.Text = "";
                    password.Text = "";
                    cpassword.Text = "";

                }
            }
        }
    }
}