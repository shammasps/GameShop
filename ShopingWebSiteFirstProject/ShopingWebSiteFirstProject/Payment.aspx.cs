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
    public partial class Payment : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               AccDetails();
            }
        }

        public void AccDetails()
        {
            string accLoad = "select Account_No,Account_type,Balance_Amount from AccountTB where User_Id=" + Session["usid"];
            SqlDataReader dr = objcls.Fn_Reader(accLoad);
            while (dr.Read())
            {
                TextBox1.Text = dr["Account_No"].ToString();
                TextBox2.Text = dr["Account_type"].ToString();
                TextBox3.Text = dr["Balance_Amount"].ToString();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            Account_Bal_Up_Service.ServiceClient acobj = new Account_Bal_Up_Service.ServiceClient();
            long accountNo = Convert.ToInt64(TextBox1.Text);
            long enteredBalance = Convert.ToInt64(TextBox3.Text);
            long updatedBalance = acobj.updateBalance(enteredBalance, accountNo);

            string checkAc = "select count(*) from AccountTB where User_Id=" + Session["usid"];
            string cid = objcls.Fn_Scalar(checkAc);
            string acUpOrIns;
            if (cid == "1")
            {
                acUpOrIns = "update AccountTB set Account_No=" + accountNo + ",Account_type='" + TextBox2.Text + "',Balance_Amount=" + updatedBalance + " where User_Id=" + Session["usid"];

            }
            else
            {
                acUpOrIns= "insert into AccountTB values(" + Session["usid"] + "," + accountNo + ",'" + TextBox2.Text + "'," + updatedBalance + ")";
            }
            int i = objcls.Fn_NonQuery(acUpOrIns);
            if (i == 1)
            {
                Label6.Visible = true;
                Label6.Text = "Account details saved successfully";
            }
            AccDetails();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Account_Bal_Up_Service.ServiceClient acobj = new Account_Bal_Up_Service.ServiceClient();
            long bal= acobj.getBalance(Convert.ToInt64(TextBox1.Text));
            string serviceCheck = "select GrandTotal from BillTB where User_Id=" + Session["usid"];
            string sercid = objcls.Fn_Scalar(serviceCheck);
            long GrandBal = Convert.ToInt64(sercid);
            if (GrandBal != 0)
            {
                if (bal > GrandBal)
                {
                    
                    long updateBal = bal - GrandBal;
                    acobj.updateBalance(updateBal, Convert.ToInt64(TextBox1.Text));

                    AccDetails();

                    string strU = "update OrderTB set Order_Status='Paid' where User_Id = " + Session["usid"];
                    int sUp = objcls.Fn_NonQuery(strU);

                    List<int> proId = new List<int>();
                    List<int> quantity = new List<int>();

                    string str = "select Product_Id,Quantity from OrderTB where Order_Status='Paid' and User_Id=" + Session["usid"];
                    SqlDataReader dr = objcls.Fn_Reader(str);
                    while (dr.Read())
                    {
                        proId.Add(Convert.ToInt32(dr["Product_Id"]));
                        quantity.Add(Convert.ToInt32(dr["Quantity"]));
                    }
                    for(int i = 0; i < proId.Count; i++)
                    {
                        int productId = proId[i];
                        int orderedQty = quantity[i];

                        string stock = "select Product_Stock from ProductTB where Product_Id=" + productId;
                        int currentStock = Convert.ToInt32(objcls.Fn_Scalar(stock));

                        int newStock = currentStock - orderedQty;
                        if (newStock >= 0)
                        {
                            string updateStock= "update ProductTB set Product_Stock="+newStock+ " where Product_Id=" + productId;
                            int updateQ = objcls.Fn_NonQuery(updateStock);
                            Response.Redirect("TrackOrder.aspx");

                        }
                        else
                        {
                            Label7.Visible = true;
                            Label7.Text = "Out OF Stock";
                        }
                    }
                }
                else
                {
                    Label7.Visible = true;
                    Label7.Text = "Insufficient balance";

                }
                
            }
        }
    }
}