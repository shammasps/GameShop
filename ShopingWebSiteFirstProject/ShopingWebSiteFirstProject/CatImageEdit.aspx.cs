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
    public partial class CatImageEdit : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string imgid = "select Category_Photo from CategoryTB where Category_Id=" + Session["imgId"] + "";
                SqlDataReader dr = objcls.Fn_Reader(imgid);
                while (dr.Read())
                {
                    Image1.ImageUrl = dr["Category_Photo"].ToString();
                }
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int imageId = Convert.ToInt32(Session["imgId"]);
            string img = "~/img/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(img));
            string strup = "update CategoryTB set Category_Photo='"+img+"' where Category_Id="+imageId;
            int i = objcls.Fn_NonQuery(strup);
            if (i == 1)
            {
                Response.Redirect("Edit_Category.aspx");
            }
        }
    }
}