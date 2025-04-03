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
    public partial class Add_Games : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strdrop = "select Category_Id,Category_Name from CategoryTB";
                DataSet ds = objcls.Fn_Adapter(strdrop);
                
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Category_Name";
                DropDownList1.DataValueField = "Category_Id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "-Select-");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strlogo = "~/img/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(strlogo));
            string sel = "insert into ProductTB values('" + DropDownList1.SelectedItem.Value + "','" + TextBox1.Text + "','" + strlogo + "'," + TextBox2.Text + ",'" + TextBox3.Text + "'," + TextBox4.Text + ",'Available')";
            int i = objcls.Fn_NonQuery(sel);
            if (i == 1)
            {
                Response.Redirect("AdminHomePage.aspx");
            }
        }
    }
}