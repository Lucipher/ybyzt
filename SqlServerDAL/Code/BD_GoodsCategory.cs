﻿//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2016 Socansoft.com 版权所有
// 创建描述: SocanCode代码生成器自动创建于 2016/4/29 17:45:56
//
// 功能描述: 
//
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
using System.Collections;
using System.Collections.Generic;

namespace Hi.SQLServerDAL
{
    /// <summary>
    /// 数据访问类 BD_GoodsCategory
    /// </summary>
    public partial class BD_GoodsCategory
    {
        public BD_GoodsCategory()
        { }

        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hi.Model.BD_GoodsCategory model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [BD_GoodsCategory](");
            strSql.Append("[CompID],[GoodsTypeID],[CategoryCode],[CategoryName],[ParentId],[SortIndex],[Code],[Deep],[ParCode],[OtherCode],[CreateUserID],[CreateDate],[ts],[modifyuser])");
            strSql.Append(" values (");
            strSql.Append("@CompID,@GoodsTypeID,@CategoryCode,@CategoryName,@ParentId,@SortIndex,@Code,@Deep,@ParCode,@OtherCode,@CreateUserID,@CreateDate,@ts,@modifyuser)");
            strSql.Append(";select @@Identity");
            SqlParameter[] parameters = {
                    new SqlParameter("@CompID", SqlDbType.Int),
                    new SqlParameter("@GoodsTypeID", SqlDbType.Int),
                    new SqlParameter("@CategoryCode", SqlDbType.VarChar,24),
                    new SqlParameter("@CategoryName", SqlDbType.VarChar,64),
                    new SqlParameter("@ParentId", SqlDbType.Int),
                    new SqlParameter("@SortIndex", SqlDbType.VarChar,64),
                    new SqlParameter("@Code", SqlDbType.VarChar,50),
                    new SqlParameter("@Deep", SqlDbType.Int),
                    new SqlParameter("@ParCode", SqlDbType.VarChar,50),
                    new SqlParameter("@OtherCode", SqlDbType.VarChar,50),
                    new SqlParameter("@CreateUserID", SqlDbType.Int),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@modifyuser", SqlDbType.Int)
            };
            parameters[0].Value = model.CompID;
            parameters[1].Value = model.GoodsTypeID;

            if (model.CategoryCode != null)
                parameters[2].Value = model.CategoryCode;
            else
                parameters[2].Value = DBNull.Value;

            parameters[3].Value = model.CategoryName;
            parameters[4].Value = model.ParentId;

            if (model.SortIndex != null)
                parameters[5].Value = model.SortIndex;
            else
                parameters[5].Value = DBNull.Value;


            if (model.Code != null)
                parameters[6].Value = model.Code;
            else
                parameters[6].Value = DBNull.Value;

            parameters[7].Value = model.Deep;

            if (model.ParCode != null)
                parameters[8].Value = model.ParCode;
            else
                parameters[8].Value = DBNull.Value;


            if (model.OtherCode != null)
                parameters[9].Value = model.OtherCode;
            else
                parameters[9].Value = DBNull.Value;

            parameters[10].Value = model.CreateUserID;

            if (model.CreateDate != DateTime.MinValue)
                parameters[11].Value = model.CreateDate;
            else
                parameters[11].Value = DBNull.Value;


            if (model.ts != DateTime.MinValue)
                parameters[12].Value = model.ts;
            else
                parameters[12].Value = DBNull.Value;

            parameters[13].Value = model.modifyuser;
            return SqlHelper.GetInt(SqlHelper.GetSingle(SqlHelper.LocalSqlServer, strSql.ToString(), parameters));
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hi.Model.BD_GoodsCategory model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [BD_GoodsCategory] set ");
            strSql.Append("[CompID]=@CompID,");
            strSql.Append("[GoodsTypeID]=@GoodsTypeID,");
            strSql.Append("[CategoryCode]=@CategoryCode,");
            strSql.Append("[CategoryName]=@CategoryName,");
            strSql.Append("[ParentId]=@ParentId,");
            strSql.Append("[SortIndex]=@SortIndex,");
            strSql.Append("[Code]=@Code,");
            strSql.Append("[Deep]=@Deep,");
            strSql.Append("[ParCode]=@ParCode,");
            strSql.Append("[OtherCode]=@OtherCode,");
            strSql.Append("[IsEnabled]=@IsEnabled,");
            strSql.Append("[CreateUserID]=@CreateUserID,");
            strSql.Append("[CreateDate]=@CreateDate,");
            strSql.Append("[ts]=@ts,");
            strSql.Append("[dr]=@dr,");
            strSql.Append("[modifyuser]=@modifyuser");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int),
                    new SqlParameter("@CompID", SqlDbType.Int),
                    new SqlParameter("@GoodsTypeID", SqlDbType.Int),
                    new SqlParameter("@CategoryCode", SqlDbType.VarChar,24),
                    new SqlParameter("@CategoryName", SqlDbType.VarChar,64),
                    new SqlParameter("@ParentId", SqlDbType.Int),
                    new SqlParameter("@SortIndex", SqlDbType.VarChar,64),
                    new SqlParameter("@Code", SqlDbType.VarChar,50),
                    new SqlParameter("@Deep", SqlDbType.Int),
                    new SqlParameter("@ParCode", SqlDbType.VarChar,50),
                    new SqlParameter("@OtherCode", SqlDbType.VarChar,50),
                    new SqlParameter("@IsEnabled", SqlDbType.Int),
                    new SqlParameter("@CreateUserID", SqlDbType.Int),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@dr", SqlDbType.SmallInt),
                    new SqlParameter("@modifyuser", SqlDbType.Int)
            };
            parameters[0].Value = model.ID;
            parameters[1].Value = model.CompID;
            parameters[2].Value = model.GoodsTypeID;

