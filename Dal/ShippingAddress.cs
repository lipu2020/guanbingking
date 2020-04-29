/**  版本信息模板在安装目录下，可自行修改。
* ShippingAddress.cs
*
* 功 能： N/A
* 类 名： ShippingAddress
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/19 22:40:51   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace guanbingking.DAL
{
	/// <summary>
	/// 数据访问类:ShippingAddress
	/// </summary>
	public partial class ShippingAddress
	{
		public ShippingAddress()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "ShippingAddress"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ShippingAddress");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(guanbingking.Model.ShippingAddress model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ShippingAddress(");
			strSql.Append("Id,Contact,Tel,Province,City,County,Address,IsDefault,CompanyId)");
			strSql.Append(" values (");
			strSql.Append("@Id,@Contact,@Tel,@Province,@City,@County,@Address,@IsDefault,@CompanyId)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Contact", SqlDbType.VarChar,1),
					new SqlParameter("@Tel", SqlDbType.VarChar,1),
					new SqlParameter("@Province", SqlDbType.Int,4),
					new SqlParameter("@City", SqlDbType.Int,4),
					new SqlParameter("@County", SqlDbType.Int,4),
					new SqlParameter("@Address", SqlDbType.VarChar,255),
					new SqlParameter("@IsDefault", SqlDbType.Int,4),
					new SqlParameter("@CompanyId", SqlDbType.Int,4)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Contact;
			parameters[2].Value = model.Tel;
			parameters[3].Value = model.Province;
			parameters[4].Value = model.City;
			parameters[5].Value = model.County;
			parameters[6].Value = model.Address;
			parameters[7].Value = model.IsDefault;
			parameters[8].Value = model.CompanyId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(guanbingking.Model.ShippingAddress model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ShippingAddress set ");
			strSql.Append("Contact=@Contact,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Province=@Province,");
			strSql.Append("City=@City,");
			strSql.Append("County=@County,");
			strSql.Append("Address=@Address,");
			strSql.Append("IsDefault=@IsDefault,");
			strSql.Append("CompanyId=@CompanyId");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Contact", SqlDbType.VarChar,1),
					new SqlParameter("@Tel", SqlDbType.VarChar,1),
					new SqlParameter("@Province", SqlDbType.Int,4),
					new SqlParameter("@City", SqlDbType.Int,4),
					new SqlParameter("@County", SqlDbType.Int,4),
					new SqlParameter("@Address", SqlDbType.VarChar,255),
					new SqlParameter("@IsDefault", SqlDbType.Int,4),
					new SqlParameter("@CompanyId", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Contact;
			parameters[1].Value = model.Tel;
			parameters[2].Value = model.Province;
			parameters[3].Value = model.City;
			parameters[4].Value = model.County;
			parameters[5].Value = model.Address;
			parameters[6].Value = model.IsDefault;
			parameters[7].Value = model.CompanyId;
			parameters[8].Value = model.Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ShippingAddress ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ShippingAddress ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public guanbingking.Model.ShippingAddress GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Contact,Tel,Province,City,County,Address,IsDefault,CompanyId from ShippingAddress ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			guanbingking.Model.ShippingAddress model=new guanbingking.Model.ShippingAddress();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public guanbingking.Model.ShippingAddress DataRowToModel(DataRow row)
		{
			guanbingking.Model.ShippingAddress model=new guanbingking.Model.ShippingAddress();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Contact"]!=null)
				{
					model.Contact=row["Contact"].ToString();
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["Province"]!=null && row["Province"].ToString()!="")
				{
					model.Province=int.Parse(row["Province"].ToString());
				}
				if(row["City"]!=null && row["City"].ToString()!="")
				{
					model.City=int.Parse(row["City"].ToString());
				}
				if(row["County"]!=null && row["County"].ToString()!="")
				{
					model.County=int.Parse(row["County"].ToString());
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["IsDefault"]!=null && row["IsDefault"].ToString()!="")
				{
					model.IsDefault=int.Parse(row["IsDefault"].ToString());
				}
				if(row["CompanyId"]!=null && row["CompanyId"].ToString()!="")
				{
					model.CompanyId=int.Parse(row["CompanyId"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Contact,Tel,Province,City,County,Address,IsDefault,CompanyId ");
			strSql.Append(" FROM ShippingAddress ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,Contact,Tel,Province,City,County,Address,IsDefault,CompanyId ");
			strSql.Append(" FROM ShippingAddress ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM ShippingAddress ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from ShippingAddress T ");
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
			parameters[0].Value = "ShippingAddress";
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

