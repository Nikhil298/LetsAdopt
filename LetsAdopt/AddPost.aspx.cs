using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace LetsAdopt
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            uid.Text = Session["uid"].ToString();
             id = int.Parse(uid.Text);
        }

        protected void Post_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; Uid = root; password =''; database = letsadopt");
            con.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string sql1 = "Insert into post(image,des,uid) value('" + image.Text + "','" + des.Text + "','" + id + "')"; 
            MySqlCommand cmd = new MySqlCommand(sql1, con);
            adapter.InsertCommand = new MySqlCommand(sql1, con);
            adapter.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}