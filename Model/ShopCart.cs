/**  版本信息模板在安装目录下，可自行修改。
* ShopCart.cs
*
* 功 能： N/A
* 类 名： ShopCart
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/19 22:37:32   N/A    初版
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
	/// ShopCart:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ShopCart
	{
		public ShopCart()
		{}
		#region Model
		private int _id;
		private int? _companyid;
		private int? _productid;
		private int? _unit;
		private int? _productcount;
		private string _spec;
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
		public int? CompanyId
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProductId
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProductCount
		{
			set{ _productcount=value;}
			get{return _productcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Spec
		{
			set{ _spec=value;}
			get{return _spec;}
		}
		#endregion Model

	}
}

