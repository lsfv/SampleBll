using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SampleBll
{
    public class WebServicesGateway: System.Web.Services.WebService
    {
        public readonly static string SESSION_LOGINID = "loginID";
        public WebServicesGateway()
        {
            if (Session == null || Session[SESSION_LOGINID]==null)
            {
                this.Context.Response.Write("<Message>please login!</Message>");
                this.Context.Response.End();
            }
        }
    }
}