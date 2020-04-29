using System;
namespace guanbingking.Model
{
    /// <summary>
    /// Company:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Company
    {
        public Company()
        { }
        #region Model
        private int _id;
        private string _companyname;
        private int? _category;
        private int? _leve;
        private DateTime? _signstart;
        private DateTime? _signend;
        private string _address;
        private string _contact;
        private string _phone;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CompanyName
        {
            set { _companyname = value; }
            get { return _companyname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Category
        {
            set { _category = value; }
            get { return _category; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Leve
        {
            set { _leve = value; }
            get { return _leve; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? SignStart
        {
            set { _signstart = value; }
            get { return _signstart; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? SignEnd
        {
            set { _signend = value; }
            get { return _signend; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Contact
        {
            set { _contact = value; }
            get { return _contact; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        #endregion Model

    }
}

