using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ShopingWebSiteFirstProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
            string strlogin = "select count(Reg_Id) from LoginTB where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = objcls.Fn_Scalar(strlogin);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string strS = "select Reg_Id from LoginTB where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string regId = objcls.Fn_Scalar(strS);
                Session["usid"] = regId;

                string strlogtype = "select Log_Type from LoginTb where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string logtype = objcls.Fn_Scalar(strlogtype);
                if (logtype == "")
                {
                    Response.Redirect("AdminPage.aspx");
                }
                else if (logtype == "user")
                {
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    Label5.Text = "Invalid Username Or Password";
                }
            }
        }

        //protected void LinkButton3_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("AdminReg.aspx");
        //}
    }
}