﻿/**  版本信息模板在安装目录下，可自行修改。
* OrderProduct.cs
*
* 功 能： N/A
* 类 名： OrderProduct
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/19 22:40:49   N/A    初版
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
	/// 数据访问类:OrderProduct
	/// </summary>
	public partial class OrderProduct
	{
		public OrderProduct()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "OrderProduct"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OrderProduct");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(guanbingking.Model.OrderProduct model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OrderProduct(");
			strSql.Append("Id,ProductName,ProductClass,Unit,Price,Cost,Spec,ProductCount,OrderId)");
			strSql.Append(" values (");
			strSql.Append("@Id,@ProductName,@ProductClass,@Unit,@Price,@Cost,@Spec,@ProductCount,@OrderId)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@ProductName", SqlDbType.VarChar,1),
					new SqlParameter("@ProductClass", SqlDbType.Int,4),
					new SqlParameter("@Unit", SqlDbType.VarChar,1),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@Cost", SqlDbType.Money,8),
					new SqlParameter("@Spec", SqlDbType.VarChar,255),
					new SqlParameter("@ProductCount", SqlDbType.Int,4),
					new SqlParameter("@OrderId", SqlDbType.Int,4)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.ProductName;
			parameters[2].Value = model.ProductClass;
			parameters[3].Value = model.Unit;
			parameters[4].Value = model.Price;
			parameters[5].Value = model.Cost;
			parameters[6].Value = model.Spec;
			parameters[7].Value = model.ProductCount;
			parameters[8].Value = model.OrderId;

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
		public bool Update(guanbingking.Model.OrderProduct model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OrderProduct set ");
			strSql.Append("ProductName=@ProductName,");
			strSql.Append("ProductClass=@ProductClass,");
			strSql.Append("Unit=@Unit,");
			strSql.Append("Price=@Price,");
			strSql.Append("Cost=@Cost,");
			strSql.Append("Spec=@Spec,");
			strSql.Append("ProductCount=@ProductCount,");
			strSql.Append("OrderId=@OrderId");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductName", SqlDbType.VarChar,1),
					new SqlParameter("@ProductClass", SqlDbType.Int,4),
					new SqlParameter("@Unit", SqlDbType.VarChar,1),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@Cost", SqlDbType.Money,8),
					new SqlParameter("@Spec", SqlDbType.VarChar,255),
					new SqlParameter("@ProductCount", SqlDbType.Int,4),
					new SqlParameter("@OrderId", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.ProductName;
			parameters[1].Value = model.ProductClass;
			parameters[2].Value = model.Unit;
			parameters[3].Value = model.Price;
			parameters[4].Value = model.Cost;
			parameters[5].Value = model.Spec;
			parameters[6].Value = model.ProductCount;
			parameters[7].Value = model.OrderId;
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
			strSql.Append("delete from OrderProduct ");
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
			strSql.Append("delete from OrderProduct ");
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
		public guanbingking.Model.OrderProduct GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,ProductName,ProductClass,Unit,Price,Cost,Spec,ProductCount,OrderId from OrderProduct ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			guanbingking.Model.OrderProduct model=new guanbingking.Model.OrderProduct();
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
		public guanbingking.Model.OrderProduct DataRowToModel(DataRow row)
		{
			guanbingking.Model.OrderProduct model=new guanbingking.Model.OrderProduct();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["ProductName"]!=null)
				{
					model.ProductName=row["ProductName"].ToString();
				}
				if(row["ProductClass"]!=null && row["ProductClass"].ToString()!="")
				{
					model.ProductClass=int.Parse(row["ProductClass"].ToString());
				}
				if(row["Unit"]!=null)
				{
					model.Unit=row["Unit"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["Cost"]!=null && row["Cost"].ToString()!="")
				{
					model.Cost=decimal.Parse(row["Cost"].ToString());
				}
				if(row["Spec"]!=null)
				{
					model.Spec=row["Spec"].ToString();
				}
				if(row["ProductCount"]!=null && row["ProductCount"].ToString()!="")
				{
					model.ProductCount=int.Parse(row["ProductCount"].ToString());
				}
				if(row["OrderId"]!=null && row["OrderId"].ToString()!="")
				{
					model.OrderId=int.Parse(row["OrderId"].ToString());
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
			strSql.Append("select Id,ProductName,ProductClass,Unit,Price,Cost,Spec,ProductCount,OrderId ");
			strSql.Append(" FROM OrderProduct ");
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
			strSql.Append(" Id,ProductName,ProductClass,Unit,Price,Cost,Spec,ProductCount,OrderId ");
			strSql.Append(" FROM OrderProduct ");
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
			strSql.Append("select count(1) FROM OrderProduct ");
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
			strSql.Append(")AS Row, T.*  from OrderProduct T ");
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
			parameters[0].Value = "OrderProduct";
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

