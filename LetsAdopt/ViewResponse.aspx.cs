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
            Image1.Visible = false;

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
            name.Text = "";
            phone.Text = "";
            email.Text = "";
            street.Text = "";
            city.Text = "";
            state.Text = "";
            country.Text = "";
            pin.Text = "";


        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Action";
                e.Row.Cells[1].Text = "Post ID";
               e.Row.Cells[2].Text = "Respondeder's ID";
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="contact")
            {
                int crow;
                crow = Convert.ToInt32(e.CommandArgument.ToString());
                string no = GridView1.Rows[crow].Cells[2].Text;
                int user = Int32.Parse(no);
                string i = GridView1.Rows[crow].Cells[1].Text;
                int pid = Int32.Parse(i);

                con.Open();
                
                string sql2 = "select email from user where uid='" + user + "'";
                MySqlCommand cmd = new MySqlCommand(sql2, con);
                adapter.SelectCommand = new MySqlCommand(sql2, con);
                string mail = cmd.ExecuteScalar().ToString();

                
                string sql3 = "select * from address where email='" + mail + "'";
                MySqlCommand cmd1 = new MySqlCommand(sql3, con);
                adapter.SelectCommand = new MySqlCommand(sql3, con);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "address");
                email.Text = ds.Tables[0].Rows[0]["email"].ToString();
                phone.Text = ds.Tables[0].Rows[0]["phone"].ToString();
                street.Text = ds.Tables[0].Rows[0]["lane"].ToString();
                city.Text = ds.Tables[0].Rows[0]["city"].ToString();
                state.Text = ds.Tables[0].Rows[0]["state"].ToString();
                pin.Text = ds.Tables[0].Rows[0]["zip"].ToString();
                country.Text = ds.Tables[0].Rows[0]["country"].ToString();


                string sql4 = "select name from user where email='" + mail + "'";
                MySqlCommand cmd4 = new MySqlCommand(sql4, con);
                adapter.SelectCommand = new MySqlCommand(sql4, con);
                DataSet ds1 = new DataSet();
                adapter.Fill(ds1, "user");
                name.Text = ds1.Tables[0].Rows[0]["name"].ToString();

                string sql5 = "select image from post where pid='" + pid + "'";
                MySqlCommand cmd5 = new MySqlCommand(sql5, con);
                adapter.SelectCommand = new MySqlCommand(sql5, con);
                string path = cmd5.ExecuteScalar().ToString();

                Image1.Visible = true;
                Image1.ImageUrl = path;
            }
        }
    }
}