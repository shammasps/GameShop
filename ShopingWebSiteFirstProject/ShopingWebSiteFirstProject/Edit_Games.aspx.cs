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
    public partial class Edit_Games : System.Web.UI.Page
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
            string grid = "select * from ProductTB";
            DataSet ds = objcls.Fn_Adapter(grid);
            GridView1.DataSource = ds;
            GridView1.DataBind();
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
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox textna = (TextBox)GridView1.Rows[i].Cells[1].Controls[0];
            TextBox textDes = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            TextBox textStock = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox textSta = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            string strup = "update ProductTB set Product_Name='" + textna.Text+ "', Product_Description='" + textDes.Text + "',Product_Stock='"+textStock.Text+ "',Product_Status='" + textSta.Text + "' where Product_Id=" + getid + "";
            int j = objcls.Fn_NonQuery(strup);
            GridView1.EditIndex = -1;
            Bind_Grid();
        }
        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int proId = Convert.ToInt32(e.CommandArgument);
            Session["imgId"] = proId;
            Response.Redirect("ProductImageEdit.aspx");
        }
    }
}