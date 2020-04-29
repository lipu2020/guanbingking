/**  版本信息模板在安装目录下，可自行修改。
* Invoice.cs
*
* 功 能： N/A
* 类 名： Invoice
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/19 22:40:48   N/A    初版
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
	/// 数据访问类:Invoice
	/// </summary>
	public partial class Invoice
	{
		public Invoice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "Invoice"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Invoice");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(guanbingking.Model.Invoice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Invoice(");
			strSql.Append("Id,Title,TaxpayerID,Address,Tel,AccountName,Bank,BankAccount,CompanyId)");
			strSql.Append(" values (");
			strSql.Append("@Id,@Title,@TaxpayerID,@Address,@Tel,@AccountName,@Bank,@BankAccount,@CompanyId)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.VarChar,1),
					new SqlParameter("@TaxpayerID", SqlDbType.VarChar,1),
					new SqlParameter("@Address", SqlDbType.VarChar,1),
					new SqlParameter("@Tel", SqlDbType.VarChar,1),
					new SqlParameter("@AccountName", SqlDbType.VarChar,1),
					new SqlParameter("@Bank", SqlDbType.VarChar,1),
					new SqlParameter("@BankAccount", SqlDbType.VarChar,1),
					new SqlParameter("@CompanyId", SqlDbType.Int,4)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.TaxpayerID;
			parameters[3].Value = model.Address;
			parameters[4].Value = model.Tel;
			parameters[5].Value = model.AccountName;
			parameters[6].Value = model.Bank;
			parameters[7].Value = model.BankAccount;
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
		public bool Update(guanbingking.Model.Invoice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Invoice set ");
			strSql.Append("Title=@Title,");
			strSql.Append("TaxpayerID=@TaxpayerID,");
			strSql.Append("Address=@Address,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("AccountName=@AccountName,");
			strSql.Append("Bank=@Bank,");
			strSql.Append("BankAccount=@BankAccount,");
			strSql.Append("CompanyId=@CompanyId");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.VarChar,1),
					new SqlParameter("@TaxpayerID", SqlDbType.VarChar,1),
					new SqlParameter("@Address", SqlDbType.VarChar,1),
					new SqlParameter("@Tel", SqlDbType.VarChar,1),
					new SqlParameter("@AccountName", SqlDbType.VarChar,1),
					new SqlParameter("@Bank", SqlDbType.VarChar,1),
					new SqlParameter("@BankAccount", SqlDbType.VarChar,1),
					new SqlParameter("@CompanyId", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.TaxpayerID;
			parameters[2].Value = model.Address;
			parameters[3].Value = model.Tel;
			parameters[4].Value = model.AccountName;
			parameters[5].Value = model.Bank;
			parameters[6].Value = model.BankAccount;
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
			strSql.Append("delete from Invoice ");
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
			strSql.Append("delete from Invoice ");
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
		public guanbingking.Model.Invoice GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Title,TaxpayerID,Address,Tel,AccountName,Bank,BankAccount,CompanyId from Invoice ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			guanbingking.Model.Invoice model=new guanbingking.Model.Invoice();
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
		public guanbingking.Model.Invoice DataRowToModel(DataRow row)
		{
			guanbingking.Model.Invoice model=new guanbingking.Model.Invoice();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["TaxpayerID"]!=null)
				{
					model.TaxpayerID=row["TaxpayerID"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["AccountName"]!=null)
				{
					model.AccountName=row["AccountName"].ToString();
				}
				if(row["Bank"]!=null)
				{
					model.Bank=row["Bank"].ToString();
				}
				if(row["BankAccount"]!=null)
				{
					model.BankAccount=row["BankAccount"].ToString();
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
			strSql.Append("select Id,Title,TaxpayerID,Address,Tel,AccountName,Bank,BankAccount,CompanyId ");
			strSql.Append(" FROM Invoice ");
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
			strSql.Append(" Id,Title,TaxpayerID,Address,Tel,AccountName,Bank,BankAccount,CompanyId ");
			strSql.Append(" FROM Invoice ");
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
			strSql.Append("select count(1) FROM Invoice ");
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
			strSql.Append(")AS Row, T.*  from Invoice T ");
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
			parameters[0].Value = "Invoice";
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

