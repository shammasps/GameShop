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
    public partial class ViewOrderDetails : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_Grid();
            }

        }
        public void Bind_Grid()
        {
            string grid = "select UserRegTB.User_Name,ProductTB.Product_Name,OrderTB.Quantity,OrderTB.Subtotal,OrderTB.Order_Id " +
                "from OrderTB INNER JOIN UserRegTB on OrderTB.User_Id=UserRegTB.User_Id " +
                " INNER JOIN ProductTB on OrderTB.Product_Id=ProductTB.Product_Id " +
                "where OrderTB.Order_Status='Paid'";
            DataSet ds = objcls.Fn_Adapter(grid);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            int orderId = Convert.ToInt32(e.CommandArgument);
            string strup = "update OrderTB set Order_Status='Deliverd' where Order_Id = " + orderId;
            int i = objcls.Fn_NonQuery(strup);
            Bind_Grid();
        }
    }
}