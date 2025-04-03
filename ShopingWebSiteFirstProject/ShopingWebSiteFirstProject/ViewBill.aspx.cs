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
    public partial class ViewBill : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_Grid();

                string strBill = "select UserRegTB.User_Id,UserRegTB.User_Name,UserRegTB.User_Email," +
                    "BillTB.Bill_Id,BillTB.GrandTotal,BillTB.Date " +
                    "from UserRegTB inner join BillTB on UserRegTb.User_Id = BillTB.User_Id where BillTB.User_Id = " + Session["usid"];
                SqlDataReader dr = objcls.Fn_Reader(strBill);
                while (dr.Read())
                {
                    Label2.Text = dr["User_Name"].ToString();
                    Label3.Text = dr["User_Email"].ToString();
                    Label4.Text = dr["GrandTotal"].ToString();
                }
            }
        }

        public void Bind_Grid()
        {
            string grid = "select ProductTB.Product_Id,ProductTB.Product_Name," +
                "OrderTB.Order_Id,OrderTB.Quantity,OrderTB.Subtotal,OrderTB.Order_Status " +
                "from OrderTB INNER JOIN ProductTB ON OrderTB.Product_Id = ProductTB.Product_Id WHERE OrderTB.Order_Status='Order' and OrderTB.User_Id = " + Session["usid"];
            DataSet ds = objcls.Fn_Adapter(grid);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
                Response.Redirect("Payment.aspx");
            
        }
    }
}