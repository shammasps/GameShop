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
    public partial class ViewAllProduct : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string dlid = "select * from ProductTB where Product_Status='Available' and Category_Id=" + Session["catId"] + "";
                DataSet ds = objcls.Fn_Adapter(dlid);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int getProId = Convert.ToInt32(e.CommandArgument);
            Session["ProId"] = getProId;

            Response.Redirect("ViewProduct.aspx");
        }
    }
}