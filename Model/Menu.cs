/**  版本信息模板在安装目录下，可自行修改。
* Menu.cs
*
* 功 能： N/A
* 类 名： Menu
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/19 22:37:29   N/A    初版
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
	/// Menu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Menu
	{
		public Menu()
		{}
		#region Model
		private int _id;
		private string _menuname;
		private int? _parentid;
		private string _url;
		private int? _create;
		private int? _edite;
		private int? _delete;
		private int? _order;
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
		public string MenuName
		{
			set{ _menuname=value;}
			get{return _menuname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Create
		{
			set{ _create=value;}
			get{return _create;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Edite
		{
			set{ _edite=value;}
			get{return _edite;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Delete
		{
			set{ _delete=value;}
			get{return _delete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Order
		{
			set{ _order=value;}
			get{return _order;}
		}
		#endregion Model

	}
}

