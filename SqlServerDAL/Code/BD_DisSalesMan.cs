﻿//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2015 Socansoft.com 版权所有
// 创建描述: SocanCode代码生成器自动创建于 2015/9/23 13:44:51
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
    /// 数据访问类 BD_DisSalesMan
    /// </summary>
    public class BD_DisSalesMan
    {
        public BD_DisSalesMan()
        { }

        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hi.Model.BD_DisSalesMan model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [BD_DisSalesMan](");
            strSql.Append("[CompID],[ParentID],[SalesName],[SalesCode],[Phone],[Email],[Remark],[CreateDate],[CreateUserID],[ts],[modifyuser],[SalesType],[IsEnabled])");
            strSql.Append(" values (");
            strSql.Append("@CompID,@ParentID,@SalesName,@SalesCode,@Phone,@Email,@Remark,@CreateDate,@CreateUserID,@ts,@modifyuser,@SalesType,@IsEnabled)");
            strSql.Append(";select @@Identity");
            SqlParameter[] parameters = {
                    new SqlParameter("@CompID", SqlDbType.Int),
                    new SqlParameter("@ParentID", SqlDbType.Int),
                    new SqlParameter("@SalesName", SqlDbType.VarChar,50),
                    new SqlParameter("@SalesCode", SqlDbType.VarChar,50),
                    new SqlParameter("@Phone", SqlDbType.VarChar,50),
                    new SqlParameter("@Email", SqlDbType.VarChar,50),
                    new SqlParameter("@Remark", SqlDbType.VarChar,1000),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@CreateUserID", SqlDbType.Int),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@modifyuser", SqlDbType.Int),
                    new SqlParameter("@SalesType", SqlDbType.Int),
                    new SqlParameter("@IsEnabled", SqlDbType.Int)
            };
            parameters[0].Value = model.CompID;
            parameters[1].Value = model.ParentID;
            parameters[2].Value = model.SalesName;

            if (model.SalesCode != null)
                parameters[3].Value = model.SalesCode;
            else
                parameters[3].Value = DBNull.Value;


            if (model.Phone != null)
                parameters[4].Value = model.Phone;
            else
                parameters[4].Value = DBNull.Value;


            if (model.Email != null)
                parameters[5].Value = model.Email;
            else
                parameters[5].Value = DBNull.Value;


            if (model.Remark != null)
                parameters[6].Value = model.Remark;
            else
                parameters[6].Value = DBNull.Value;

            parameters[7].Value = model.CreateDate;
            parameters[8].Value = model.CreateUserID;
            parameters[9].Value = model.ts;
            parameters[10].Value = model.modifyuser;
            parameters[11].Value = model.SalesType;
            parameters[12].Value = model.IsEnabled;
            return SqlHelper.GetInt(SqlHelper.GetSingle(SqlHelper.LocalSqlServer, strSql.ToString(), parameters));
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hi.Model.BD_DisSalesMan model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [BD_DisSalesMan] set ");
            strSql.Append("[CompID]=@CompID,");
            strSql.Append("[ParentID]=@ParentID,");
            strSql.Append("[SalesType]=@SalesType,");
            strSql.Append("[SalesName]=@SalesName,");
            strSql.Append("[SalesCode]=@SalesCode,");
            strSql.Append("[Phone]=@Phone,");
            strSql.Append("[Email]=@Email,");
            strSql.Append("[Remark]=@Remark,");
            strSql.Append("[IsEnabled]=@IsEnabled,");
            strSql.Append("[CreateDate]=@CreateDate,");
            strSql.Append("[CreateUserID]=@CreateUserID,");
            strSql.Append("[ts]=@ts,");
            strSql.Append("[dr]=@dr,");
            strSql.Append("[modifyuser]=@modifyuser");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int),
                    new SqlParameter("@CompID", SqlDbType.Int),
                    new SqlParameter("@ParentID", SqlDbType.Int),
                    new SqlParameter("@SalesType", SqlDbType.Int),
                    new SqlParameter("@SalesName", SqlDbType.VarChar,50),
                    new SqlParameter("@SalesCode", SqlDbType.VarChar,50),
                    new SqlParameter("@Phone", SqlDbType.VarChar,50),
                    new SqlParameter("@Email", SqlDbType.VarChar,50),
                    new SqlParameter("@Remark", SqlDbType.VarChar,1000),
                    new SqlParameter("@IsEnabled", SqlDbType.Int),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@CreateUserID", SqlDbType.Int),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@dr", SqlDbType.Int),
                    new SqlParameter("@modifyuser", SqlDbType.Int)
            };
            parameters[0].Value = model.ID;
            parameters[1].Value = model.CompID;
            parameters[2].Value = model.ParentID;
            parameters[3].Value = model.SalesType;
            parameters[4].Value = model.SalesName;

            if (model.SalesCode != null)
                parameters[5].Value = model.SalesCode;
            else
                parameters[5].Value = DBNull.Value;


            if (model.Phone != null)
                parameters[6].Value = model.Phone;
            else
                parameters[6].Value = DBNull.Value;


            if (model.Email != null)
                parameters[7].Value = model.Email;
            else
                parameters[7].Value = DBNull.Value;


            if (model.Remark != null)
                parameters[8].Value = model.Remark;
            else
                parameters[8].Value = DBNull.Value;

            parameters[9].Value = model.IsEnabled;
            parameters[10].Value = model.CreateDate;
            parameters[11].Value = model.CreateUserID;
            parameters[12].Value = model.ts;
            parameters[13].Value = model.dr;
            parameters[14].Value = model.modifyuser;

            return SqlHelper.ExecuteSql(SqlHelper.LocalSqlServer, strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete [BD_DisSalesMan] ");
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
            return SqlHelper.GetMaxID(SqlHelper.LocalSqlServer, "[ID]", "[BD_DisSalesMan]");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [BD_DisSalesMan]");
            strSql.Append(" where [ID]= @ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int)};
            parameters[0].Value = ID;
            return SqlHelper.Exists(SqlHelper.LocalSqlServer, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hi.Model.BD_DisSalesMan GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [BD_DisSalesMan] ");
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
        public IList<Hi.Model.BD_DisSalesMan> GetList(string strSql)
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
            StringBuilder strSql = new StringBuilder("select " + strWhat + " from [BD_DisSalesMan]");
            if (!string.IsNullOrEmpty(strWhere))
                strSql.Append(" where " + strWhere);
            if (!string.IsNullOrEmpty(strOrderby))
                strSql.Append(" order by " + strOrderby);
            return SqlHelper.Query(SqlHelper.LocalSqlServer, strSql.ToString());
        }

        /// <summary>
        /// 获取泛型数据列表,在单表查询时使用
        /// </summary>
        public IList<Hi.Model.BD_DisSalesMan> GetList(string strWhat, string strWhere, string strOrderby)
        {
            return GetList(GetDataSet(strWhat, strWhere, strOrderby));
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public IList<Hi.Model.BD_DisSalesMan> GetList(int pageSize, int pageIndex, string fldSort, bool sort, string strCondition, out int pageCount, out int count)
        {
            string strSql;
            DataSet ds = SqlHelper.PageList(SqlHelper.LocalSqlServer, "[BD_DisSalesMan]", null, pageSize, pageIndex, fldSort, sort, strCondition, "ID", false, out pageCount, out count, out strSql);
            return GetList(ds);
        }
        #endregion

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Hi.Model.BD_DisSalesMan GetModel(DataRow r)
        {
            Hi.Model.BD_DisSalesMan model = new Hi.Model.BD_DisSalesMan();
            model.ID = SqlHelper.GetInt(r["ID"]);
            model.CompID = SqlHelper.GetInt(r["CompID"]);
            model.ParentID = SqlHelper.GetInt(r["ParentID"]);
            model.SalesType = SqlHelper.GetInt(r["SalesType"]);
            model.SalesName = SqlHelper.GetString(r["SalesName"]);
            model.SalesCode = SqlHelper.GetString(r["SalesCode"]);
            model.Phone = SqlHelper.GetString(r["Phone"]);
            model.Email = SqlHelper.GetString(r["Email"]);
            model.Remark = SqlHelper.GetString(r["Remark"]);
            model.IsEnabled = SqlHelper.GetInt(r["IsEnabled"]);
            model.CreateDate = SqlHelper.GetDateTime(r["CreateDate"]);
            model.CreateUserID = SqlHelper.GetInt(r["CreateUserID"]);
            model.ts = SqlHelper.GetDateTime(r["ts"]);
            model.dr = SqlHelper.GetInt(r["dr"]);
            model.modifyuser = SqlHelper.GetInt(r["modifyuser"]);
            return model;
        }

        /// <summary>
        /// 由数据集得到泛型数据列表
        /// </summary>
        private IList<Hi.Model.BD_DisSalesMan> GetList(DataSet ds)
        {
            return Common.GetListEntity<Hi.Model.BD_DisSalesMan>(ds.Tables[0]);
        }
    }
}
