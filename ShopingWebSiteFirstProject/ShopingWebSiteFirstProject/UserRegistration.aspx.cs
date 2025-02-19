using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopingWebSiteFirstProject
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from LoginTB";
            string maxRegId = objcls.Fn_Scalar(sel);
            int regId = 0;
            if (maxRegId == "")
            {
                regId = 1;
            }
            else
            {
                int newRegId = Convert.ToInt32(maxRegId);
                regId = newRegId + 1;
            }

            string img = "~/img/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(img));

            string ins = "insert into UserRegTB values(" + regId + ",'" + TextBox1.Text + "'," + TextBox2.Text + "," + TextBox3.Text + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + img + "','user')";
            int i = objcls.Fn_NonQuery(ins);
            if (i == 1)
            {
                string insLogin = "insert into LoginTB values(" + regId + ",'" + TextBox7.Text + "','" + TextBox8.Text + "','user')";
                int j = objcls.Fn_NonQuery(insLogin);
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}