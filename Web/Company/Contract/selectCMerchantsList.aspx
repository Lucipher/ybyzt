﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="selectCMerchantsList.aspx.cs"
    Inherits="Company_CMerchants_CMerchantsList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <title>招商列表</title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" />
    <link href="../css/global-2.0.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="../js/js.js" type="text/javascript"></script>
    <script src="../../js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script src="../../js/layer/layer.js" type="text/javascript"></script>
    <script src="../../js/layerCommon.js" type="text/javascript"></script>
    <script src="../js/order.js" type="text/javascript"></script>
        <link href="../../Distributor/newOrder/css/global2.5.css?v=2015001311899" rel="stylesheet"
        type="text/css" />
    <script type="text/javascript">

        $(function () {
            $(document).on("keydown", function (e) {
                if (e.keyCode == 13) {
                    $("#btnSearch").trigger("click");
                }
            });

            $("#btnAdd").click(function () {
                window.location.href = 'CMerchantsAdd.aspx';
            });

            //订单生成 搜索
            $("#Search").on("click", function () {
                $("#btnSearch").trigger("click");
            });

            ///重置
            $("#li_Reset").click(function () {
                window.location.href = 'CMerchantsList.aspx';
            });
            $("#btnCancel").click(function () {
                window.parent.closeAll();
            })

            //确定
            $("#btnConfirm").click(function () {
                var str = "";
                $("table tbody tr").each(function (item) {
                    if ($(this).find(".chkbox").is(':checked'))
                        str += $(this).find(".chkbox").val() + ",";
                });
                if (str != "") {
                    str = str.substring(0, str.length - 1);
                    window.parent.GoodsList(str, "CM", "1", "");
                }
                window.parent.closeAll();
            });

        });

    </script>
    <style type="text/css">
        .tablelist td a
        {
            text-decoration: underline;
        }
        td {
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   
    <input id="hid_Alert" type="hidden" />
    <input type="hidden" id="hidCompId" runat="server" />
    <div class="rightinfo" style="width:850px;margin:0 auto;margin-top:10px;">
        <!--功能按钮 start-->
        <div class="tools">
           
            <div class="right">
                <ul class="toolbar right">
                    <li id="Search"><span>
                        <img src="../images/t04.png" /></span>搜索</li>
                    <%--<li id="export"><span><img src="../images/tp3.png" /></span>导出</li>--%>
                   
                </ul>
                <ul class="toolbar3">
                    <li>招商名称:<input name="txtCMName" type="text" id="txtCMName" runat="server" class="textBox" maxlength="50" /></li>
                    <li>商品名称:<input name="txtGoodsName" type="text" id="txtGoodsName" runat="server" class="textBox" maxlength="50" />
                    </li>

                     <li>每页<input type="text" onkeyup="KeyInt(this)" id="txtPager" name="txtPager" runat="server"
                    class="textBox" style="width: 40px;" />&nbsp;条 </li>
                <li>生效日期:<input name="txtCreateDate" runat="server" onclick="var endDate=$dp.$('txtEndCreateDate'); WdatePicker({onpicked:function(){endDate.focus();},maxDate:'#F{$dp.$D(\'txtEndCreateDate\')}'})"
                        style="width: 100px;" id="txtCreateDate" readonly="readonly" type="text" class="Wdate"
                        value="" />&nbsp;-&nbsp;
                        <input name="txtEndCreateDate" runat="server" onclick="WdatePicker({minDate:'#F{$dp.$D(\'txtCreateDate\')}'})"
                            style="width: 100px;" id="txtEndCreateDate" readonly="readonly" type="text" class="Wdate"
                            value="" /></li>

                </ul>
            </div>
        </div>
        <!--功能按钮 end-->
      
        <!--信息列表 start-->
        <asp:Repeater runat="server" ID="rptOrder">
            <HeaderTemplate>
                <table class="tablelist" id="TbList">
                    <thead>
                        <tr>
                            <th class="t8">
                                
                            </th>
                            <th class="t3">
                                招商编码
                            </th>
                            <th class="t3">
                                招商名称
                            </th>
                            <th class="t3">
                                招商日期
                            </th>
                            <th class="t2">
                                商品名称
                            </th>
                            <th class="t1">
                                医院
                            </th>
 
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr id='tr_<%# Eval("Id") %>'>
                   <td style="text-align:center;">
                      <input type="checkbox" id="checkbox-<%#Eval("Id")%>" class="regular-checkbox chkbox" value="<%# Eval("GoodsID") %>">
                       <label for="checkbox-<%#Eval("Id")%>" class="checkboxLabel"></label>
                   </td>
                    <td>
                        <div class="tc">
                            <%# Eval("CMCode")%>
                        </div>
                    </td>
                    <td>
                        <div class="tc">
                           <%# Eval("CMName").ToString()%>    
                        </div>
                    </td>
                    <td>
                        <div class="tc">
                            <%# Eval("ForceDate", "{0:yyyy-MM-dd}")%>
                        </div>
                    </td>
                    <td>
                        <div class="tc">
                           <%# Eval("GoodsName")%>    
                        </div>
                    </td>
                    <td>
                        <div class="tc">
                            <%# Eval("HospitalName") %>
                        </div>
                    </td>
                  
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody> </table>
            </FooterTemplate>
        </asp:Repeater>
        <!--信息列表 end-->
        <asp:Button ID="btnSearch" Text="搜索" runat="server" OnClick="btnSearch_Click" Style="display: none" />
        <%--<asp:Button ID="btnVolumeDel" Text="批量删除" runat="server" OnClick="btnVolumeDel_Click"
            Style="display: none" />--%>
        <!--列表分页 start-->
        <div class="pagin">
            <webdiyer:AspNetPager ID="Pager" runat="server" EnableTheming="true" PageIndexBoxType="TextBox"
                NextPageText=">" PageSize="6" PrevPageText="<" AlwaysShow="True" UrlPaging="false"
                ShowPageIndexBox="Always" TextAfterPageIndexBox="<span class='pagiPage'>页</span>"
                TextBeforePageIndexBox="<span class='jump'>跳转到:</span>" CustomInfoSectionWidth="20%"
                CustomInfoStyle="padding:5px 0 0 20px;cursor: default;color: #737373;" CustomInfoClass="message"
                ShowCustomInfoSection="Left" CustomInfoHTML="共%PageCount%页，每页%PageSize%条，共%RecordCount%条"
                CssClass="paginList" CurrentPageButtonClass="paginItem" NumericButtonCount="5"
                OnPageChanged="Pager_PageChanged">
            </webdiyer:AspNetPager>
        </div>
        <!--列表分页 end-->
         <!--商品 end-->
        <div class="po-btn">
            <a href="javascript:void(0);" class="gray-btn" id="btnCancel">取消</a> <a href="javascript:void(0);"
                class="btn-area" id="btnConfirm">确定</a>
        </div>
    </div>
    </form>
</body>
</html>
