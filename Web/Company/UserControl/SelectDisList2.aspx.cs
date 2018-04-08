﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Company_UserControl_SelectDisList2 : System.Web.UI.Page
{
    public string page = "1";//默认初始页
    string Compid
    {
        get { return Request["compid"] + ""; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        ClientScript.RegisterStartupScript(this.GetType(), "msg", "<script>$(\".txt_txtTypename,.txt_txtAreaname\").css(\"width\", \"170px\");</script>");
        if (!IsPostBack)
        {
            txtDisAreaBox.CompID = Compid;
            txtDisType.CompID = Compid;
            DataBinds();
        }
    }

    public void DataBinds()
    {
        txtDisAreaBox.CompID = Compid;
        txtDisType.CompID = Compid;
        List<Hi.Model.BD_Distributor> LDis = new Hi.BLL.BD_Distributor().GetList("", SearchWhere(), "Createdate desc");
        this.Rpt_Dis.DataSource = LDis;
        this.Rpt_Dis.DataBind();
        //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>$(function(){     $(\"#CB_SelAll\").trigger(\"click\");})</script>");
    }

    /// <summary>
    /// 查询条件
    /// </summary>
    /// <returns></returns>
    public string SearchWhere()
    {
        string areaId = this.txtDisAreaBox.areaId;//区域
        string type = this.txtDisType.typeId;  //分类
        string where = "auditstate=2 and isnull(IsEnabled,0)=1  and isnull(dr,0)=0 and CompID=" + Compid.ToInt(0) + "";
        if (!string.IsNullOrEmpty(txtDisName.Value.Trim()))
        {
            where += " and ( DisName like '%" + txtDisName.Value.Trim() + "%')";
        }
        if (areaId != "")
        {
            where += "and AreaID=" + areaId;
        }
        if (type != "")
        {
            where += "and DisTypeID=" + type;
        }
        return where;
    }

    protected void btn_SearchClick(object sender, EventArgs e)
    {
        DataBinds();
    }
}