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
    public partial class ViewCart : System.Web.UI.Page
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
            string grid = "select ProductTB.Product_Id,ProductTB.Product_Photo,ProductTB.Product_Name,ProductTB.Product_Price," +
                "CartTB.Cart_Id,CartTB.Quantity,CartTB.Subtotal " +
                "from CartTB INNER JOIN ProductTB ON CartTB.Product_Id = ProductTB.Product_Id WHERE CartTB.User_Id = " + Session["usid"];
            DataSet ds = objcls.Fn_Adapter(grid);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            string totalQ = "select Sum(Subtotal) from CartTB where User_Id = " + Session["usid"];
            string totalP = objcls.Fn_Scalar(totalQ);
            if (totalP == "")
            {
                Label2.Text = "0";
            }
            else
            {

                Label2.Text = totalP;
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind_Grid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Bind_Grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int cartId = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox textQ = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            int newQ = Convert.ToInt32(textQ.Text);

            string priceQ = "select Product_Price from ProductTB inner join CartTB on ProductTB.Product_Id = CartTB.Product_Id WHERE Cart_Id = " + cartId;
            string proP = objcls.Fn_Scalar(priceQ);
            int proPrice = Convert.ToInt32(proP);

            int newSubT = newQ * proPrice;
            string strup = "update CartTB set Quantity=" + newQ + ",Subtotal="+newSubT+" where Cart_Id=" + cartId + "";
            int j = objcls.Fn_NonQuery(strup);
            GridView1.EditIndex = -1;
            Bind_Grid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from CartTB where Cart_Id=" + getid + "";
            int d = objcls.Fn_NonQuery(del);
            Bind_Grid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string strsel = "select Max(Cart_Id) from CartTB";
            string strselC = objcls.Fn_Scalar(strsel);
            if (strselC == "")
            {
                Label4.Visible = true;
                Label4.Text = "No items in Cart";
            }
            else
            {
                int selMaxC = Convert.ToInt32(strselC);
                for (int i = 1; i <= selMaxC; i++)
                {
                    string sel = "select * from CartTB where Cart_Id=" + i + " and User_Id=" + Session["usid"] + " ";
                    SqlDataReader dr = objcls.Fn_Reader(sel);
                    int proId = 0;
                    int quantity = 0;
                    int subtotal = 0;
                    while (dr.Read())
                    {
                        proId = Convert.ToInt32(dr["Product_Id"]);
                        quantity = Convert.ToInt32(dr["Quantity"]);
                        subtotal = Convert.ToInt32(dr["Subtotal"]);
                    }
                    string strins = "insert into OrderTB values(" + Session["usid"] + "," + proId + "," + quantity + "," + subtotal + ",'Order')";
                    int j = objcls.Fn_NonQuery(strins);
                    string strDlt = "delete from CartTB where Cart_Id=" + i + "";
                    int d = objcls.Fn_NonQuery(strDlt);
                }
                string addDate = DateTime.Now.ToString("yyyy-MM-dd");
                string totalQ = "select Sum(Subtotal) from OrderTB where Order_Status='Order' and User_Id = " + Session["usid"];
                string totalP = objcls.Fn_Scalar(totalQ);
                string insBill = "insert into BillTB values(" + Session["usid"] + "," + totalP + ",'" + addDate + "')";
                int ins = objcls.Fn_NonQuery(insBill);
                Response.Redirect("ViewBill.aspx");
            }
            
        }

 
    }
}