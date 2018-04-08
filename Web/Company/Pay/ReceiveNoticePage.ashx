﻿<%@ WebHandler Language="C#" Class="ReceiveNoticePage" %>

using System;
using System.Web;
using System.Text;
using System.Collections.Generic;
using DBUtility;
using System.Data.SqlClient;

using CFCA.Payment.Api;
using System.Web.Configuration;

public class ReceiveNoticePage : IHttpHandler
{

    public static readonly string LocalSqlServer = SqlHelper.LocalSqlServer;

    public void ProcessRequest(HttpContext context)
    {
        //Console.WriteLine("---------- Begin [ReceiveNoticePage] process......");

        HttpRequest request = context.Request;
        HttpResponse response = context.Response;

        //1 获得参数message和signature
        String message = request.Form["message"];
        String signature = request.Form["signature"];

        //Console.WriteLine("[message]=[" + message + "]");
        //Console.WriteLine("[signature]=[" + signature + "]");

        //2 生成交易结果对象
        NoticeRequest noticeRequest = new NoticeRequest(message, signature);
        string a = noticeRequest.getTxCode();
        //3 业务处理
        if ("1318".Equals(noticeRequest.getTxCode()))
        {
            Notice1318Request nr = new Notice1318Request(noticeRequest.getDocument());
            string guid = nr.getPaymentNo();
            long Amount = nr.getAmount();
            string strWhere2 = string.Empty;
            if (guid != "")
            {
                strWhere2 += " number = '" + guid + "'";
            }
            Hi.Model.PAY_RegisterLog regM = new Hi.Model.PAY_RegisterLog();
            List<Hi.Model.PAY_RegisterLog> regL = new Hi.BLL.PAY_RegisterLog().GetList("", strWhere2, "");
            if (regL == null || regL.Count <= 0)
            {
                response.Redirect("Error.aspx?msg=未找到对应的支付记录！", false);
                return;
            }
            regM = regL[0];
            string strWhere = string.Empty;
            if (guid != "")
            {
                strWhere += " guid = '" + guid + "'";
            }
            strWhere += " and isnull(dr,0)=0";
            Hi.Model.PAY_Payment payM = new Hi.Model.PAY_Payment();
            List<Hi.Model.PAY_Payment> payL = new Hi.BLL.PAY_Payment().GetList("", strWhere, "");
            if (payL == null || payL.Count <= 0)
            {
                response.Redirect("Error.aspx?msg=未找到对应的支付记录！", false);
                return;
            }
            payM = payL[0];

            payM.PayDate = DateTime.Now;
            payM.ts = DateTime.Now;
            payM.status = nr.getStatus();
            new Hi.BLL.PAY_Payment().Update(payM);
            regM.Start = Convert.ToString(nr.getStatus());
            new Hi.BLL.PAY_RegisterLog().Update(regM);

            if (nr.getStatus() != 20)
            {
                response.Redirect("Error.aspx?msg=支付失败！", false);
                return;
            }
            //！！！支付成功 ！！！

            Hi.Model.Pay_Service serviceOrder = new Hi.BLL.Pay_Service().GetModel(payM.OrderID);
            serviceOrder.PayedPrice = payM.PayPrice;
            new Hi.BLL.Pay_Service().Update(serviceOrder);
            //decimal prepayPrice = 0;
            //int order = 0;
            //int prepay = 0;
            int pay = 0;
            //decimal price = nr.getAmount();
            //string strWhere1 = string.Empty;
            //strWhere1 += " vdef4 = '" + payM.ID + "'";
            //strWhere1 += " and isnull(dr,0)=0";
            //Hi.Model.PAY_PrePayment prepayM = new Hi.Model.PAY_PrePayment();
            //List<Hi.Model.PAY_PrePayment> prepayL = new Hi.BLL.PAY_PrePayment().GetList("", strWhere1, "");
            //if (prepayL != null && prepayL.Count > 0)
            //{
            //    prepayM = prepayL[0];
            //    prepayPrice = prepayM.price * -1;
            //}

            //if (payM.IsAudit == 1)
            //{
            //    response.Redirect("../Distributor/Pay/Error.aspx?msg=该支付记录状态已经修改成功，请不要重复操作！", false);
            //    return;


            //}

            //if (orderModel == null)
            //{
            //    response.Redirect("../Distributor/Pay/Error.aspx?msg=未找到该支付订单！", false);
            //    return;
            //}



            SqlConnection con = new SqlConnection(LocalSqlServer);
            con.Open();
            SqlTransaction sqlTrans = con.BeginTransaction();
            try
            {
                new Hi.BLL.Pay_Service().updatePayState(con, serviceOrder.ID, sqlTrans);
                pay = new Hi.BLL.PAY_Payment().updatePayState(con, payM.ID, sqlTrans);
                Hi.Model.BD_Company comp = new Hi.BLL.BD_Company().GetModel(serviceOrder.CompID);
                if (comp != null)
                {
                    comp.EnabledStartDate = serviceOrder.CreateDate;//服务起始日期
                    comp.EnabledEndDate = serviceOrder.OutData;//服务结束日期
                    new Hi.BLL.BD_Company().Update(comp);
                }
                //try
                //{
                //    //修改免支付次数
                //    Common.UpmzfcsByCompid(orderModel.CompID);
                //}
                //catch { }

                //if (prepayPrice > 0)
                //    prepay = new Hi.BLL.PAY_PrePayment().updatePrepayState(con, prepayM.ID, sqlTrans);
                //else
                //    prepay = 1;
                sqlTrans.Commit();

            }
            catch
            {
                //order = 0;
                //prepay = 0;
                pay = 0;
                sqlTrans.Rollback();
            }
            finally
            {
                con.Close();
            }

            //if (order <= 0 || prepay <= 0 || pay <= 0)
            //{
            //    response.Redirect("../Distributor/Pay/Error.aspx?KeyID="+Common.DesEncrypt(orderModel.ID.ToString(),Common.EncryptKey)+"&msg=支付成功，但修改支付状态失败，请联系系统管理员，勿重复操作！", false);
            //    return;
            //}


            //微信和安卓消息推送
            //new Common().GetWxService("2", orderModel.ID.ToString(), "1");
            //if (orderModel.Otype != 9)
            //{
            //    OrderInfoType.AddIntegral(orderModel.CompID, orderModel.DisID, "1", 1, orderModel.ID, (prepayPrice + (price / 100)), "订单支付", "", orderModel.CreateUserID);
            //}


            //if (orderModel.Otype == (int)Enums.OType.推送账单)
            //    Utils.AddSysBusinessLog(orderModel.CompID, "Order", orderModel.ID.ToString(), "账单支付", "支付：" + (prepayPrice + (price / 100)).ToString("0.00") + "元(网银支付" + (price / 100).ToString("0.00") + (prepayM.ID > 0 ? "+企业钱包支付" + prepayPrice.ToString("0.00") : "") + "【含手续费" + Convert.ToDecimal(payM.vdef5).ToString("0.00") + "元】)", payM.CreateUserID.ToString());
            //else
            //    Utils.AddSysBusinessLog(orderModel.CompID, "Order", orderModel.ID.ToString(), "订单支付", "支付：" + (prepayPrice + (price / 100)).ToString("0.00") + "元(网银支付" + (price / 100).ToString("0.00") + (prepayM.ID > 0 ? "+企业钱包支付" + prepayPrice.ToString("0.00") : "") + "【含手续费" + Convert.ToDecimal(payM.vdef5).ToString("0.00") + "元】)", payM.CreateUserID.ToString());




            //if (orderModel.Otype == (int)Enums.OType.推送账单)
            //{
            //    //response.Clear();
            //    response.Redirect("/Distributor/Pay/PaySuccess.aspx?type=" + Common.DesEncrypt("2", Common.EncryptKey) + "&KeyID=" + Common.DesEncrypt(orderModel.ID.ToString(), Common.EncryptKey) + "&Pid=" + Common.DesEncrypt(payM.ID.ToString(), Common.EncryptKey) + "&PPid=" + Common.DesEncrypt(prepayM.ID.ToString(), Common.EncryptKey) + "&IsRef=Y", false);
            //    return;
            //}
            //else
            //{
            //    //response.Clear();
            //    response.Redirect("/Distributor/Pay/PaySuccess.aspx?type=" + Common.DesEncrypt("1", Common.EncryptKey) + "&KeyID=" + Common.DesEncrypt(orderModel.ID.ToString(), Common.EncryptKey) + "&Pid=" + Common.DesEncrypt(payM.ID.ToString(), Common.EncryptKey) + "&PPid=" + Common.DesEncrypt(prepayM.ID.ToString(), Common.EncryptKey) + "&IsRef=Y", false);
            //    return;
            //}
            if (pay > 0 )
            {
                response.Redirect("PaySuccess.aspx?KeyID=" + Common.DesEncrypt(serviceOrder.ID.ToString(), Common.EncryptKey), true);
            }
            else
            {
                response.Redirect("Error.aspx" , true);
            }
        }

    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}