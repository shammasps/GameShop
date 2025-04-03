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
    public partial class ViewProduct : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string proid = "select * from ProductTB where Product_Id=" + Session["ProId"] + "";
                SqlDataReader dr = objcls.Fn_Reader(proid);
                while (dr.Read())
                {
                    Image1.ImageUrl = dr["Product_Photo"].ToString();
                    Label1.Text = dr["Product_Name"].ToString();
                    Label2.Text = dr["Product_Price"].ToString();
                    Label3.Text = dr["Product_Description"].ToString();
                    Label4.Text = dr["Product_Stock"].ToString();
                }
            }
        }
        
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int avlbstock = Convert.ToInt32(Label4.Text);
            int enterQty = Convert.ToInt32(TextBox1.Text);
            if (enterQty > avlbstock)
            {
                Label8.Visible = true;
                Label8.Text = "Out Of Stock";
            }
            else
            {
                Label8.Visible = false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            string addedDate = DateTime.Now.ToString("yyyy-MM-dd");
            int quantity = Convert.ToInt32(TextBox1.Text);
            string strsel = "select max(Cart_Id) from CartTB";
            string maxcartId = objcls.Fn_Scalar(strsel);
            
            int cartId = 0;
            if (maxcartId == "")
            {
                cartId = 1;
            }
            else
            {
                int cartProId = Convert.ToInt32(maxcartId);
                cartId = cartProId + 1;
            }

            string str = "select Product_Price from ProductTB where Product_Id=" + Session["ProId"] + "";
            string proprice = objcls.Fn_Scalar(str);
            int price = Convert.ToInt32(proprice);
            int subTotal = price * quantity;
            

            string inscart = "insert into CartTB values(" + cartId + "," + Session["usid"] + "," + Session["ProId"] + "," + TextBox1.Text + "," + subTotal + ",'"+ addedDate + "')";
            int i = objcls.Fn_NonQuery(inscart);
            if (i == 1)
            {
                Label9.Visible = true;
                Label9.Text = "Cart Added Success";
            }
            else
            {
                Label9.Visible = false;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllProduct.aspx");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ViewCart.aspx");
        }
    }
}