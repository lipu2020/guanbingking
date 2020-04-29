using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Data;

namespace guanbingking.Controllers
{
    [Filters.AuthorizeFilter]
    [Filters.CrudAction]
    public class SuppliersController : Controller
    {
        //
        // GET: /Suppliers/

        public ActionResult Index()
        {
            return View();
        }

        //列表
        [HttpGet]
        public ActionResult List()
        {
            StringBuilder sb = new StringBuilder();
            int page = int.Parse(Request.QueryString["page"].ToString());
            int limit = int.Parse(Request.QueryString["limit"].ToString());

            string where = "1=1";
            if (!String.IsNullOrEmpty(Request.QueryString["name"]))
            {
                where += " and CompanyName like '%" + Request.QueryString["name"] + "%'";
            }

            DataTable dt = new BLL.Company().GetListByPage(where,"id",(page-1)*limit,page*limit).Tables[0];
            sb.Append("{\"status\": 200,\"message\": \"\",\"total\": "+new BLL.Company().GetRecordCount(where)+",\"rows\": {\"item\": [");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i > 0) { sb.Append(","); }
                sb.Append("{\"id\":"+dt.Rows[i]["id"]+",\"companymame\":\"" + dt.Rows[i]["CompanyName"] + "\",\"address\":\"" + dt.Rows[i]["Address"] + "\",\"contact\":\"" + dt.Rows[i]["contact"] + "\",\"phone\":\"" + dt.Rows[i]["phone"] + "\"}");
            }
            sb.Append("]}}");

            return Content(sb.ToString());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Model.Company company)
        {
            company.Category = 1;
            if (new BLL.Company().Add(company)>0)
            {
                return Json(new { success = 0, msg = "提交成功" });
            }
            else
            {
                return Json(new { success=0,msg="提交失败"});
            }
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            ViewData.Model = new BLL.Company().GetModel(int.Parse(id));
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Model.Company company)
        {
            if (new BLL.Company().Update(company))
            {
                return Json(new { success = 0, msg = "提交成功" });
            }
            else
            {
                return Json(new { success = 0, msg = "提交失败" });
            }
        }

        [HttpPost]
        public ActionResult Del(string id)
        {
            if (new BLL.Company().Delete(int.Parse(id)))
            {
                return Json(new { success = 0, msg = "提交成功" });
            }
            else
            {
                return Json(new { success = 0, msg = "提交失败" });
            }
        }

        public ActionResult Show(string id)
        {
            ViewData.Model = new BLL.Company().GetModel(int.Parse(id));
            return View();
        }
    }
}
