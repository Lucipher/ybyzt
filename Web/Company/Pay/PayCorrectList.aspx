﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PayCorrectList.aspx.cs" Inherits="Company_Pay_PayCorrectList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<%@ Register Src="~/Company/UserControl/TopControl.ascx" TagPrefix="uc1" TagName="Top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>预收款冲正</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <link href="../css/style.css" rel="stylesheet" type="text/css" />
    <link href="../css/global-2.0.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="../../js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script src="../js/js.js" type="text/javascript"></script>
    <script src="../../js/layer/layer.js" type="text/javascript"></script>
    <script src="../../js/layerCommon.js" type="text/javascript"></script>
    <script src="../../js/CommonJs.js" type="text/javascript"></script>

    <script src="../js/Pay.js" type="text/javascript"></script>
    <script type="text/javascript">
        //回车事件
        $(function () {
            $(document).on("keydown", function (e) {
                if (e.keyCode == 13) {
                    $("#btnSearch").trigger("click");
                }
            })
        })

        $(document).ready(function () {
            //table 行样式
            $('.tablelist tbody tr:odd').addClass('odd');

            $(".tablelink").click(function () {
                //弹出冲正创建层和遮罩层
                $(".tip").fadeIn(200);
                $(".opacity").fadeIn(200);

                //冲正代理商ID
                var id = $(this).attr("tip");
                var name = $(this).attr("Pname");
                //alert(id);
                //alert(name);
                $("#txtPayCorrectDis").val(id);
                $("#txtPayCorrectDisName").val(name);
            });
            $(".tiptop a").click(function () {
                $(".tip").fadeOut(200);
                $(".opacity").fadeOut(200);
                $("input[type='text']").val("");
            });


            $(".cancel").click(function () {
                $(".tip").fadeOut(100);
                $(".opacity").fadeOut(100);
                $("input[type='text']").val("");
            });

            //代理商 搜索
            $("#Search").on("click", function () {
                if ($("#txtPager").val() == "" || $("#txtPager").val() == 0) {
                    layerCommon.msg(" 每页显示数量不能为空", IconOption.错误);
                    return false;
                }
                else {
                    $("#btnSearch").trigger("click");
                }
            });

            //冲正明细查看
            $(".tablelinkQx").click(function () {

                var id = $(this).attr("tip");
                var height = document.documentElement.clientHeight; //计算高度
                var layerOffsetY = (height - 500) / 2; //计算宽度
                var index = layerCommon.openWindow("冲正明细查看", "PayCorrectDetails.aspx?keyId=" + id, 1000, 500, function () { window.location.reload(); });
            });
            //冲正明细查看
            $(".tablelinkQx2").click(function () {

                var id = $(this).attr("tip");
                var height = document.documentElement.clientHeight; //计算高度
                var layerOffsetY = (height - 500) / 2; //计算宽度
                var index = layerCommon.openWindow("冲正明细查看", "PayCorrectDetails.aspx?keyId=" + id, 1000, 500, function () { window.location.reload(); });
            });

            //重置
            $("#li_Reset").click(function () {
                $("#txtDisID").val("");
                $("#hidDisId").val("");
            });
        });
    </script>
    <script type="text/javascript">
        function formCheck() {
            var str = "";
            var txtPayCorrectPrice = $("#txtPayCorrectPrice").val();
            //var txtPayCorrectDate = $("#txtPayCorrectDate").val();
            var txtPayCorrectRemark = $("#txtPayCorrectRemark").val();

            if (txtPayCorrectPrice == "") {
                str += "—请填写入账金额；\r\n";
            }
            //if (txtPayCorrectDate == "") {
            //    str += "—请填写入账时间；\r\n";
            //}
            if (txtPayCorrectRemark == "") {
                str += "-请填写入备注；\r\n";
                if (txtPayCorrectRemark.length > 800) {
                    str += "—备注字数不能大于800个字符；\r\n";
                }
            }
            if (str != "") {
                layerCommon.msg(str, IconOption.错误);
                return false;
            } else {
                return true;
            }

        }
        //只能输入数字验证
        function KeyInt(val) {
            val.value = val.value.replace(/[^\d]/g, '');
        }
        //金额只能输入正数和小数
        function KeyIntPrice(val) {
            val.value = val.value.replace(/[^\d.]/g, '');
        }
    </script>
    <style type="text/css">
        .tip,.tip2{width:400px; height:350px; position:absolute;top:10%; left:30%;background:#fcfdfd; display:none; z-index:999;}
        .opacity{position: absolute;top: 0%;left: 0%;width:100%;height:100%;background-color: #000;opacity: 0.3;z-index:998;}
        .downBox{ width:150px; height:28px; border:1px solid #A9BAC9; margin-left:5px; color:red; padding-left:2px; }
        .tablelinkQx{background:#056cad; border:1px solid #056cad; color:#fff; padding:1px 7px;}
        .tipinfo .lbarea{height:80px; line-height:30px; padding-top:10px; overflow:hidden; }
        .tipinfo .lbarea span{ display:inline-block; text-align:right; width:150px; position:relative;top:-30px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <uc1:top ID="top1" runat="server" ShowID="nav-2" />
        <div class="rightinfo">
        
        <!--当前位置 start-->
        <div class="place">
	        <span>位置：</span>
	        <ul class="placeul">
                <li><a href="../jsc.aspx">我的桌面</a></li><li>></li>
                <li><a href="PayDisList.aspx">企业钱包查询</a></li><li>></li>
                <li><a href="#">预收款冲正</a></li>
	        </ul>
        </div>
        <!--当前位置 end--> 
        <!--代理商搜索 Begin-->
        <input id="hid_Alert" type="hidden" />
        <asp:Button ID="btnSearch" Text="搜索" runat="server" onclick="btnSearch_Click" style=" display:none"  />
        <!--代理商搜索 End-->
            <!--功能按钮 start-->
            <div class="tools">
                <div class="right">
                    <ul class="toolbar right">
                        <li id="Search"><span><img src="../images/t04.png" alt="" /></span>搜索</li>
                    </ul>
                    <ul class="toolbar3">
                        <li>代理商名称:
                        <input name="txtDisID" type="text" id="txtDisID" readonly="readonly" runat="server" class="textBox"/>
                        <input type="hidden" id="hidDisId" runat="server" />
                        </li>
                        <li>
                            每页<input type="text" onkeyup='KeyInt(this)' id="txtPager" name="txtPager" runat="server" class="textBox" style=" width:40px;" />行
                        </li>
                    </ul>
                </div>
            </div>
            <!--功能按钮 end-->

            <!--信息列表 start-->
            <table class="tablelist">
            <asp:Repeater runat="server" ID="rptDis">
            <HeaderTemplate>
                <thead>
                    <tr>
                        <th>代理商名称</th>
                        <th>代理商分类</th>
                        <th>账户余额(元)</th>
                        <th style="text-align:center;">操作</th>
                    </tr>
                </thead>
            </HeaderTemplate>
            <ItemTemplate>
                <tbody>
                    <tr>
                         <td><a href="javascript:void(0)" tip="<%# Eval("ID") %>" class="tablelinkQx2" id="A1" style="text-decoration:underline;"><%# Eval("DisName")%></a></td>
                         <td><%# Common.GetDisTypeNameById(Convert.ToInt32(Eval("DisTypeID").ToString()))%></td>
                         <td><%# Eval("DisAccount")%></td>
                         <td style="width:150px;" align="center">
                            <a href="javascript:void(0)" tip="<%# Eval("ID") %>" Pname="<%# Eval("DisName") %>" class="tablelink">冲正</a>
                            <a href="javascript:void(0)" tip="<%# Eval("ID") %>" class="tablelinkQx" id="clickMx"> 查看</a>
                        </td>
                    </tr>
                </tbody>
                </ItemTemplate>
             </asp:Repeater>
            </table>
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
        <div class="opacity" style="display:none;"></div>
        <!--新增 start-->
        <div class="tip" style="display: none;">
            <div class="tiptop">
                <span>冲正</span><a></a></div>
            <div class="tipinfo">
                <div class="lb">
                    <span><label style=" color:Red; display:inline-block;">*</label>&nbsp;代理商名称：</span>
                    <input name="txtPayCorrectDisName" disabled="disabled" id="txtPayCorrectDisName"
                        type="text" runat="server" class="textBox lblCategoryName" />
                        <input type="hidden" id="txtPayCorrectDis" value="1" runat="server" />
                </div>
                <div class="lb">
                    <span><label style=" color:Red; display:inline-block;">*</label>&nbsp;冲正金额：</span>
                    <input id="txtPayCorrectPrice" onkeyup='KeyIntPrice(this)' type="text" runat="server" class="downBox" />
                </div>
                <!--<div class="lb">
                    <span><label style=" color:Red; display:inline-block;">*</label>&nbsp;冲正时间：</span>
                    <input name="txtArriveDate" runat="server" onclick="WdatePicker()" id="txtPayCorrectDate" readonly="readonly" type="text" class="Wdate" value="" />
                 </div>-->
                <div class="lb">
                    <span><label style=" color:Red; display:inline-block;">*</label>&nbsp;冲正方式：</span>&nbsp;&nbsp;冲正<input type="hidden" id="txtPayCorrectType" value="3" runat="server" />
                </div>
                <div class="lbarea">
                    <span><label style=" color:Red; display:inline-block;">*</label>&nbsp;备注：</span>
                    <textarea id="txtPayCorrectRemark" maxlength="800" rows="3" cols="30" style=" border:1px solid #A9BAC9;" placeholder="订单备注不能大于800个字符" runat="server"></textarea>
                </div>
                <div class="tipbtn">
                    <asp:Button ID="btnAdd" CssClass="orangeBtn" runat="server" Text="确定" OnClientClick="return formCheck()"
                        OnClick="btnAdd_Click" />&nbsp;
                    <input name="" type="button" class="cancel" value="取消" />
                </div>
            </div>
        </div>
        <!--新增 end-->

    </form>
</body>
</html>
