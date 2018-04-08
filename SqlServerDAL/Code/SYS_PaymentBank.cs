﻿//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2016 Socansoft.com 版权所有
// 创建描述: SocanCode代码生成器自动创建于 2016/4/11 10:25:44
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
    /// 数据访问类 SYS_PaymentBank
    /// </summary>
    public class SYS_PaymentBank
    {
        public SYS_PaymentBank()
        { }

        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hi.Model.SYS_PaymentBank model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [SYS_PaymentBank](");
            strSql.Append("[type],[BankID],[Isno],[AccountName],[bankcode],[bankAddress],[bankPrivate],[bankCity],[Remark],[Start],[CreateUser],[CreateDate],[ts],[dr],[modifyuser],[vdef1],[vdef2],[vdef3],[vdef4],[vdef5],[vdef6],[vdef7],[vdef8],[vdef9])");
            strSql.Append(" values (");
            strSql.Append("@type,@BankID,@Isno,@AccountName,@bankcode,@bankAddress,@bankPrivate,@bankCity,@Remark,@Start,@CreateUser,@CreateDate,@ts,@dr,@modifyuser,@vdef1,@vdef2,@vdef3,@vdef4,@vdef5,@vdef6,@vdef7,@vdef8,@vdef9)");
            strSql.Append(";select @@Identity");
            SqlParameter[] parameters = {
                    new SqlParameter("@type", SqlDbType.Int),
                    new SqlParameter("@BankID", SqlDbType.Int),
                    new SqlParameter("@Isno", SqlDbType.Int),
                    new SqlParameter("@AccountName", SqlDbType.NVarChar,50),
                    new SqlParameter("@bankcode", SqlDbType.NVarChar,50),
                    new SqlParameter("@bankAddress", SqlDbType.NVarChar,50),
                    new SqlParameter("@bankPrivate", SqlDbType.NVarChar,50),
                    new SqlParameter("@bankCity", SqlDbType.NVarChar,50),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,200),
                    new SqlParameter("@Start", SqlDbType.Int),
                    new SqlParameter("@CreateUser", SqlDbType.Int),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@dr", SqlDbType.Int),
                    new SqlParameter("@modifyuser", SqlDbType.Int),
                    new SqlParameter("@vdef1", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef2", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef3", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef4", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef5", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef6", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef7", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef8", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef9", SqlDbType.VarChar,128)
            };
            parameters[0].Value = model.type;
            parameters[1].Value = model.BankID;
            parameters[2].Value = model.Isno;

            if (model.AccountName != null)
                parameters[3].Value = model.AccountName;
            else
                parameters[3].Value = DBNull.Value;


            if (model.bankcode != null)
                parameters[4].Value = model.bankcode;
            else
                parameters[4].Value = DBNull.Value;


            if (model.bankAddress != null)
                parameters[5].Value = model.bankAddress;
            else
                parameters[5].Value = DBNull.Value;


            if (model.bankPrivate != null)
                parameters[6].Value = model.bankPrivate;
            else
                parameters[6].Value = DBNull.Value;


            if (model.bankCity != null)
                parameters[7].Value = model.bankCity;
            else
                parameters[7].Value = DBNull.Value;


            if (model.Remark != null)
                parameters[8].Value = model.Remark;
            else
                parameters[8].Value = DBNull.Value;

            parameters[9].Value = model.Start;
            parameters[10].Value = model.CreateUser;

            if (model.CreateDate != DateTime.MinValue)
                parameters[11].Value = model.CreateDate;
            else
                parameters[11].Value = DBNull.Value;


            if (model.ts != DateTime.MinValue)
                parameters[12].Value = model.ts;
            else
                parameters[12].Value = DBNull.Value;

            parameters[13].Value = model.dr;
            parameters[14].Value = model.modifyuser;

            if (model.vdef1 != null)
                parameters[15].Value = model.vdef1;
            else
                parameters[15].Value = DBNull.Value;


            if (model.vdef2 != null)
                parameters[16].Value = model.vdef2;
            else
                parameters[16].Value = DBNull.Value;


            if (model.vdef3 != null)
                parameters[17].Value = model.vdef3;
            else
                parameters[17].Value = DBNull.Value;


            if (model.vdef4 != null)
                parameters[18].Value = model.vdef4;
            else
                parameters[18].Value = DBNull.Value;


            if (model.vdef5 != null)
                parameters[19].Value = model.vdef5;
            else
                parameters[19].Value = DBNull.Value;


            if (model.vdef6 != null)
                parameters[20].Value = model.vdef6;
            else
                parameters[20].Value = DBNull.Value;


            if (model.vdef7 != null)
                parameters[21].Value = model.vdef7;
            else
                parameters[21].Value = DBNull.Value;


            if (model.vdef8 != null)
                parameters[22].Value = model.vdef8;
            else
                parameters[22].Value = DBNull.Value;


            if (model.vdef9 != null)
                parameters[23].Value = model.vdef9;
            else
                parameters[23].Value = DBNull.Value;

            return SqlHelper.GetInt(SqlHelper.GetSingle(SqlHelper.LocalSqlServer, strSql.ToString(), parameters));
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hi.Model.SYS_PaymentBank model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [SYS_PaymentBank] set ");
            strSql.Append("[type]=@type,");
            strSql.Append("[BankID]=@BankID,");
            strSql.Append("[Isno]=@Isno,");
            strSql.Append("[AccountName]=@AccountName,");
            strSql.Append("[bankcode]=@bankcode,");
            strSql.Append("[bankAddress]=@bankAddress,");
            strSql.Append("[bankPrivate]=@bankPrivate,");
            strSql.Append("[bankCity]=@bankCity,");
            strSql.Append("[Remark]=@Remark,");
            strSql.Append("[Start]=@Start,");
            strSql.Append("[CreateUser]=@CreateUser,");
            strSql.Append("[CreateDate]=@CreateDate,");
            strSql.Append("[ts]=@ts,");
            strSql.Append("[dr]=@dr,");
            strSql.Append("[modifyuser]=@modifyuser,");
            strSql.Append("[vdef1]=@vdef1,");
            strSql.Append("[vdef2]=@vdef2,");
            strSql.Append("[vdef3]=@vdef3,");
            strSql.Append("[vdef4]=@vdef4,");
            strSql.Append("[vdef5]=@vdef5,");
            strSql.Append("[vdef6]=@vdef6,");
            strSql.Append("[vdef7]=@vdef7,");
            strSql.Append("[vdef8]=@vdef8,");
            strSql.Append("[vdef9]=@vdef9");
            strSql.Append(" where [ID]=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int),
                    new SqlParameter("@type", SqlDbType.Int),
                    new SqlParameter("@BankID", SqlDbType.Int),
                    new SqlParameter("@Isno", SqlDbType.Int),
                    new SqlParameter("@AccountName", SqlDbType.NVarChar,50),
                    new SqlParameter("@bankcode", SqlDbType.NVarChar,50),
                    new SqlParameter("@bankAddress", SqlDbType.NVarChar,50),
                    new SqlParameter("@bankPrivate", SqlDbType.NVarChar,50),
                    new SqlParameter("@bankCity", SqlDbType.NVarChar,50),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,200),
                    new SqlParameter("@Start", SqlDbType.Int),
                    new SqlParameter("@CreateUser", SqlDbType.Int),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@ts", SqlDbType.DateTime),
                    new SqlParameter("@dr", SqlDbType.Int),
                    new SqlParameter("@modifyuser", SqlDbType.Int),
                    new SqlParameter("@vdef1", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef2", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef3", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef4", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef5", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef6", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef7", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef8", SqlDbType.VarChar,128),
                    new SqlParameter("@vdef9", SqlDbType.VarChar,128)
            };
            parameters[0].Value = model.ID;
            parameters[1].Value = model.type;
            parameters[2].Value = model.BankID;
            parameters[3].Value = model.Isno;

            if (model.AccountName != null)
                parameters[4].Value = model.AccountName;
            else
                parameters[4].Value = DBNull.Value;


            if (model.bankcode != null)
                parameters[5].Value = model.bankcode;
            else
                parameters[5].Value = DBNull.Value;


            if (model.bankAddress != null)
                parameters[6].Value = model.bankAddress;
            else
                parameters[6].Value = DBNull.Value;


            if (model.bankPrivate != null)
                parameters[7].Value = model.bankPrivate;
            else
                parameters[7].Value = DBNull.Value;


            if (model.bankCity != null)
                parameters[8].Value = model.bankCity;
            else
                parameters[8].Value = DBNull.Value;


            if (model.Remark != null)
                parameters[9].Value = model.Remark;
            else
                parameters[9].Value = DBNull.Value;

            parameters[10].Value = model.Start;
            parameters[11].Value = model.CreateUser;

            if (model.CreateDate != DateTime.MinValue)
                parameters[12].Value = model.CreateDate;
            else
                parameters[12].Value = DBNull.Value;


            if (model.ts != DateTime.MinValue)
                parameters[13].Value = model.ts;
            else
                parameters[13].Value = DBNull.Value;

            parameters[14].Value = model.dr;
            parameters[15].Value = model.modifyuser;

            if (model.vdef1 != null)
                parameters[16].Value = model.vdef1;
            else
                parameters[16].Value = DBNull.Value;


            if (model.vdef2 != null)
                parameters[17].Value = model.vdef2;
            else
                parameters[17].Value = DBNull.Value;


            if (model.vdef3 != null)
                parameters[18].Value = model.vdef3;
            else
                parameters[18].Value = DBNull.Value;


            if (model.vdef4 != null)
                parameters[19].Value = model.vdef4;
            else
                parameters[19].Value = DBNull.Value;


            if (model.vdef5 != null)
                parameters[20].Value = model.vdef5;
            else
                parameters[20].Value = DBNull.Value;


            if (model.vdef6 != null)
                parameters[21].Value = model.vdef6;
            else
                parameters[21].Value = DBNull.Value;


            if (model.vdef7 != null)
                parameters[22].Value = model.vdef7;
            else
                parameters[22].Value = DBNull.Value;


            if (model.vdef8 != null)
                parameters[23].Value = model.vdef8;
            else
                parameters[23].Value = DBNull.Value;


            if (model.vdef9 != null)
                parameters[24].Value = model.vdef9;
            else
                parameters[24].Value = DBNull.Value;


            return SqlHelper.ExecuteSql(SqlHelper.LocalSqlServer, strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete [SYS_PaymentBank] ");
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
            return SqlHelper.GetMaxID(SqlHelper.LocalSqlServer, "[ID]", "[SYS_PaymentBank]");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [SYS_PaymentBank]");
            strSql.Append(" where [ID]= @ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int)};
            parameters[0].Value = ID;
            return SqlHelper.Exists(SqlHelper.LocalSqlServer, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hi.Model.SYS_PaymentBank GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [SYS_PaymentBank] ");
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
        public IList<Hi.Model.SYS_PaymentBank> GetList(string strSql)
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
            StringBuilder strSql = new StringBuilder("select " + strWhat + " from [SYS_PaymentBank]");
            if (!string.IsNullOrEmpty(strWhere))
                strSql.Append(" where " + strWhere);
            if (!string.IsNullOrEmpty(strOrderby))
                strSql.Append(" order by " + strOrderby);
            return SqlHelper.Query(SqlHelper.LocalSqlServer, strSql.ToString());
        }

        /// <summary>
        /// 获取泛型数据列表,在单表查询时使用
        /// </summary>
        public IList<Hi.Model.SYS_PaymentBank> GetList(string strWhat, string strWhere, string strOrderby)
        {
            return GetList(GetDataSet(strWhat, strWhere, strOrderby));
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public IList<Hi.Model.SYS_PaymentBank> GetList(int pageSize, int pageIndex, string fldSort, bool sort, string strCondition, out int pageCount, out int count)
        {
            string strSql;
            DataSet ds = SqlHelper.PageList(SqlHelper.LocalSqlServer, "[SYS_PaymentBank]", null, pageSize, pageIndex, fldSort, sort, strCondition, "ID", false, out pageCount, out count, out strSql);
            return GetList(ds);
        }
        #endregion

        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private Hi.Model.SYS_PaymentBank GetModel(DataRow r)
        {
            Hi.Model.SYS_PaymentBank model = new Hi.Model.SYS_PaymentBank();
            model.ID = SqlHelper.GetInt(r["ID"]);
            model.type = SqlHelper.GetInt(r["type"]);
            model.BankID = SqlHelper.GetInt(r["BankID"]);
            model.Isno = SqlHelper.GetInt(r["Isno"]);
            model.AccountName = SqlHelper.GetString(r["AccountName"]);
            model.bankcode = SqlHelper.GetString(r["bankcode"]);
            model.bankAddress = SqlHelper.GetString(r["bankAddress"]);
            model.bankPrivate = SqlHelper.GetString(r["bankPrivate"]);
            model.bankCity = SqlHelper.GetString(r["bankCity"]);
            model.Remark = SqlHelper.GetString(r["Remark"]);
            model.Start = SqlHelper.GetInt(r["Start"]);
            model.CreateUser = SqlHelper.GetInt(r["CreateUser"]);
            model.CreateDate = SqlHelper.GetDateTime(r["CreateDate"]);
            model.ts = SqlHelper.GetDateTime(r["ts"]);
            model.dr = SqlHelper.GetInt(r["dr"]);
            model.modifyuser = SqlHelper.GetInt(r["modifyuser"]);
            model.vdef1 = SqlHelper.GetString(r["vdef1"]);
            model.vdef2 = SqlHelper.GetString(r["vdef2"]);
            model.vdef3 = SqlHelper.GetString(r["vdef3"]);
            model.vdef4 = SqlHelper.GetString(r["vdef4"]);
            model.vdef5 = SqlHelper.GetString(r["vdef5"]);
            model.vdef6 = SqlHelper.GetString(r["vdef6"]);
            model.vdef7 = SqlHelper.GetString(r["vdef7"]);
            model.vdef8 = SqlHelper.GetString(r["vdef8"]);
            model.vdef9 = SqlHelper.GetString(r["vdef9"]);
            return model;
        }

        /// <summary>
        /// 由数据集得到泛型数据列表
        /// </summary>
        private IList<Hi.Model.SYS_PaymentBank> GetList(DataSet ds)
        {
            return Common.GetListEntity<Hi.Model.SYS_PaymentBank>(ds.Tables[0]);
        }
    }
}
