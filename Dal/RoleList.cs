using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace guanbingking.DAL
{
    /// <summary>
    /// 数据访问类:RoleList
    /// </summary>
    public partial class RoleList
    {
        public RoleList()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from RoleList");
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
        public int Add(guanbingking.Model.RoleList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into RoleList(");
            strSql.Append("MenuId,Add,Edit,Del,Show,RoleId)");
            strSql.Append(" values (");
            strSql.Append("@MenuId,@Add,@Edit,@Del,@Show,@RoleId)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MenuId", SqlDbType.Int,4),
					new SqlParameter("@Add", SqlDbType.Int,4),
					new SqlParameter("@Edit", SqlDbType.Int,4),
					new SqlParameter("@Del", SqlDbType.Int,4),
					new SqlParameter("@Show", SqlDbType.Int,4),
					new SqlParameter("@RoleId", SqlDbType.Int,4)};
            parameters[0].Value = model.MenuId;
            parameters[1].Value = model.Add;
            parameters[2].Value = model.Edit;
            parameters[3].Value = model.Del;
            parameters[4].Value = model.Show;
            parameters[5].Value = model.RoleId;

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
        public bool Update(guanbingking.Model.RoleList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update RoleList set ");
            strSql.Append("MenuId=@MenuId,");
            strSql.Append("Add=@Add,");
            strSql.Append("Edit=@Edit,");
            strSql.Append("Del=@Del,");
            strSql.Append("Show=@Show,");
            strSql.Append("RoleId=@RoleId");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@MenuId", SqlDbType.Int,4),
					new SqlParameter("@Add", SqlDbType.Int,4),
					new SqlParameter("@Edit", SqlDbType.Int,4),
					new SqlParameter("@Del", SqlDbType.Int,4),
					new SqlParameter("@Show", SqlDbType.Int,4),
					new SqlParameter("@RoleId", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = model.MenuId;
            parameters[1].Value = model.Add;
            parameters[2].Value = model.Edit;
            parameters[3].Value = model.Del;
            parameters[4].Value = model.Show;
            parameters[5].Value = model.RoleId;
            parameters[6].Value = model.Id;

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
            strSql.Append("delete from RoleList ");
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
            strSql.Append("delete from RoleList ");
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
        public guanbingking.Model.RoleList GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,MenuId,Add,Edit,Del,Show,RoleId from RoleList ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            guanbingking.Model.RoleList model = new guanbingking.Model.RoleList();
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
        public guanbingking.Model.RoleList DataRowToModel(DataRow row)
        {
            guanbingking.Model.RoleList model = new guanbingking.Model.RoleList();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["MenuId"] != null && row["MenuId"].ToString() != "")
                {
                    model.MenuId = int.Parse(row["MenuId"].ToString());
                }
                if (row["Add"] != null && row["Add"].ToString() != "")
                {
                    model.Add = int.Parse(row["Add"].ToString());
                }
                if (row["Edit"] != null && row["Edit"].ToString() != "")
                {
                    model.Edit = int.Parse(row["Edit"].ToString());
                }
                if (row["Del"] != null && row["Del"].ToString() != "")
                {
                    model.Del = int.Parse(row["Del"].ToString());
                }
                if (row["Show"] != null && row["Show"].ToString() != "")
                {
                    model.Show = int.Parse(row["Show"].ToString());
                }
                if (row["RoleId"] != null && row["RoleId"].ToString() != "")
                {
                    model.RoleId = int.Parse(row["RoleId"].ToString());
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
            strSql.Append("select Id,MenuId,Add,Edit,Del,Show,RoleId ");
            strSql.Append(" FROM RoleList ");
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
            strSql.Append(" Id,MenuId,Add,Edit,Del,Show,RoleId ");
            strSql.Append(" FROM RoleList ");
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
            strSql.Append("select count(1) FROM RoleList ");
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
            strSql.Append(")AS Row, T.*  from RoleList T ");
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
            parameters[0].Value = "RoleList";
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

