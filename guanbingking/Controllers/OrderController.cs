using Maticsoft.DBUtility;
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
    public class OrderController : Controller
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
            String select = "SELECT  ROW_NUMBER() OVER (order by a.Id desc)AS Row,a.*,c.CompanyName,b.Id as pid,b.ProductName,b.ProductClass,b.Unit,b.Price,b.Cost,b.Spec,b.ProductCount,b.OrderId  ";
            String sql = " from [Order] a left join  Company c on a.CompanyId=c.Id left join OrderProduct b  on a.Id=b.OrderId ";

           
            string where = " where 1=1";
            if (!String.IsNullOrEmpty(Request.QueryString["orderCode"]))
            {
                where += " and orderCode like '%" + Request.QueryString["orderCode"] + "%'";
            }
            if (!String.IsNullOrEmpty(Request.QueryString["status"]))
            {
                where += " and status = " + Request.QueryString["status"];
            }

            DataTable dt = new BLL.Order().GetListByPage2(select+sql + where, "id", (page - 1) * limit, page * limit).Tables[0];
            sb.Append("{\"status\": 200,\"message\": \"\",\"total\": " + new BLL.Order().GetRecordCount(where) + ",\"rows\": {\"item\": [");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i > 0) { sb.Append(","); }
                sb.Append("{\"id\":" + dt.Rows[i]["Id"] + ",\"orderCode\":\"" + dt.Rows[i]["OrderCode"] + "\",\"productName\":\"" + dt.Rows[i]["ProductName"] + "\",\"productCount\":\"" + dt.Rows[i]["ProductCount"] + "\",\"price\":" + dt.Rows[i]["Price"] );
                sb.Append(",\"productClass\":\"" + dt.Rows[i]["ProductClass"]+"\"");
                sb.Append(",\"companyName\":\"" + dt.Rows[i]["CompanyName"] + "\"");
                sb.Append(",\"contacter\":\"" + dt.Rows[i]["Contacter"] + "\"");
                sb.Append(",\"contactMobile\":" + dt.Rows[i]["ContactMobile"]);
                sb.Append(",\"address\":\"" + dt.Rows[i]["Address"] + "\"");
                sb.Append(",\"amount\":" + dt.Rows[i]["Amount"]);
                sb.Append(",\"cost\":" + dt.Rows[i]["Cost"]);
                sb.Append(",\"createDate\":\"" + dt.Rows[i]["CreateDate"] + "\"");
                if (dt.Rows[i]["Status"].ToString()=="0")
                {
                    sb.Append(",\"status\":\"未支付\"");
                }
                else if (dt.Rows[i]["Status"].ToString() == "1")
                {
                    sb.Append(",\"status\":\"已支付\"");
                }
                else if (dt.Rows[i]["Status"].ToString() == "9")
                {
                    sb.Append(",\"status\":\"已退货\"");
                }
                else if (dt.Rows[i]["Status"].ToString() == "-1")
                {
                    sb.Append(",\"status\":\"已删除\"");
                }
                sb.Append("}");
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
            ViewData.Model = new BLL.Order().GetModel(int.Parse(id));
            return View();
        }
    }
}
