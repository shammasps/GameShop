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
    public partial class Add_Categories : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string catimg = "~/img/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(catimg));
            string insCat = "insert into CategoryTB values('" + TextBox1.Text + "','" + catimg + "','" + TextBox2.Text + "','Available')";

            int i = objcls.Fn_NonQuery(insCat);
            if (i == 1)
            {
                Response.Redirect("AdminHomePage.aspx");
            }

        }
    }
}