            if (model.CategoryCode != null)
                parameters[3].Value = model.CategoryCode;
            else
                parameters[3].Value = DBNull.Value;

            parameters[4].Value = model.CategoryName;
            parameters[5].Value = model.ParentId;

            if (model.SortIndex != null)
                parameters[6].Value = model.SortIndex;
            else
                parameters[6].Value = DBNull.Value;


            if (model.Code != null)
                parameters[7].Value = model.Code;
            else
                parameters[7].Value = DBNull.Value;

            parameters[8].Value = model.Deep;

            if (model.ParCode != null)
                parameters[9].Value = model.ParCode;
            else
                parameters[9].Value = DBNull.Value;


            if (model.OtherCode != null)
                parameters[10].Value = model.OtherCode;
            else
                parameters[10].Value = DBNull.Value;

            parameters[11].Value = model.IsEnabled;
            parameters[12].Value = model.CreateUserID;

            if (model.CreateDate != DateTime.MinValue)
                parameters[13].Value = model.CreateDate;
            else
                parameters[13].Value = DBNull.Value;


            if (model.ts != DateTime.MinValue)
                parameters[14].Value = model.ts;
            else
                parameters[14].Value = DBNull.Value;

            parameters[15].Value = model.dr;
            parameters[16].Value = model.modifyuser;

