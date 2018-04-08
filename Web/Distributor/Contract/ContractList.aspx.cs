﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;
using System.Data;

public partial class Company_Contract_ContractList : DisPageBase
{
    public string date = null;
    public string page = "1";//默认初始页
    int TitleIndex = 2;
    protected void Page_Load(object sender, EventArgs e)
    {
        ClientScript.RegisterStartupScript(this.GetType(), "msg", "<script>$(\".txt_txtAreaname\").css(\"width\", \"150px\");</script>");
        if (!IsPostBack)
        {
            DataBinds();
        }
    }

    public void DataBinds()
    {
        int pageCount = 0;
        int Counts = 0;
        if (this.txtPageSize.Value.ToString() != "")
        {
            if (this.txtPageSize.Value.Trim().Length >= 5)
            {
                Pager.PageSize = 100;
                this.txtPageSize.Value = "100";
            }
            else
            {
                Pager.PageSize = this.txtPageSize.Value.Trim().ToInt(0);
            }
        }
        DataTable dt = new Hi.BLL.YZT_Contract().getDataTable(Pager.PageSize, Pager.CurrentPageIndex, SearchWhere(), out pageCount, out Counts);
        this.Rpt_Distribute.DataSource = dt;
        this.Rpt_Distribute.DataBind();
        Pager.RecordCount = Counts;
        page = Pager.CurrentPageIndex.ToString();
    }

    public void Pager_PageChanged(object sender, EventArgs e)
    {
        DataBinds();
        page = Pager.CurrentPageIndex.ToString();
    }
    public void btn_SearchClick(object sender, EventArgs e)
    {
        DataBinds();
    }

    public void btn_DelClick(object sender, EventArgs e)
    {
        DataBinds();
        page = Pager.CurrentPageIndex.ToString();
    }

    /// <summary>
    /// 查询条件
    /// </summary>
    /// <returns></returns>
    public string SearchWhere()
    { 
        string where = " and c.disid=" + DisID + "   and isnull(c.dr,0)=0";
       
        if (!string.IsNullOrEmpty(txtComName.Value.Trim()))
        {
            where += " and m.CompName like '%" + txtComName.Value.Trim().Replace("'", "''") + "%' ";
        }
        
        if (!string.IsNullOrEmpty(txtContractNO.Value.Trim()))
        {
            where += " and c.contractNO like '%" + txtContractNO.Value.Trim().Replace("'", "''") + "%'";
        }
       
        if (txtCreateDate.Value.Trim() != "")
        {
            where += " and ForceDate>='" + txtCreateDate.Value.Trim() + "' ";
        }
        if (txtEndCreateDate.Value.Trim() != "")
        {
            where += " and InvalidDate<='" + txtEndCreateDate.Value.Trim() + "' ";
        }
        return where;
    }
}
