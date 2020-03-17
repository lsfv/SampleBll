using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Services;

namespace SampleBll
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class Login : System.Web.Services.WebService
    {
        [WebMethod(EnableSession = true)]
        public void LoginCheck(string uid, string password)
        {
            bool res = false;
            string hashuid = "admin"; // System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("admin", "MD5");
            string hashpassword = "123"; System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("123", "MD5");
            if (uid.ToLower() == hashuid.ToLower() && password.ToLower() == hashpassword.ToLower())
            {
                if (Session != null)
                {
                    Context.Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
                }

                Session[WebServicesGateway.SESSION_LOGINID] = uid;


                string sessionID = this.Context.Session.SessionID;
                this.Context.Response.Write("<message>success</message>");
                this.Context.Response.Write("<sessionid>" + sessionID + "</sessionid>");
            }
            else
            {
                this.Context.Response.Write("<message>fail!</message>"+hashuid + "...." + hashpassword);
            }
        }
    }
}