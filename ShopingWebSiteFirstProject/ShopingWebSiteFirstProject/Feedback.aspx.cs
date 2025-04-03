using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopingWebSiteFirstProject
{
    public partial class Feedback : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string addDate = DateTime.Now.ToString("yyyy-MM-dd");
            string fedIns = "insert into FeedbackTB values(" + Session["usid"] + ",'" + TextBox1.Text + "','','" + addDate + "','Active')";
            int i = objcls.Fn_NonQuery(fedIns);
            if (i == 1)
            {
                Label2.Visible = true;
                Label2.Text = "Feedback Send Successfully";
            }

        }
    }
}