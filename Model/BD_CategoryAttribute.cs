﻿//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2015 Socansoft.com 版权所有
// 创建描述: SocanCode代码生成器自动创建于 2015/5/18 12:07:25
//
// 功能描述: 
//
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;

namespace Hi.Model
{
    /// <summary>
    /// 实体类 BD_CategoryAttribute
    /// </summary>
    public class BD_CategoryAttribute
    {
        public BD_CategoryAttribute()
        { }
        #region Model
        private int _id;
        private int _compid;
        private int _categoryid;
        private int _attributeid;
        private DateTime _ts;
        private int _dr;
        private int _modifyuser;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CompID
        {
            set { _compid = value; }
            get { return _compid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CategoryID
        {
            set { _categoryid = value; }
            get { return _categoryid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int AttributeID
        {
            set { _attributeid = value; }
            get { return _attributeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime ts
        {
            set { _ts = value; }
            get { return _ts; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int dr
        {
            set { _dr = value; }
            get { return _dr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int modifyuser
        {
            set { _modifyuser = value; }
            get { return _modifyuser; }
        }
        #endregion Model
    }
}
