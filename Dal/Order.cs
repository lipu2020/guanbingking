using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace guanbingking.DAL
{
    /// <summary>
    /// 数据访问类:Order
    /// </summary>
    public partial class Order
    {
        public Order()
        { }
        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Id", "Order");
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Order");
            strSql.Append(" where Id=" + Id + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(guanbingking.Model.Order model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.Id != null)
            {
                strSql1.Append("Id,");
                strSql2.Append("" + model.Id + ",");
            }
            if (model.OrderCode != null)
            {
                strSql1.Append("OrderCode,");
                strSql2.Append("'" + model.OrderCode + "',");
            }
            if (model.Amount != null)
            {
                strSql1.Append("Amount,");
                strSql2.Append("" + model.Amount + ",");
            }
            if (model.CompanyId != null)
            {
                strSql1.Append("CompanyId,");
                strSql2.Append("" + model.CompanyId + ",");
            }
            if (model.Contacter != null)
            {
                strSql1.Append("Contacter,");
                strSql2.Append("'" + model.Contacter + "',");
            }
            if (model.ContactMobile != null)
            {
                strSql1.Append("ContactMobile,");
                strSql2.Append("" + model.ContactMobile + ",");
            }
            if (model.Address != null)
            {
                strSql1.Append("Address,");
                strSql2.Append("'" + model.Address + "',");
            }
            if (model.Payway != null)
            {
                strSql1.Append("Payway,");
                strSql2.Append("" + model.Payway + ",");
            }
            if (model.Status != null)
            {
                strSql1.Append("Status,");
                strSql2.Append("" + model.Status + ",");
            }
            if (model.PaytradeNo != null)
            {
                strSql1.Append("PaytradeNo,");
                strSql2.Append("'" + model.PaytradeNo + "',");
            }
            if (model.Remark != null)
            {
                strSql1.Append("Remark,");
                strSql2.Append("'" + model.Remark + "',");
            }
            if (model.CreateDate != null)
            {
                strSql1.Append("CreateDate,");
                strSql2.Append("'" + model.CreateDate + "',");
            }
            strSql.Append("insert into Order(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(guanbingking.Model.Order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Order set ");
            if (model.OrderCode != null)
            {
                strSql.Append("OrderCode='" + model.OrderCode + "',");
            }
            else
            {
                strSql.Append("OrderCode= null ,");
            }
            if (model.Amount != null)
            {
                strSql.Append("Amount=" + model.Amount + ",");
            }
            else
            {
                strSql.Append("Amount= null ,");
            }
            if (model.CompanyId != null)
            {
                strSql.Append("CompanyId=" + model.CompanyId + ",");
            }
            else
            {
                strSql.Append("CompanyId= null ,");
            }
            if (model.Contacter != null)
            {
                strSql.Append("Contacter='" + model.Contacter + "',");
            }
            else
            {
                strSql.Append("Contacter= null ,");
            }
            if (model.ContactMobile != null)
            {
                strSql.Append("ContactMobile=" + model.ContactMobile + ",");
            }
            else
            {
                strSql.Append("ContactMobile= null ,");
            }
            if (model.Address != null)
            {
                strSql.Append("Address='" + model.Address + "',");
            }
            else
            {
                strSql.Append("Address= null ,");
            }
            if (model.Payway != null)
            {
                strSql.Append("Payway=" + model.Payway + ",");
            }
            else
            {
                strSql.Append("Payway= null ,");
            }
            if (model.Status != null)
            {
                strSql.Append("Status=" + model.Status + ",");
            }
            else
            {
                strSql.Append("Status= null ,");
            }
            if (model.PaytradeNo != null)
            {
                strSql.Append("PaytradeNo='" + model.PaytradeNo + "',");
            }
            else
            {
                strSql.Append("PaytradeNo= null ,");
            }
            if (model.Remark != null)
            {
                strSql.Append("Remark='" + model.Remark + "',");
            }
            else
            {
                strSql.Append("Remark= null ,");
            }
            if (model.CreateDate != null)
            {
                strSql.Append("CreateDate='" + model.CreateDate + "',");
            }
            else
            {
                strSql.Append("CreateDate= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where Id=" + model.Id + " ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Order ");
            strSql.Append(" where Id=" + Id + " ");
            int rowsAffected = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }		/// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Order ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public guanbingking.Model.Order GetModel(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" Id,OrderCode,Amount,CompanyId,Contacter,ContactMobile,Address,Payway,Status,PaytradeNo,Remark,CreateDate ");
            strSql.Append(" from Order ");
            strSql.Append(" where Id=" + Id + " ");
            guanbingking.Model.Order model = new guanbingking.Model.Order();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public guanbingking.Model.Order DataRowToModel(DataRow row)
        {
            guanbingking.Model.Order model = new guanbingking.Model.Order();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["OrderCode"] != null)
                {
                    model.OrderCode = row["OrderCode"].ToString();
                }
                if (row["Amount"] != null && row["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(row["Amount"].ToString());
                }
                if (row["CompanyId"] != null && row["CompanyId"].ToString() != "")
                {
                    model.CompanyId = int.Parse(row["CompanyId"].ToString());
                }
                if (row["Contacter"] != null)
                {
                    model.Contacter = row["Contacter"].ToString();
                }
                if (row["ContactMobile"] != null && row["ContactMobile"].ToString() != "")
                {
                    model.ContactMobile = int.Parse(row["ContactMobile"].ToString());
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["Payway"] != null && row["Payway"].ToString() != "")
                {
                    model.Payway = int.Parse(row["Payway"].ToString());
                }
                if (row["Status"] != null && row["Status"].ToString() != "")
                {
                    model.Status = int.Parse(row["Status"].ToString());
                }
                if (row["PaytradeNo"] != null)
                {
                    model.PaytradeNo = row["PaytradeNo"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,OrderCode,Amount,CompanyId,Contacter,ContactMobile,Address,Payway,Status,PaytradeNo,Remark,CreateDate ");
            strSql.Append(" FROM Order ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Id,OrderCode,Amount,CompanyId,Contacter,ContactMobile,Address,Payway,Status,PaytradeNo,Remark,CreateDate ");
            strSql.Append(" FROM Order ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM [Order] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append( strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from Order T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage2(String sql, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(sql);
            
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  Method
        #region  MethodEx

        #endregion  MethodEx
    }
}

