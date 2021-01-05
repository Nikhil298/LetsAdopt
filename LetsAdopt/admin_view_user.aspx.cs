using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace LetsAdopt
{
    public partial class admin_view_user : System.Web.UI.Page
    {

        MySqlConnection con = new MySqlConnection("server = localhost; Uid = root; password =''; database = letsadopt");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlDataAdapter adapter1 = new MySqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();

            string sql1 = "select * from address";
            MySqlCommand cmd = new MySqlCommand(sql1, con);
            adapter.SelectCommand = new MySqlCommand(sql1, con);
            adapter.SelectCommand.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();

            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            cmd.Dispose();
            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            string name = (string)GridView1.DataKeys[e.RowIndex].Values[0];
            con.Open();
            string sql2 = "delete from address where name='" + name + "'";
            string sql3 = "delete from user where name='" + name + "'";

            MySqlCommand command = new MySqlCommand(sql2, con);
            MySqlCommand command1 = new MySqlCommand(sql3, con);

            adapter.DeleteCommand = new MySqlCommand(sql2, con);
            adapter1.DeleteCommand = new MySqlCommand(sql3, con);

            adapter.DeleteCommand.ExecuteNonQuery();
            adapter1.DeleteCommand.ExecuteNonQuery();
            Response.Redirect("admin_view_user.aspx");
        }
    }
}