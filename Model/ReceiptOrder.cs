/**  版本信息模板在安装目录下，可自行修改。
* ReceiptOrder.cs
*
* 功 能： N/A
* 类 名： ReceiptOrder
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/19 22:37:31   N/A    初版
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
	/// ReceiptOrder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ReceiptOrder
	{
		public ReceiptOrder()
		{}
		#region Model
		private int _id;
		private int? _orderid;
		private string _receiptcode;
		private decimal? _amount;
		private string _payname;
		private string _paybank;
		private string _bankaccount;
		private DateTime? _receiptdate;
		private int? _receipttype;
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
		public int? OrderId
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReceiptCode
		{
			set{ _receiptcode=value;}
			get{return _receiptcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayName
		{
			set{ _payname=value;}
			get{return _payname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayBank
		{
			set{ _paybank=value;}
			get{return _paybank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BankAccount
		{
			set{ _bankaccount=value;}
			get{return _bankaccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ReceiptDate
		{
			set{ _receiptdate=value;}
			get{return _receiptdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReceiptType
		{
			set{ _receipttype=value;}
			get{return _receipttype;}
		}
		#endregion Model

	}
}

