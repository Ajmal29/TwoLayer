using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwoLayer
{
    public partial class Registration : System.Web.UI.Page
    {
        ConnectionClass objcls = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "/photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string strinsert = "insert into Tab1 values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + FileUpload1.FileName + "','"+TextBox4.Text + "','" +TextBox5.Text + "')";
            int i = objcls.fn_Executenonquery(strinsert);
            if(i==1)
            {
                Label1.Text = "inserted";
            }
        }
    }
}