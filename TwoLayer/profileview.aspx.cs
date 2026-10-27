using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.data;
using System.data.Sqlclient;


namespace TwoLayer
{
    public partial class profileview : System.Web.UI.Page
    {
        ConnectionClass objcls = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel= "select name,age,adress,photo from TwoLayer where Id=" + session["uid"] + "";
            SqlDataReader dr = objcls.fn_Exereader(sel);
            while (dr.Read())
            {
                lab
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}