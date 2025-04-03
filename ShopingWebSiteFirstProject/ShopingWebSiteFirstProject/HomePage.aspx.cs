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
    public partial class HomePage : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string dlid = "select * from CategoryTB where Category_Status='Available'";
                DataSet ds = objcls.Fn_Adapter(dlid);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            
        }
        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int catid = Convert.ToInt32(e.CommandArgument);
            Session["catid"] = catid;
            Response.Redirect("ViewAllProduct.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string serach = "select * from CategoryTB where Category_Name like '%" + TextBox1.Text + "%'";
            DataSet ds = objcls.Fn_Adapter(serach);
            DataList1.DataSource = ds;
            DataList1.DataBind();

        }
    }
}