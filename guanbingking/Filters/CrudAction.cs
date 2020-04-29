using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;


namespace guanbingking.Filters
{
    public class CrudAction:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //base.OnActionExecuting(filterContext);
            string ActionName = filterContext.ActionDescriptor.ActionName.ToLower();
            string Url = filterContext.HttpContext.Request.CurrentExecutionFilePath.Trim('/').Split('/')[0] + "";

            string id = Common.Security.DESDecrypt( filterContext.HttpContext.Request.Cookies["account"].Values["id"].ToString());

            Model.Account account = new BLL.Account().GetModel(int.Parse(id));

            DataRow[] menu = DbHelperSQL.QueryDT("select * from RoleList"
                                            + " inner join Menu on Menu.Id=RoleList.Menuid where roleid=" + account.RoleId).Select("url like '%" + Url + "%'");
            //DataRow[] menu = ((DataTable)filterContext.HttpContext.Session["Role"]).Select("url like '%" + Url + "%'");

            if (menu.Length > 0)
            {
                //增加权限
                if (ActionName == "add" && menu[0]["Add"].ToString() == "1")
                {

                }
                else if (ActionName == "edit" && menu[0]["Edit"].ToString() == "1")
                {

                }
                else if (ActionName == "del" && menu[0]["Del"].ToString() == "1")
                {

                }
                else if (ActionName == "show" && menu[0]["Show"].ToString() == "1")
                {

                }
                else if (ActionName == "list")
                {

                }
                else if (ActionName == "index")
                {
                    filterContext.Controller.ViewBag.Add = menu[0]["Add"].ToString() == "1" ? true : false;
                    filterContext.Controller.ViewBag.Edit = menu[0]["Edit"].ToString() == "1" ? true : false;
                    filterContext.Controller.ViewBag.Del = menu[0]["Del"].ToString() == "1" ? true : false;
                    filterContext.Controller.ViewBag.Show = menu[0]["Show"].ToString() == "1" ? true : false;
                }
                else
                {
                    filterContext.Result = new ContentResult() { Content = "{success=-1,msg=\"无权限\"}", ContentType = "application/json" };
                }
            }
            else
            {
                filterContext.Result = new ContentResult() { Content = "无权限" };
            }
        }
    }
}