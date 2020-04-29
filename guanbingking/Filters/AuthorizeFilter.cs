using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace guanbingking.Filters
{
    public class AuthorizeFilter:AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //base.OnAuthorization(filterContext);
            try
            {
                string id = Common.Security.DESDecrypt(filterContext.HttpContext.Request.Cookies["account"].Values["id"].ToString());
                Model.Account account = new BLL.Account().GetModel(int.Parse(id));
                if (account != null)
                {

                }
                else
                {
                    filterContext.Result=new RedirectResult("/main/login");
                }
            }
            catch
            {
                filterContext.Result = new RedirectResult("/main/login");
            }
        }
    }
}