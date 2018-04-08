﻿//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2017 Socansoft.com 版权所有
// 创建描述: SocanCode代码生成器自动创建于 2017/12/20 14:21:55
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
    /// 数据访问类 SYS_Hospital
    /// </summary>
    public class SYS_Hospital
    {
        public SYS_Hospital()
        { }

        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hi.Model.SYS_Hospital model)
        {
            model.ID = GetMaxId() + 1;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [SYS_Hospital](");
            strSql.Append("[ID],[HospitalCode],[HospitalName],[HospitalLevel],[Province],[City],[Area],[Address],[IsEnabled],[SVdef1],[SVdef2],[SVdef3],[CreateUser],[CreateDate],[ts],[dr])");
            strSql.Append(" values (");
            strSql.Append("@ID,@HospitalCode,@HospitalName,@HospitalLevel,@Province,@City,@Area,@Address,@IsEnabled,@SVdef1,@SVdef2,@SVdef3,@CreateUser,@CreateDate,@ts,@dr)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int),
                    new SqlParameter("@HospitalCode", SqlDbType.NVarChar,30),
                    new SqlParameter("@HospitalName", SqlDbType.NVarChar,50),
                    new SqlParameter("@HospitalLevel", SqlDbType.NVarChar,30),
                    new SqlParameter("@Province", SqlDbType.NVarChar,30),
                    new SqlParameter("@City", SqlDbType.NVarChar,30),
                    new SqlParameter("@Area", SqlDbType.NVarChar,50),
                    new SqlParameter("@Address", SqlDbType.NVarChar,100),
                    new SqlParameter("@IsEnabled", SqlDbType.Bit),
                    new SqlParameter("@SVdef1", SqlDbType.NVarChar,100),
                    new SqlParameter("@SVdef2", SqlDbType.NVarChar,100),
                    new SqlParameter("@SVdef3", SqlDbType.NVarChar,100),
                    new SqlParameter("@CreateUser", SqlDbType.Char,36),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@dr", SqlDbType.Bit)
            };
            parameters[0].Value = model.ID;

            if (model.HospitalCode != null)
                parameters[1].Value = model.HospitalCode;
            else
                parameters[1].Value = DBNull.Value;

            parameters[2].Value = model.HospitalName;

            if (model.HospitalLevel != null)
                parameters[3].Value = model.HospitalLevel;
            else
                parameters[3].Value = DBNull.Value;


            if (model.Province != null)
                parameters[4].Value = model.Province;
            else
                parameters[4].Value = DBNull.Value;


            if (model.City != null)
                parameters[5].Value = model.City;
            else
                parameters[5].Value = DBNull.Value;


            if (model.Area != null)
                parameters[6].Value = model.Area;
            else
                parameters[6].Value = DBNull.Value;


            if (model.Address != null)
                parameters[7].Value = model.Address;
            else
                parameters[7].Value = DBNull.Value;

            parameters[8].Value = model.IsEnabled;

            if (model.SVdef1 != null)
                parameters[9].Value = model.SVdef1;
            else
                parameters[9].Value = DBNull.Value;


            if (model.SVdef2 != null)
                parameters[10].Value = model.SVdef2;
            else
                parameters[10].Value = DBNull.Value;


            if (model.SVdef3 != null)
                parameters[11].Value = model.SVdef3;
            else
                parameters[11].Value = DBNull.Value;

            parameters[12].Value = model.CreateUser;
            parameters[13].Value = model.CreateDate;
            parameters[14].Value = model.ts;
            parameters[15].Value = model.dr;

            if (SqlHelper.ExecuteSql(SqlHelper.LocalSqlServer, strSql.ToString(), parameters) > 0)
                   return model.ID;
            else
                return 0;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hi.Model.SYS_Hospital model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [SYS_Hospital] set ");
            strSql.Append("[HospitalCode]=@HospitalCode,");
            strSql.Append("[HospitalName]=@HospitalName,");
            strSql.Append("[HospitalLevel]=@HospitalLevel,");
            strSql.Append("[Province]=@Province,");
            strSql.Append("[City]=@City,");
            strSql.Append("[Area]=@Area,");
            strSql.Append("[Address]=@Address,");
            strSql.Append("[IsEnabled]=@IsEnabled,");
            strSql.Append("[SVdef1]=@SVdef1,");
            strSql.Append("[SVdef2]=@SVdef2,");
            strSql.Append("[SVdef3]=@SVdef3,");
            strSql.Append("[CreateUser]=@CreateUser,");
            strSql.Append("[CreateDate]=@CreateDate,");
            strSql.Append("[ts]=@ts,");
            strSql.Append("[dr]=@dr");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int),
                    new SqlParameter("@HospitalCode", SqlDbType.NVarChar,30),
                    new SqlParameter("@HospitalName", SqlDbType.NVarChar,50),
                    new SqlParameter("@HospitalLevel", SqlDbType.NVarChar,30),
                    new SqlParameter("@Province", SqlDbType.NVarChar,30),
                    new SqlParameter("@City", SqlDbType.NVarChar,30),
                    new SqlParameter("@Area", SqlDbType.NVarChar,50),
                    new SqlParameter("@Address", SqlDbType.NVarChar,100),
                    new SqlParameter("@IsEnabled", SqlDbType.Bit),
                    new SqlParameter("@SVdef1", SqlDbType.NVarChar,100),
                    new SqlParameter("@SVdef2", SqlDbType.NVarChar,100),
                    new SqlParameter("@SVdef3", SqlDbType.NVarChar,100),
                    new SqlParameter("@CreateUser", SqlDbType.Char,36),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@dr", SqlDbType.Bit)
            };
            parameters[0].Value = model.ID;

            if (model.HospitalCode != null)
                parameters[1].Value = model.HospitalCode;
            else
                parameters[1].Value = DBNull.Value;

            parameters[2].Value = model.HospitalName;

            if (model.HospitalLevel != null)
                parameters[3].Value = model.HospitalLevel;
            else
                parameters[3].Value = DBNull.Value;


            if (model.Province != null)
                parameters[4].Value = model.Province;
            else
                parameters[4].Value = DBNull.Value;


            if (model.City != null)
                parameters[5].Value = model.City;
            else
                parameters[5].Value = DBNull.Value;


            if (model.Area != null)
                parameters[6].Value = model.Area;
            else
                parameters[6].Value = DBNull.Value;


            if (model.Address != null)
                parameters[7].Value = model.Address;
            else
                parameters[7].Value = DBNull.Value;

            parameters[8].Value = model.IsEnabled;

            if (model.SVdef1 != null)
                parameters[9].Value = model.SVdef1;
            else
                parameters[9].Value = DBNull.Value;


            if (model.SVdef2 != null)
                parameters[10].Value = model.SVdef2;
            else
                parameters[10].Value = DBNull.Value;


            if (model.SVdef3 != null)
                parameters[11].Value = model.SVdef3;
            else
                parameters[11].Value = DBNull.Value;

            parameters[12].Value = model.CreateUser;
            parameters[13].Value = model.CreateDate;
            parameters[14].Value = model.ts;
            parameters[15].Value = model.dr;

            return SqlHelper.ExecuteSql(SqlHelper.LocalSqlServer, strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete [SYS_Hospital] ");
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
            return SqlHelper.GetMaxID(SqlHelper.LocalSqlServer, "[ID]", "[SYS_Hospital]");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [SYS_Hospital]");
            strSql.Append(" where [ID]= @ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int)};
            parameters[0].Value = ID;
            return SqlHelper.Exists(SqlHelper.LocalSqlServer, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hi.Model.SYS_Hospital GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [SYS_Hospital] ");
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
        public IList<Hi.Model.SYS_Hospital> GetList(string strSql)
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
            StringBuilder strSql = new StringBuilder("select " + strWhat + " from [SYS_Hospital]");
            if (!string.IsNullOrEmpty(strWhere))
                strSql.Append(" where " + strWhere);
            if (!string.IsNullOrEmpty(strOrderby))
                strSql.Append(" order by " + strOrderby);
            return SqlHelper.Query(SqlHelper.LocalSqlServer, strSql.ToString());
        }

        /// <summary>
        /// 获取泛型数据列表,在单表查询时使用
        /// </summary>
        public IList<Hi.Model.SYS_Hospital> GetList(string strWhat, string strWhere, string strOrderby)
        {
            return GetList(GetDataSet(strWhat, strWhere, strOrderby));
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public IList<Hi.Model.SYS_Hospital> GetList(int pageSize, int pageIndex, string fldSort, bool sort, string strCondition, out int pageCount, out int count)
        {
            string strSql;
            DataSet ds = SqlHelper.PageList(SqlHelper.LocalSqlServer, "[SYS_Hospital]", null, pageSize, pageIndex, fldSort, sort, strCondition, "ID", false, out pageCount, out count, out strSql);
            return GetList(ds);
        }
        #endregion

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Hi.Model.SYS_Hospital GetModel(DataRow r)
        {
            Hi.Model.SYS_Hospital model = new Hi.Model.SYS_Hospital();
            model.ID = SqlHelper.GetInt(r["ID"]);
            model.HospitalCode = SqlHelper.GetString(r["HospitalCode"]);
            model.HospitalName = SqlHelper.GetString(r["HospitalName"]);
            model.HospitalLevel = SqlHelper.GetString(r["HospitalLevel"]);
            model.Province = SqlHelper.GetString(r["Province"]);
            model.City = SqlHelper.GetString(r["City"]);
            model.Area = SqlHelper.GetString(r["Area"]);
            model.Address = SqlHelper.GetString(r["Address"]);
            model.IsEnabled = SqlHelper.GetBool(r["IsEnabled"]);
            model.SVdef1 = SqlHelper.GetString(r["SVdef1"]);
            model.SVdef2 = SqlHelper.GetString(r["SVdef2"]);
            model.SVdef3 = SqlHelper.GetString(r["SVdef3"]);
            model.CreateUser = SqlHelper.GetString(r["CreateUser"]);
            model.CreateDate = SqlHelper.GetDateTime(r["CreateDate"]);
            model.ts = SqlHelper.GetDateTime(r["ts"]);
            model.dr = SqlHelper.GetBool(r["dr"]);
            return model;
        }

        /// <summary>
        /// 由数据集得到泛型数据列表
        /// </summary>
        private IList<Hi.Model.SYS_Hospital> GetList(DataSet ds)
        {
            List<Hi.Model.SYS_Hospital> l = new List<Hi.Model.SYS_Hospital>();
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                l.Add(GetModel(r));
            }
            return l;
        }
    }
}