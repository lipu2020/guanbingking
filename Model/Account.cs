/**  版本信息模板在安装目录下，可自行修改。
* Account.cs
*
* 功 能： N/A
* 类 名： Account
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/19 22:37:28   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace guanbingking.Model
{
	/// <summary>
	/// Account:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Account
	{
		public Account()
		{}
		#region Model
		private int _id;
		private string _accountname;
		private string _accountpwd;
		private int? _atype;
		private int? _roleid;
		private int? _companyid;
		private string _accesstoken;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AccountName
		{
			set{ _accountname=value;}
			get{return _accountname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AccountPwd
		{
			set{ _accountpwd=value;}
			get{return _accountpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AType
		{
			set{ _atype=value;}
			get{return _atype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CompanyId
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AccessToken
		{
			set{ _accesstoken=value;}
			get{return _accesstoken;}
		}
		#endregion Model

	}
}

