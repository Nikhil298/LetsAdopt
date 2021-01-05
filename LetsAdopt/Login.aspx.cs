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
            Image1.ImageUrl = "illustrations/home.png";

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (email.Text == ""|| password.Text == "" )
            {
                string msg = "All fields are mandatory.";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);


            }
            else if(email.Text=="admin" && password.Text=="admin")
            {
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Label mylabelchild = this.Master.MyLabel;

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
                    string name = "select name from user where email = '" + email.Text + "'";
                    string ud = "select uid from user where email = '" + email.Text + "'";

                    MySqlCommand pass = new MySqlCommand(cpass, con);
                    MySqlCommand nm = new MySqlCommand(name, con);
                    MySqlCommand id = new MySqlCommand(ud, con);

                    string usid = id.ExecuteScalar().ToString();

                    string psd = pass.ExecuteScalar().ToString();
                    string nms = nm.ExecuteScalar().ToString();

                    int uid = Int32.Parse(usid);

                    if (psd == password.Text)
                    {
                        Session["name"] = nms;
                        Session["uid"] = uid;

                        mylabelchild.Text = nms;

                        Response.Redirect("ViewPost.aspx");
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
}