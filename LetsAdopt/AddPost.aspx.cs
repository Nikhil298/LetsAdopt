using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;
using System.Data;


namespace LetsAdopt
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                uid.Text = Session["uid"].ToString();
                id = int.Parse(uid.Text);
            }

            Image1.ImageUrl = "illustrations/add image.png";
        }

        protected void Post_Click(object sender, EventArgs e)
        {
            if (des.Text == "" || FileUpload1.HasFiles == false)
            {
                string msg = "All fields are mandatory.";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msg + "');", true);

            }
            else
            {
                MySqlConnection con = new MySqlConnection("server = localhost; Uid = root; password =''; database = letsadopt");
                con.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                if (FileUpload1.HasFile)
                {
                    string fname = FileUpload1.FileName;
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/image/" + fname));
                    string ipath = "~/image/" + fname.ToString();

                    string sql1 = "Insert into post(image,des,uid) value('" + ipath + "','" + des.Text + "','" + id + "')";
                    MySqlCommand cmd = new MySqlCommand(sql1, con);
                    adapter.InsertCommand = new MySqlCommand(sql1, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();

                    string sc="Your post has been added!";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + sc + "');", true);
                    des.Text = "";
                }
            }
        }
    }
}