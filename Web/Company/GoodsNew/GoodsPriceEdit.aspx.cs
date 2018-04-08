﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using DBUtility;

public partial class Company_Goods_GoodsPriceEdit : CompPageBase
{
    public int num = 0;
    public string IdList = string.Empty;
    public string page;
    public int disId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["page"] != null)
            {
                page = Request.QueryString["page"].ToString();
                Pager.CurrentPageIndex = Convert.ToInt32(page);
            }
            this.txtPager.Value = "50";
        }
        object obj = Request["disId"];
        if (obj != null)
        {
            disId = Convert.ToInt32(obj.ToString());
        }

    }

    /// <summary>
    /// 绑定
    /// </summary>
    public void Bind()
    {
        if (this.txtPager.Value.Trim().ToString() != "" && this.txtPager.Value.Trim().ToString() != "0")
        {
            if (this.txtPager.Value.Trim().Length >= 5)
            {
                Pager.PageSize = 100;
                this.txtPager.Value = "100";
            }
            else
            {
                Pager.PageSize = this.txtPager.Value.Trim().ToInt(0);
            }
        }

        string strWhere = string.Format("and a.compid={0} and b.compid={0}", this.CompID);
        if (ViewState["strWhere"] != null)
        {
            strWhere += ViewState["strWhere"].ToString();
        }

        //DataSet l = new Hi.BLL.BD_GoodsInfo().GetGoodsModel(strWhere);

        Pagger pagger = new Pagger(Returnsql(strWhere.ToString()));
        Pager.RecordCount = pagger.getDataCount();
        DataTable dt = pagger.getData(Pager.PageSize, Pager.StartRecordIndex - 1);

        this.rptGoodsInfo.DataSource = dt;
        this.rptGoodsInfo.DataBind();
        // ClientScript.RegisterStartupScript(this.GetType(), "", "<script>$(function(){     $(\"#CB_SelAll\").trigger(\"click\");})</script>");
    }

    public string Returnsql(string where)
    {
        string sql = string.Format(@"select a.Id,a.ValueInfo,a.tinkerPrice,b.GoodsName,b.memo from BD_GoodsInfo as a ,BD_Goods as b
where a.GoodsID=b.ID and b.IsEnabled=1 and ISNULL(a.dr,0)=0 and ISNULL(b.dr,0)=0 and a.IsEnabled=1 and a.isoffline=1 and b.isoffline=1 {0} order by a.CreateDate desc", where);
        return sql;
    }

    /// <summary>
    /// 查询条件
    /// </summary>
    /// <returns></returns>
    private string Where()
    {
        string strWhere = string.Empty;
        //赋值
        string goodsName = this.txtGoodsName.Value.Trim();//商品名称
        string hideID = this.txtCategory.treeId;//类别id
        string idlist = string.Empty;
        if (!Util.IsEmpty(goodsName))
        {
            //List<Hi.Model.BD_Goods> l = new Hi.BLL.BD_Goods().GetList("", "goodsname like '%" + goodsName + "%'", "");
            //if (l.Count > 0)
            //{
            //    foreach (Hi.Model.BD_Goods item in l)
            //    {
            //        idlist += item.ID + ",";
            //    }
            //}
            //if (!Util.IsEmpty(idlist))
            //{
            //    strWhere += string.Format(" and goodsid in( {0})", idlist.Substring(0, idlist.Length - 1));
            //}
            //else
            //{
            //    strWhere += string.Format(" and goodsid =''");
            //}
            strWhere += "and goodsname like '%" + goodsName + "%'";
        }
        string idlist2 = string.Empty;
        if (!Util.IsEmpty(hideID))
        {
            string cateID = Common.CategoryId(Convert.ToInt32(hideID), this.CompID);//商品分类递归
            //List<Hi.Model.BD_Goods> ll = new Hi.BLL.BD_Goods().GetList("", "categoryID in(" + cateID + ") and isnull(dr,0)=0 and isenabled=1", "");
            //if (ll.Count > 0)
            //{
            //    foreach (Hi.Model.BD_Goods item in ll)
            //    {
            //        idlist2 += item.ID + ",";
            //    }
            //}
            //if (!Util.IsEmpty(idlist2))
            //{
            //    strWhere += string.Format(" and goodsid in({0})", idlist2.Substring(0, idlist2.Length - 1));
            //}
            //else
            //{
            //    strWhere += string.Format(" and goodsid =''");
            //}
            strWhere += " and categoryID in(" + cateID + ")";
        }
        return strWhere;
    }

    /// <summary>
    /// 新增
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (KeyID == 1)
        {
            Session["GoodsPrice"] = null;
        }
        try
        {
            List<int> l = new List<int>();
            foreach (RepeaterItem row in this.rptGoodsInfo.Items)
            {
                CheckBox cb = row.FindControl("CB_SelItem") as CheckBox;
                if (cb != null && cb.Checked)
                {
                    HiddenField fld = row.FindControl("HF_Id") as HiddenField;
                    TextBox fld3 = row.FindControl("txtPrice") as TextBox;
                    if (fld != null)
                    {
                        int id = Convert.ToInt32(fld.Value);
                        l.Add(id);
                    }
                }
            }
            if (l.Count == 0)
            {
                JScript.AlertMethod(this, "请勾选商品",JScript.IconOption.错误);
                return;
            }
            List<Hi.Model.BD_GoodsInfo> lll = null;
            if (Session["GoodsPrice"] == null)
            {

                lll = new List<Hi.Model.BD_GoodsInfo>();
            }
            else
            {
                lll = Session["GoodsPrice"] as List<Hi.Model.BD_GoodsInfo>;
            }
            for (int j = 0; j < l.Count; j++)
            {
                Hi.Model.BD_GoodsInfo model2 = new Hi.Model.BD_GoodsInfo();
                model2.CompID = this.CompID;
                // model2.DisID = Convert.ToInt32(list[i]);
                model2.IsEnabled = true;
                model2.CreateUserID = this.UserID;
                model2.CreateDate = DateTime.Now;
                model2.ts = DateTime.Now;
                model2.modifyuser = this.UserID;
                model2.ID = l[j];
                Hi.Model.BD_GoodsInfo model3 = new Hi.BLL.BD_GoodsInfo().GetModel(Convert.ToInt32(l[j].ToString()));
                if (model3 != null)
                {
                    model2.TinkerPrice = model3.SalePrice;
                    model2.SalePrice = model3.SalePrice;
                }
                int xy = 0;
                if (lll.Count != 0)
                {
                    foreach (Hi.Model.BD_GoodsInfo item in lll)
                    {
                        if (item.ID == l[j])
                        {
                            xy++;
                        }
                    }
                }
                if (xy == 0)
                {
                    lll.Add(model2);
                }
            }
            if (lll.Count > 0)
            {
                Session["GoodsPrice"] = lll as List<Hi.Model.BD_GoodsInfo>;
                ClientScript.RegisterStartupScript(this.GetType(), "msg2", "<script>$(function(){window.parent.GbGoods();})</script>");
            }
        }
        catch (Exception ex)
        {

            JScript.AlertMethod(this, "出错了",JScript.IconOption.错误);
            return;
        }
    }

    /// <summary>
    /// 得到属性
    /// </summary>
    /// <returns></returns>
    public string GoodsAttr(string id)
    {
        string str = string.Empty;
        string str2 = string.Empty;
        Hi.Model.BD_GoodsInfo model = new Hi.BLL.BD_GoodsInfo().GetModel(Convert.ToInt32(id));
        if (model != null)
        {
            str = model.ValueInfo;
            if (!Util.IsEmpty(str))
            {
                string[] lsit = { };
                string[] lsit2 = { };
                lsit = str.Replace(';', '；').Split('；');
                for (int i = 0; i < lsit.Length; i++)
                {
                    if (lsit[i] != "")
                    {
                        lsit2 = lsit[i].Split(':');
                        str2 += lsit2[0] + "：" + "<label style='color:#0080b8'>" + lsit2[1] + "</label>" + "；";
                    }
                }
            }
            else
            {
                str2 = Common.GetGoodsMemo(Convert.ToInt32(model.GoodsID));
            }
        }
        return str2;
    }

    /// <summary>
    /// 搜索按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string strWhere = Where();
        ViewState["strWhere"] = strWhere;
        Bind();
        num = 1;
    }

    /// <summary>
    /// 分页
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Pager_PageChanged(object sender, EventArgs e)
    {
        page = Pager.CurrentPageIndex.ToString();
        string strWhere = Where();
        ViewState["strWhere"] = strWhere;
        Bind();
        num = 1;
    }

    /// <summary>
    /// 最新价格
    /// </summary>
    /// <returns></returns>
    public string GoodsTinkerPrice(int id, string disId, string tinkerprice)
    {
        Hi.Model.BD_GoodsInfo model = new Hi.BLL.BD_GoodsInfo().GetModel(id);
        if (model != null)
        {
            tinkerprice = model.TinkerPrice.ToString();
        }
        string price = tinkerprice.ToString();

        List<Hi.Model.BD_GoodsPrice> l = new Hi.BLL.BD_GoodsPrice().GetList("", "isnull(dr,0)=0 and isenabled=1 and goodsinfoid =" + id + " and disId=" + disId + " and compId=" + this.CompID, "id desc");
        if (l.Count > 0)
        {
            foreach (Hi.Model.BD_GoodsPrice item in l)
            {
                price = item.TinkerPrice.ToString();
            }
        }
        return price;
    }
}