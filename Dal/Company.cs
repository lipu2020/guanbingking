﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace guanbingking.DAL
{
    /// <summary>
    /// 数据访问类:Company
    /// </summary>
    public partial class Company
    {
        public Company()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Id", "Company");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Company");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(guanbingking.Model.Company model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Company(");
            strSql.Append("CompanyName,Category,Leve,SignStart,SignEnd,Address,Contact,Phone)");
            strSql.Append(" values (");
            strSql.Append("@CompanyName,@Category,@Leve,@SignStart,@SignEnd,@Address,@Contact,@Phone)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyName", SqlDbType.VarChar,100),
					new SqlParameter("@Category", SqlDbType.Int,4),
					new SqlParameter("@Leve", SqlDbType.Int,4),
					new SqlParameter("@SignStart", SqlDbType.Date,3),
					new SqlParameter("@SignEnd", SqlDbType.Date,3),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@Contact", SqlDbType.VarChar,50),
					new SqlParameter("@Phone", SqlDbType.VarChar,50)};
            parameters[0].Value = model.CompanyName;
            parameters[1].Value = model.Category;
            parameters[2].Value = model.Leve;
            parameters[3].Value = model.SignStart;
            parameters[4].Value = model.SignEnd;
            parameters[5].Value = model.Address;
            parameters[6].Value = model.Contact;
            parameters[7].Value = model.Phone;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(guanbingking.Model.Company model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Company set ");
            strSql.Append("CompanyName=@CompanyName,");
            strSql.Append("Category=@Category,");
            strSql.Append("Leve=@Leve,");
            strSql.Append("SignStart=@SignStart,");
            strSql.Append("SignEnd=@SignEnd,");
            strSql.Append("Address=@Address,");
            strSql.Append("Contact=@Contact,");
            strSql.Append("Phone=@Phone");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyName", SqlDbType.VarChar,100),
					new SqlParameter("@Category", SqlDbType.Int,4),
					new SqlParameter("@Leve", SqlDbType.Int,4),
					new SqlParameter("@SignStart", SqlDbType.Date,3),
					new SqlParameter("@SignEnd", SqlDbType.Date,3),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@Contact", SqlDbType.VarChar,50),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.CompanyName;
            parameters[1].Value = model.Category;
            parameters[2].Value = model.Leve;
            parameters[3].Value = model.SignStart;
            parameters[4].Value = model.SignEnd;
            parameters[5].Value = model.Address;
            parameters[6].Value = model.Contact;
            parameters[7].Value = model.Phone;
            parameters[8].Value = model.Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Company ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Company ");
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
        public guanbingking.Model.Company GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,CompanyName,Category,Leve,SignStart,SignEnd,Address,Contact,Phone from Company ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            guanbingking.Model.Company model = new guanbingking.Model.Company();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
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
        public guanbingking.Model.Company DataRowToModel(DataRow row)
        {
            guanbingking.Model.Company model = new guanbingking.Model.Company();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["CompanyName"] != null)
                {
                    model.CompanyName = row["CompanyName"].ToString();
                }
                if (row["Category"] != null && row["Category"].ToString() != "")
                {
                    model.Category = int.Parse(row["Category"].ToString());
                }
                if (row["Leve"] != null && row["Leve"].ToString() != "")
                {
                    model.Leve = int.Parse(row["Leve"].ToString());
                }
                if (row["SignStart"] != null && row["SignStart"].ToString() != "")
                {
                    model.SignStart = DateTime.Parse(row["SignStart"].ToString());
                }
                if (row["SignEnd"] != null && row["SignEnd"].ToString() != "")
                {
                    model.SignEnd = DateTime.Parse(row["SignEnd"].ToString());
                }
                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }
                if (row["Contact"] != null)
                {
                    model.Contact = row["Contact"].ToString();
                }
                if (row["Phone"] != null)
                {
                    model.Phone = row["Phone"].ToString();
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
            strSql.Append("select Id,CompanyName,Category,Leve,SignStart,SignEnd,Address,Contact,Phone ");
            strSql.Append(" FROM Company ");
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
            strSql.Append(" Id,CompanyName,Category,Leve,SignStart,SignEnd,Address,Contact,Phone ");
            strSql.Append(" FROM Company ");
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
            strSql.Append("select count(1) FROM Company ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            strSql.Append(")AS Row, T.*  from Company T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "Company";
            parameters[1].Value = "Id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

