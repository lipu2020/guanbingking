using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using guanbingking;
using guanbingking.Common;
using System.Data;
using System.Text;


namespace guanbingking.Controllers
{

    public class MainController : Controller
    {
        //
        // GET: /Main/
        [Filters.AuthorizeFilter]
        [Filters.CrudAction]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //登录操作
        [HttpPost]
        public ActionResult Login(string UserName, string UserPwd)
        {
            Model.Account ac = new BLL.Account().Login(UserName, Common.Security.Md5Hash(UserPwd),"0,1");
            if (ac != null)
            {
                WebCookie.AddCookie(ac.Id.ToString(),ac.AccountName,ac.AType.ToString(),ac.CompanyId.ToString());//存cookie

                var result = new
                {
                    success = 0,
                    msg = "登录成功"
                };
                return Json(result);
            }
            else
            {
                var result = new
                {
                    success = 1,
                    msg = "登录失败"
                };
                return Json(result);
            }
        }

        //退出操作
        [Filters.AuthorizeFilter]
        [HttpGet]
        public ActionResult LoginOut()
        {
            //清除登录
            WebCookie.RemoveCookie();
            return Redirect(Url.Action("login", "main"));
        }

        //获取菜单
        [HttpPost]
        [Filters.AuthorizeFilter]
        public ActionResult Menu()
        {
            string id = Common.Security.DESDecrypt(Request.Cookies["account"].Values["id"].ToString());

            Model.Account account = new BLL.Account().GetModel(int.Parse(id));

            DataTable menu = DbHelperSQL.QueryDT("select * from RoleList"
                                    + " inner join Menu on Menu.Id=RoleList.menuid where roleid="+account.RoleId);

            StringBuilder sb = new StringBuilder();
            sb.Append("{\"menu\":[");
            int count = 0;
            foreach(DataRow r in menu.Select("parentid=0","order asc"))
            {
                if (count > 0)
                {
                    sb.Append(",");
                }
                sb.Append("{\"menu\":\""+r["menuname"]+"\",\"img\":\""+r["img"]+"\",\"url\":\""+r["url"]+"\",\"data\":[");
                int scount = 0;
                foreach (DataRow sr in menu.Select("parentid="+r["id"],"order asc"))
                {
                    if (scount > 0)
                    {
                        sb.Append(",");
                    }
                    sb.Append("{\"menu\":\"" + sr["menuname"] + "\",\"img\":\"" + sr["img"] + "\",\"url\":\"" + sr["url"] + "\"}");
                }
                sb.Append("]}");
                count++;
            }
            sb.Append("]}");
            return Content(sb.ToString());
        }
    }
}
