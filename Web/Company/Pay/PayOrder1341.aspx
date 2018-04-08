﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PayOrder1341.aspx.cs" Inherits="Company_Pay_PayOrder1341" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<%@ Register Src="~/Company/UserControl/TopControl.ascx" TagPrefix="uc1" TagName="Top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>销售订单结算</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <link href="../css/style.css" rel="stylesheet" type="text/css" />
    <link href="../css/global-2.0.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="../js/js.js" type="text/javascript"></script>
    
    <script src="../../js/layer/layer.js" type="text/javascript"></script>
    <script src="../../js/layerCommon.js" type="text/javascript"></script>
    <script src="../../js/CommonJs.js" type="text/javascript"></script>

    <script src="../js/order.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            
            //订单审核
            $("#Audit").on("click", function () {
                $("#btnAudit").trigger("click");
            });

            //搜索
            $("#Search").on("click", function () {
                $("#btnSearch").trigger("click");
            });

            //重置
            $("#li_Reset").click(function () {
                window.location.href = 'OrderAuditList.aspx';
            });
        });
        //订单审核详细页面
        function goAuditInfo(Id) {
            window.location.href = '../Order/OrderCreateInfo.aspx?PostType=1&KeyID=' + Id;
        }
    </script>

    <style type="text/css">
        .tablelist td a{
            text-decoration:underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <uc1:top ID="top1" runat="server" ShowID="nav-2" />
        <div class="rightinfo">
        <!--当前位置 start-->
        <div class="place">
	        <ul class="placeul">
                <li><a href="../jsc.aspx">我的桌面 </a></li><li>></li>
                <li><a href="#">销售管理</a></li><li>></li>
                <li><a href="#"><span id="title" runat="server">销售订单结算</span></a></li>
	        </ul>
        </div>
        <!--当前位置 end--> 

        <input id="hid_Alert" type="hidden" />
        <asp:Button ID="btnAudit" Text="结算" runat="server" onclick="btnAudit_Click" style=" display:none"  />
        <asp:Button ID="btnSearch" Text="搜索" runat="server" onclick="btnSearch_Click" style=" display:none"  />

            <!--功能按钮 start-->
            <div class="tools">
                <ul class="toolbar left">
                    <li class="click" id="Audit"><span><img src="../images/t08.png" /></span>结算</li>
                </ul>
                <div class="right">
                    <ul class="toolbar right">
                        <li id="Search"><span><img src="../images/t04.png" /></span>搜索</li>
                    </ul>     
                    <ul class="toolbar3">
                        <li>
                            订单编号:<input name="txtReceiptNo" type="text" id="txtReceiptNo" runat="server" class="textBox"/>
                        </li>
                       <%-- <li>
                            订单金额(元):	
                            <input name="txtAmount" id="txtAmount1" runat="server" type="text" class="textBox2"/>
                            -
                            <input name="txtAmount" id="txtAmount2" runat="server" type="text" class="textBox2"/>
                        </li>
                        <li>
                            审核状态:
                            <select name="OState" runat="server" id="ddrOState" class="downBox">
                                <option value="-2">全部</option>
                                <option value="1">未审核</option>
                                <option value="2">已审核</option>
                                <option value="-1">已拒绝</option>
                            </select>
                        </li>--%>
                        <li>
                            每页<input type="text" onkeyup='KeyInt(this)' id="txtPager" name="txtPager" runat="server" class="textBox" style=" width:40px;" />行
                        </li>
                    </ul>  
                </div>
            </div>
            <!--功能按钮 end-->

            <!--信息列表 start-->
            <asp:Repeater runat="server" ID="rptOrder" OnItemCommand="rptOrder_ItemCommand">
                <HeaderTemplate>
                    <table class="tablelist">
                        <thead>
                            <tr>
                                <th width="25"><input type="checkbox" id="CB_SelAll" onclick="SelectAll(this)"/></th>
                                <th>订单编号</th>
                                <th>订单状态</th>
                                <th>支付状态</th>
                                <th>订单总价(元)</th>                               
                                <th>预收款金额(元)</th>
                                <th>结算金额(元)</th>
                                <th>订单类型</th>
                                <th>订单来源</th>
                                <th>下单日期</th>
                                <th>下单人</th>
                                <%--<th width="110" style="text-align:center;">操作</th>--%>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr id='tr_<%# Eval("Id") %>'>
                        <td>
                            <asp:CheckBox ID="CB_SelItem" runat="server"></asp:CheckBox>
                            <asp:HiddenField ID="Hd_Id" runat="server" Value='<%# Eval("Id") %>' />
                        </td>
                        <td><a href="javascript:void(0)" onclick='goAuditInfo(<%# Eval("Id") %>)'><%# Eval("ReceiptNo") %></a></td>
                        <td><%# OrderInfoType.OState(int.Parse(Eval("ID").ToString()))%></td>
                        <td><%# OrderInfoType.PayState(int.Parse(Eval("PayState").ToString()))%></td>
                        <td><%# (Convert.ToDecimal(Eval("AuditAmount")) + Convert.ToDecimal(Eval("OtherAmount"))).ToString("0.00")%></td>
                        <td><%# Convert.ToDecimal(Eval("yfk")).ToString("0.00")%></td>
                         <td><%# Convert.ToDecimal(Eval("PayPrice")).ToString("0.00")%></td>                          
                        <td><%# OrderInfoType.OType(int.Parse(Eval("OType").ToString()))%></td>
                        <td><%# OrderInfoType.AddType(int.Parse(Eval("AddType").ToString()))%></td>
                        <td><%# Convert.ToDateTime(Eval("CreateDate")).ToString("yyyy-MM-dd") %></td>
                        <td><%# new Hi.BLL.SYS_Users().GetModel(Convert.ToInt32(Eval("CreateUserID"))).UserName%></td>
                        <%--<td width="110" align="center">
                            <a href="javascript:void(0)" onclick='goInfo(<%# Eval("Id") %>)' class="tablelink">审核</a>
                        </td>--%>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
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
    </form>
</body>
</html>
