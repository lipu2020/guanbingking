using System;
namespace guanbingking.Model
{
    /// <summary>
    /// Order:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Order
    {
        public Order()
        { }
        #region Model
        private int _id;
        private string _ordercode;
        private decimal? _amount;
        private int? _companyid;
        private string _contacter;
        private int? _contactmobile;
        private string _address;
        private int? _payway;
        private int? _status;
        private string _paytradeno;
        private string _remark;
        private DateTime? _createdate;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderCode
        {
            set { _ordercode = value; }
            get { return _ordercode; }
        }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal? Amount
        {
            set { _amount = value; }
            get { return _amount; }
        }
        /// <summary>
        /// 商家名称
        /// </summary>
        public int? CompanyId
        {
            set { _companyid = value; }
            get { return _companyid; }
        }
        /// <summary>
        /// 联系人
        /// </summary>
        public string Contacter
        {
            set { _contacter = value; }
            get { return _contacter; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public int? ContactMobile
        {
            set { _contactmobile = value; }
            get { return _contactmobile; }
        }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 支付方式 1 微信 2 支付宝
        /// </summary>
        public int? Payway
        {
            set { _payway = value; }
            get { return _payway; }
        }
        /// <summary>
        /// 订单状态 0未支付 1已支付 -1删除
        /// </summary>
        public int? Status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 第三方支付单号
        /// </summary>
        public string PaytradeNo
        {
            set { _paytradeno = value; }
            get { return _paytradeno; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        #endregion Model

    }
}

