using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwoLayer
{
    public partial class Login : System.Web.UI.Page
    {
        ConnectionClass objcls = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select count(Id)from Tab1 where Username='" + TextBox1.Text + "' and password=" + TextBox2.Text + "";
            string cid = objcls.fn_Exescalar(s);
            if(cid=="1")
            {
                string str = "select count(Id)from Tab1 where Username='" + TextBox1.Text + "' and password=" + TextBox2.Text + "";
                string id = objcls.fn_Exescalar(str);
                Session["uid"] = id;
                Response.Redirect("ProfileviewDB.aspx");

                //Label1.Text = "success";
            }
            else
            {
                Label1.Text = "invalid username and password";
            }
        }
    }
}