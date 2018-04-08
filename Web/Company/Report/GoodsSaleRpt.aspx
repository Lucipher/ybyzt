﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GoodsSaleRpt.aspx.cs" Inherits="Company_Report_GoodsSaleRpt" %>
<%@ Register TagPrefix="webdiyer" Namespace="Wuqi.Webdiyer" Assembly="AspNetPager, Version=7.2.0.0, Culture=neutral, PublicKeyToken=fb0a0fe055d40fd4" %>
<%@ Register Src="~/UserControl/ButtonToExcel.ascx" TagPrefix="uc1" TagName="ToExcel" %>
<%@ Register Src="~/Company/UserControl/TreeDemo.ascx" TagPrefix="uc1" TagName="TreeDemo" %>
<%@ Register Src="~/Company/UserControl/TopControl.ascx" TagPrefix="uc1" TagName="Top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>商品销售数据</title>

    <link href="../../Company/css/style.css" rel="stylesheet" type="text/css" />
    <link href="../css/global-2.0.css" rel="stylesheet" type="text/css" />
    <script src="../../Company/js/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="../../Company/js/js.js" type="text/javascript"></script>
    <script src="../../js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script src="../../js/layer/layer.js" type="text/javascript"></script>
    <script src="../../js/layerCommon.js" type="text/javascript"></script>
    <script src="../../js/CommonJs.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(function () {
            $(".showDiv .ifrClass").css("width", "155px");
            $(".showDiv").css("width", "150px");
            
            $('iframe').load(function () {
                $('iframe').contents().find('.pullDown').css("width", "150px");
            });
            $(document).on("keydown", function (e) {
                if (e.keyCode == 13) {
                    $("#btnSearch").trigger("click");
                }
            })
        })
        $(function () {
//            $("#txt_product_class").click(function () {
//                ///获取光标位置
//                var x = $("#txt_product_class").offset().left;
//                var y = $("#txt_product_class").offset().top;

//                ChoseProductClass('../Goods/Tree_ProductSort.aspx', x, y);
//            });
        })
        $(document).ready(function () {
            //table 行样式
            $('.tablelist tbody tr:odd').addClass('odd');
            //搜索
            $("#Search").on("click", function () {
                $("#btnSearch").trigger("click");
            });

            ///重置
            $("#li_Reset").click(function () {
                window.location.href = 'GoodsSaleRpt.aspx';
            });
        });

        //转到详细页
        function GotReturnInfo(Id) {
            //            window.location.href = 'Order/OrderReturnInfo.aspx?KeyID=' + Id;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <uc1:top ID="top1" runat="server" ShowID="nav-5" />
    <input type="hidden" id="hid_Alert">
        <asp:Button ID="btnSearch" Text="搜索" runat="server" onclick="btnSearch_Click" style=" display:none"  />
        <div class="rightinfo">
             <!--当前位置 start-->
            <div class="place">
	            <ul class="placeul">
                    <li><a href="../jsc.aspx">我的桌面 </a></li><li>></li>
                    <li><a href="CustSaleRpt.aspx">商品销售数据</a></li>
	            </ul>
            </div>
            <!--当前位置 end--> 
            <!--功能按钮 start-->
            <div class="tools">
                <ul class="toolbar left">
                </ul>
                <div class="right">
                    <ul class="toolbar right">
                        <li id="Search"><span><img src="../../Company/images/t04.png" /></span>搜索</li>
                        <uc1:ToExcel runat="server" ID="ToExcel" contect="TbList" />
                        <li class="liSenior"><span><img src="../images/t07.png" /></span>高级</li>
                        <%--<li id="li_Print"><span><img src="../../Company/images/t10.png" /></span>导出</li>--%>
                    </ul>
                    <ul class="toolbar3">
                        <li>
                            代理商名称:<input name="txtDisName" type="text" id="txtDisName" runat="server" class="textBox"/>
                        </li>
                        <li>
                            商品名称:<input name="txtGoodsName" type="text" id="txtGoodsName" runat="server" class="textBox"/>
                        </li>
                        
                        <li>下单日期：
                            <input name="txtBCreateDate" runat="server" onclick="WdatePicker()" style="width: 115px;" id="txtBCreateDate" readonly="readonly" type="text" class="Wdate" value="" />&nbsp;
                        -&nbsp;
                            <input name="txtECreateDate" runat="server" onclick="WdatePicker()" style="width: 115px;" id="txtECreateDate" readonly="readonly" type="text" class="Wdate" value="" />
                        </li>
                    </ul>
                </div>
            </div>
            <!--功能按钮 end-->
            <div class="hidden">
               <ul style=" width:900px;">
                  <li>
                     每页<input type="text" onkeyup='KeyInt(this)' id="txtPager" name="txtPager" runat="server" class="textBox" style=" width:40px;" />&nbsp;条
                  </li>
                  <li>商品分类:
                        <uc1:TreeDemo runat="server" ID="txtCategory" />&nbsp;
                  </li>
                  <li>
                    订单状态：<select name="OState" runat="server" id="ddrOState" class="downBox">
                        <option value="-2">全部</option>
                        <option value="2">已审核</option>
                        <option value="4">已发货</option>
                        <option value="5">已到货</option>
                    </select>&nbsp;
                </li>
               </ul>
             </div>
            <!--信息列表 start-->
                <asp:Repeater ID="rptOrder" runat="server" >
                    <HeaderTemplate>
                        <table class="tablelist" id="TbList">
                            <thead>
                                <tr>                                    
                                    <%--<th><input type="checkbox" id="CB_SelAll" onclick="SelectAll(this)"/></th>--%>
                                    <th>商品名称</th>
                                    <th class="t3">代理商名称</th>
                                    <th class="t3">商品分类</th>
                                    <th class="t5">商品销售数量</th>
                                    <th class="t5">商品销售金额</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr id='tr_<%# Eval("goodsCode") %>' >
                            <%--<td>
                                <asp:CheckBox ID="CB_SelItem" runat="server"></asp:CheckBox>
                                <asp:HiddenField ID="Hd_Id" runat="server" Value='<%# Eval("Id") %>' />        
                            </td>--%>                           
                            <td><div class="tcle"><%# Eval("goodsName").ToString()%></div></td>
                            <td><div class="tcle"><%# Common.GetDis(Eval("DisID").ToString().ToInt(0),"DisName") %></div></td>
                            <td><div class="tcle"><%# Eval("categoryName").ToString()%></div></td>
                            <td><div class="tc"><%# Eval("goodsNum") == DBNull.Value ? 0 : decimal.Parse(string.Format("{0:N4}", Convert.ToDecimal(Eval("goodsNum")).ToString("#,####" + Digits)))%></div></td>
                            <td><div class="tc"><%# Convert.ToDecimal(Eval("sumAmount") == DBNull.Value ? 0 : Eval("sumAmount")).ToString("N")%></div></td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        <tr id="trTotal" runat="server" visible='<%#bool.Parse((Pager.PageCount == Pager.CurrentPageIndex&&rptOrder.Items.Count!=0).ToString())%>'>
              
                            <td colspan="5">
                             <div class="editmoney">
									
										合 计：<b id="SumTatol" class="size"><%=ta.ToString("N") %></b>
									</div>
                            
                            </td>  
                            
                        </tr>
                            </tbody>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            <!--信息列表 end-->

            <!--列表分页 start--> 
            <div class="pagin">
                <webdiyer:AspNetPager ID="Pager" runat="server" EnableTheming="true" PageIndexBoxType="TextBox"
                     NextPageText=">"  PageSize="12" PrevPageText="<" AlwaysShow="True" UrlPaging="false"
             ShowPageIndexBox="Always" TextAfterPageIndexBox="<span class='pagiPage'>页</span>"
                       TextBeforePageIndexBox="<span class='jump'>跳转到:</span>"
                                    CustomInfoSectionWidth="20%"  CustomInfoStyle="padding:5px 0 0 20px;cursor: default;color: #737373;"  CustomInfoClass="message" ShowCustomInfoSection="Left"
                  CustomInfoHTML="共%PageCount%页，每页%PageSize%条，共%RecordCount%条"
                     CssClass="paginList" CurrentPageButtonClass="paginItem" NumericButtonCount="5"
                    OnPageChanged="Pager_PageChanged" >
                    </webdiyer:AspNetPager>
            </div>
            <!--列表分页 end--> 
        </div>
        <div style=" margin-left:120px;"><span style="padding: 20px 0px 0px 20px;color:red;">备注：销售统计订单为已审核、已发货、已到货状态的订单。</span></div>
    </form>
</body>
</html>
