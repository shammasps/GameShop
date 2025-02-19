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
    public partial class AdminReg : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from LoginTB";
            string maxregid = objcls.Fn_Scalar(sel);
            int regId = 0;
            if (maxregid == "")
            {
                regId = 1;
            }
            else
            {
                int newRegId = Convert.ToInt32(maxregid);
                regId = newRegId + 1;
            }   


            string ins = "insert into AdminRegTB values(" + regId + ",'" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ",'" + TextBox4.Text + "')";
            int i = objcls.Fn_NonQuery(ins);
            if (i == 1)
            {
                
                string insLogin = "insert into LoginTB values(" + regId + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','')";
                int j = objcls.Fn_NonQuery(insLogin);
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}