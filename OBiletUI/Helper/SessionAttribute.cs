using OBiletHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OBiletUI.Helper
{
    public class SessionAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return httpContext.Session["Session"] != null;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            SessionService sessionService = new SessionService();
            filterContext.HttpContext.Session["Session"] = sessionService.GetSession(new OBiletHelper.Model.Request.SessionRequest()
            {
                Browser = new OBiletHelper.Model.Request.BrowserRequest() { Name = "Chrome", Version = "47.0.0.12" },
                Connection = new OBiletHelper.Model.Request.ConnectionRequest() { IpAddress = "165.114.41.21", Port = "5117" },
                Type = 1
            });

        }

    }
}