using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace TwoLayer
{
    public partial class ProfileviewDB : System.Web.UI.Page
    {
        ConnectionClass objcls = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select name,age,adress,photo from TwoLayer where Id=" + Session["uid"] + "";
            SqlDataReader dr = objcls.fn_Exereader(sel);
            while (dr.Read())
            {
                Label1.Text = dr["name"].ToString();
                Label2.Text = dr["age"].ToString();
                Label3.Text = dr["adress"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }

                DataSet ds = objcls.fn_Adapter_Dataset(sel);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            DataTable dt = objcls.fn_Adapter_Dataset(sel);
            DataList1.DataSource = dt;
            DataList1.DataBind();
            }
        }
    }