            return SqlHelper.ExecuteSql(SqlHelper.LocalSqlServer, strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete [BD_GoodsCategory] ");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int)};
            parameters[0].Value = ID;

            return SqlHelper.ExecuteSql(SqlHelper.LocalSqlServer, strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return SqlHelper.GetMaxID(SqlHelper.LocalSqlServer, "[ID]", "[BD_GoodsCategory]");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [BD_GoodsCategory]");
            strSql.Append(" where [ID]= @ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int)};
            parameters[0].Value = ID;
            return SqlHelper.Exists(SqlHelper.LocalSqlServer, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hi.Model.BD_GoodsCategory GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [BD_GoodsCategory] ");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int)};
            parameters[0].Value = ID;
            DataSet ds = SqlHelper.Query(SqlHelper.LocalSqlServer, strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow r = ds.Tables[0].Rows[0];
                return GetModel(r);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取数据集,建议只在多表联查时使用
        /// </summary>
        public DataSet GetDataSet(string strSql)
        {
            return SqlHelper.Query(SqlHelper.LocalSqlServer, strSql);
        }

        /// <summary>
        /// 获取泛型数据列表,建议只在多表联查时使用
        /// </summary>
        public IList<Hi.Model.BD_GoodsCategory> GetList(string strSql)
        {
            return GetList(GetDataSet(strSql));
        }

        /// <summary>
        /// 获取数据集,在单表查询时使用
        /// </summary>
        public DataSet GetDataSet(string strWhat, string strWhere, string strOrderby)
        {
            if (string.IsNullOrEmpty(strWhat))
                strWhat = "*";
            StringBuilder strSql = new StringBuilder("select " + strWhat + " from [BD_GoodsCategory]");
            if (!string.IsNullOrEmpty(strWhere))
                strSql.Append(" where " + strWhere);
            if (!string.IsNullOrEmpty(strOrderby))
                strSql.Append(" order by " + strOrderby);
            return SqlHelper.Query(SqlHelper.LocalSqlServer, strSql.ToString());
        }

        /// <summary>
        /// 获取泛型数据列表,在单表查询时使用
        /// </summary>
        public IList<Hi.Model.BD_GoodsCategory> GetList(string strWhat, string strWhere, string strOrderby)
        {
            return GetList(GetDataSet(strWhat, strWhere, strOrderby));
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public IList<Hi.Model.BD_GoodsCategory> GetList(int pageSize, int pageIndex, string fldSort, bool sort, string strCondition, out int pageCount, out int count)
        {
            string strSql;
            DataSet ds = SqlHelper.PageList(SqlHelper.LocalSqlServer, "[BD_GoodsCategory]", null, pageSize, pageIndex, fldSort, sort, strCondition, "ID", false, out pageCount, out count, out strSql);
            return GetList(ds);
        }
        #endregion

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Hi.Model.BD_GoodsCategory GetModel(DataRow r)
        {
            Hi.Model.BD_GoodsCategory model = new Hi.Model.BD_GoodsCategory();
            model.ID = SqlHelper.GetInt(r["ID"]);
            model.CompID = SqlHelper.GetInt(r["CompID"]);
            model.GoodsTypeID = SqlHelper.GetInt(r["GoodsTypeID"]);
            model.CategoryCode = SqlHelper.GetString(r["CategoryCode"]);
            model.CategoryName = SqlHelper.GetString(r["CategoryName"]);
            model.ParentId = SqlHelper.GetInt(r["ParentId"]);
            model.SortIndex = SqlHelper.GetString(r["SortIndex"]);
            model.Code = SqlHelper.GetString(r["Code"]);
            model.Deep = SqlHelper.GetInt(r["Deep"]);
            model.ParCode = SqlHelper.GetString(r["ParCode"]);
            model.OtherCode = SqlHelper.GetString(r["OtherCode"]);
            model.IsEnabled = SqlHelper.GetInt(r["IsEnabled"]);
            model.CreateUserID = SqlHelper.GetInt(r["CreateUserID"]);
            model.CreateDate = SqlHelper.GetDateTime(r["CreateDate"]);
            model.ts = SqlHelper.GetDateTime(r["ts"]);
            model.dr = SqlHelper.GetInt(r["dr"]);
            model.modifyuser = SqlHelper.GetInt(r["modifyuser"]);
            return model;
        }

        /// <summary>
        /// 由数据集得到泛型数据列表
        /// </summary>
        private IList<Hi.Model.BD_GoodsCategory> GetList(DataSet ds)
        {
            return Common.GetListEntity<Hi.Model.BD_GoodsCategory>(ds.Tables[0]);
        }
    }
}