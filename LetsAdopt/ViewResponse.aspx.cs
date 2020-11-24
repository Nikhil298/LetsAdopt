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
    public partial class WebForm5 : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Uid = root; password =''; database = letsadopt");
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            int n = int.Parse(Session["uid"].ToString());
            con.Open();

            string sql1 = "select pid,uid from response where puid ='" + n + "'";
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

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Post ID";
                e.Row.Cells[1].Text = "Responded By";
            }
        }
    }
}