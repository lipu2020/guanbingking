using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace guanbingking.Common
{
    public static class WebCookie
    {
        public static void AddCookie(string id,string name,string type,string companyid)
        {
            HttpCookie cookie = new HttpCookie("account");
            cookie.Values.Add("id",Common.Security.DESEncrypt(id));
            cookie.Values.Add("name", name);
            cookie.Values.Add("type", type);
            cookie.Values.Add("companyid", Common.Security.DESEncrypt(companyid));
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public static void RemoveCookie()
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["account"];
            cookie.Expires = DateTime.Now.AddDays(-1);
        }
    }
}