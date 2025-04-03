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
    public partial class ViewFeedback : System.Web.UI.Page
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
            string grid = "select FeedbackTB.*, UserRegTB.User_Name from FeedbackTB INNER JOIN UserRegTB on FeedbackTB.User_Id = UserRegTB.User_Id where Feedback_Status='Active'";
            DataSet ds = objcls.Fn_Adapter(grid);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            int replayId = Convert.ToInt32(e.CommandArgument);
            Session["rplyUsid"] = replayId;
            Response.Redirect("EmailSend.aspx");
           
        }
    }
}