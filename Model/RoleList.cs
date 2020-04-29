using System;
namespace guanbingking.Model
{
    /// <summary>
    /// RoleList:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class RoleList
    {
        public RoleList()
        { }
        #region Model
        private int _id;
        private int? _menuid;
        private int? _add;
        private int? _edit;
        private int? _del;
        private int? _show;
        private int? _roleid;
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
        public int? MenuId
        {
            set { _menuid = value; }
            get { return _menuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Add
        {
            set { _add = value; }
            get { return _add; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Edit
        {
            set { _edit = value; }
            get { return _edit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Del
        {
            set { _del = value; }
            get { return _del; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Show
        {
            set { _show = value; }
            get { return _show; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? RoleId
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        #endregion Model

    }
}

