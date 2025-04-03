using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace ShopingWebSiteFirstProject
{
    public partial class EmailSend : System.Web.UI.Page
    {
        ConCls objcls = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                

                string getAdminEmail = "select Admin_Email from AdminRegTB where Admin_Id=" + Session["AdminId"];
                string adminEmail = objcls.Fn_Scalar(getAdminEmail);
                TextBox5.Text = adminEmail;

                string getUserEmail = "select User_Email from UserRegTB where User_Id=" + Session["rplyUsid"];
                string userEmail = objcls.Fn_Scalar(getUserEmail);
                TextBox2.Text = userEmail; 

                
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string getAdminName = "select Admin_Name from AdminRegTB where Admin_Id=" + Session["AdminId"];
            string admin = objcls.Fn_Scalar(getAdminName);
            string adminName = admin;

            string getUserName = "select User_Name from UserRegTB where User_Id=" + Session["rplyUsid"];
            string rplyUser = objcls.Fn_Scalar(getUserName);
            String rplyUserName = rplyUser;


            string fromName = adminName;
            string ToName = rplyUserName;
            string fromEmail = TextBox5.Text;
            string ToEmail = TextBox2.Text;
            string subject = TextBox4.Text;
            string body = TextBox3.Text;
            SendEmail(fromName, fromEmail, "bjao czph yavn ozal", ToName, ToEmail, subject, body);
            string upd = "update FeedbackTB set Replay_msg='Replay Send',Feedback_Status='Replay' where User_Id=" + Session["rplyUsid"];
            int i = objcls.Fn_NonQuery(upd);
            Response.Redirect("ViewFeedback.aspx");
        }

        public static void SendEmail(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)

        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        

    }
}