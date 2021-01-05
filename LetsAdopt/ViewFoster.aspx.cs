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
    public partial class ViewFoster : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection("server = localhost; Uid = root; password =''; database = letsadopt");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql1 = "select * from address where foster ='yes'";
            MySqlCommand cmd = new MySqlCommand(sql1, con);
            adapter.SelectCommand = new MySqlCommand(sql1, con);
            adapter.SelectCommand.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();

            da.Fill(dt);

            DataList1.DataSource = dt;
            DataList1.DataBind();
            cmd.Dispose();
            con.Close();

        }
    }
}