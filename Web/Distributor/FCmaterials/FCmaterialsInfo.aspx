﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FCmaterialsInfo.aspx.cs" Inherits="Company_SysManager_DisEdit" %>

<%@ Register TagName="Head" TagPrefix="Head" Src="~/Distributor/DealerHead.ascx" %>
<%@ Register TagName="Left" TagPrefix="Left" Src="~/Distributor/DealerLeft.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <title>我的首营资料</title>
    
    <link href="../../Company/css/style.css" rel="stylesheet" />
    <link href="../../Company/css/global-2.0.css" rel="stylesheet" type="text/css" />
    <link href="../newOrder/css/global2.5.css" rel="stylesheet" />
    <script src="../../Company/js/jquery-1.11.1.min.js" type="text/javascript"></script>
    <script src="../../js/CommonJs.js" type="text/javascript"></script>
    <script src="../../js/layer/layer.js" type="text/javascript"></script>
    <script src="../../js/layerCommon.js" type="text/javascript"></script>
    <script src="../../js/UploadJs.js" type="text/javascript"></script>
    <script src="../../js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>

    
    <script type="text/javascript"> 
      
        $(document).ready(function () {
            $("#uploadFile").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText", ResultId: "HidFfileName", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });
            $("#uploadFile2").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText2", ResultId: "HidFfileName2", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });
            $("#uploadFile3").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText3", ResultId: "HidFfileName3", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });
            $("#uploadFile4").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText4", ResultId: "HidFfileName4", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });

            $("#uploadFile11").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText11", ResultId: "HidFfileName11", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });
            $("#uploadFile12").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText12", ResultId: "HidFfileName12", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });
            $("#uploadFile5").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText5", ResultId: "HidFfileName5", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });
            $("#uploadFile6").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText6", ResultId: "HidFfileName6", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });
            $("#uploadFile7").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText7", ResultId: "HidFfileName7", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });
            $("#uploadFile8").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText8", ResultId: "HidFfileName8", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });
            $("#uploadFile9").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText9", ResultId: "HidFfileName9", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });
            $("#uploadFile10").AjaxUploadFile({ Src: "UploadFile/", ShowDiv: "UpFileText10", ResultId: "HidFfileName10", AjaxSrc: "../../Controller/Fileup.ashx", maxlength: 5, DownSrc: "../../" });
        });


        function btnUpdate() {
            if(<% =fid%>!=0)
                window.location = "FCmaterialsEdit.aspx?id=<%= fid%>";
            else 
                window.location = "FCmaterialsEdit.aspx";
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <Head:Head ID="Head2" runat="server" />
    <Left:Left ID="Left1" runat="server" ShowID="nav-7" />
    <input type="hidden"  id="hid_Alert"/> 
    <input id="hid_Alerts" type="hidden" />
<div class="rightinfo">
<!--当前位置 start-->
<div class="info">
    <a href="/Distributor/UserIndex.aspx">我的桌面 </a>>
    <a href="javascript:;ss" runat="server" id="atitle">我的首营资料</a>
</div>
<!--当前位置 end-->


        <div id="DisBoot" class="tools">
            <ul class="toolbar left">
                <li id="btnUpdate" runat="server" onclick="btnUpdate()"><span>
                    <img src="../../Company/images/t02.png" /></span><font>修改</font></li>
            </ul>
        </div>


 <div class="c-n-title">首营资料</div>
<ul class="coreInfo">
	
     <li class="lb clear" runat="server" id="li1">
    	<i class="name fl" style="width:140px;">营业执照</i>
    	 <div class="con upload">
         <div style="float:left">
            </div>
         <div style="float:left">
          <div id="UpFileText" runat="server" style="width:240px;">
          </div>
         </div>     
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate"   runat="server"  style="width: 115px;"
                    id="validDate" readonly="readonly" type="text" class="Wdate" value="" /></i>
       </div>
              <asp:Panel runat="server" ID="DFile" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName" type="hidden"  />
     </li>


     <li class="lb clear" runat="server" id="li2">
    	<i class="name fl" style="width:140px;">医疗器械经营许可证</i>
    	 <div class="con upload">
         <div style="float:left">
            </div>
         <div style="float:left">
          <div id="UpFileText2" runat="server" style="width:240px;">
          </div>
         </div> 
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate2" runat="server"  style="width: 115px;"
                    id="validDate2" readonly="readonly"  disabled="disabled" type="text" class="Wdate" value="" /></i>

       </div>
              <asp:Panel runat="server" ID="DFile2" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName2" type="hidden" />
     </li>


     <li class="lb clear" runat="server" id="li3">
    	<i class="name fl" style="width:140px;">医疗器械备案</i>
    	 <div class="con upload">
         <div style="float:left">
            </div>
         <div style="float:left">
          <div id="UpFileText3" runat="server"  style="width:240px;">
          </div>
         </div>     
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate3"   runat="server"  style="width: 115px;"
                    id="validDate3" readonly="readonly" type="text" class="Wdate" value="" /></i>
       </div>
              <asp:Panel runat="server" ID="DFile3" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName3" type="hidden"  />
     </li>



     <li class="lb clear" runat="server" id="li4">
    	<i class="name fl" style="width:140px;">开户许可证</i>
    	 <div class="con upload">
         <div style="float:left">
            </div>
         <div style="float:left">
          <div id="UpFileText4" runat="server" style="width:240px;">
          </div>
         </div>     
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate4"   runat="server"  style="width: 115px;"
                    id="validDate4" readonly="readonly" type="text" class="Wdate" value="" /></i>
       </div>
              <asp:Panel runat="server" ID="DFile4" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName4" type="hidden"  />
     </li>
     
     <li class="lb clear" runat="server" id="li5">
    	<i class="name fl" style="width:140px;">税务登记证</i>
    	 <div class="con upload">
         <div style="float:left">
             </div>
         <div style="float:left">
          <div id="UpFileText11" style="margin-left:10px;width:240px;" runat="server">
          </div>
         </div> 
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate11" runat="server" onclick="WdatePicker()"  style="width: 115px;"
                    id="validDate11" readonly="readonly" type="text" class="Wdate" value="" /></i>
             
       </div>
              <asp:Panel runat="server" ID="DFile11" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName11" type="hidden" class="HidFfileName"/>
     </li>


     <li class="lb clear" runat="server" id="li6">
    	<i class="name fl" style="width:140px;">开户银行许可证</i>
    	 <div class="con upload">
         <div style="float:left">
             </div>
         <div style="float:left">
          <div id="UpFileText12" style="margin-left:10px;width:240px;" runat="server">
          </div>
         </div> 
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate12" runat="server" onclick="WdatePicker()"  style="width: 115px;"
                    id="validDate12" readonly="readonly" type="text" class="Wdate" value="" /></i>
             
       </div>
              <asp:Panel runat="server" ID="DFile12" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName12" type="hidden" class="HidFfileName"/>
     </li>

     <li class="lb clear" runat="server" id="li7">
    	<i class="name fl" style="width:140px;">质量管理体系调查表</i>
    	 <div class="con upload">
         <div style="float:left">
             </div>
         <div style="float:left">
          <div id="UpFileText5" style="margin-left:10px;width:240px;" runat="server">
          </div>
         </div> 
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate5" runat="server" onclick="WdatePicker()"  style="width: 115px;"
                    id="validDate5" readonly="readonly" type="text" class="Wdate" value="" /></i>
             
       </div>
              <asp:Panel runat="server" ID="DFile5" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName5" type="hidden" class="HidFfileName"/>
     </li>

     <li class="lb clear" runat="server" id="li8">
    	<i class="name fl" style="width:140px;">GSP/GMP证书</i>
    	 <div class="con upload">
         <div style="float:left">
             </div>
         <div style="float:left">
          <div id="UpFileText6" style="margin-left:10px;width:240px;" runat="server">
          </div>
         </div> 
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate6" runat="server" onclick="WdatePicker()"  style="width: 115px;"
                    id="validDate6" readonly="readonly" type="text" class="Wdate" value="" /></i>
             
       </div>
              <asp:Panel runat="server" ID="DFile6" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName6" type="hidden" class="HidFfileName"/>
     </li>

     <li class="lb clear" runat="server" id="li9">
    	<i class="name fl" style="width:140px;">开票信息</i>
    	 <div class="con upload">
         <div style="float:left">
             </div>
         <div style="float:left">
          <div id="UpFileText7" style="margin-left:10px;width:240px;" runat="server">
          </div>
         </div> 
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate7" runat="server" onclick="WdatePicker()"  style="width: 115px;"
                    id="validDate7" readonly="readonly" type="text" class="Wdate" value="" /></i>
             
       </div>
              <asp:Panel runat="server" ID="DFile7" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName7" type="hidden" class="HidFfileName"/>
     </li>


     <li class="lb clear" runat="server" id="li10">
    	<i class="name fl" style="width:140px;">企业年报</i>
    	 <div class="con upload">
         <div style="float:left">
             </div>
         <div style="float:left">
          <div id="UpFileText8" style="margin-left:10px;width:240px;" runat="server">
          </div>
         </div> 
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate8" runat="server" onclick="WdatePicker()"  style="width: 115px;"
                    id="validDate8" readonly="readonly" type="text" class="Wdate" value="" /></i>
             
       </div>
              <asp:Panel runat="server" ID="DFile8" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName8" type="hidden" class="HidFfileName"/>
     </li>

     <li class="lb clear" runat="server" id="li11">
    	<i class="name fl" style="width:140px;">银行收付款帐号资料</i>
    	 <div class="con upload">
         <div style="float:left">
             </div>
         <div style="float:left">
          <div id="UpFileText9" style="margin-left:10px;width:240px;" runat="server">
          </div>
         </div> 
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate9" runat="server" onclick="WdatePicker()"  style="width: 115px;"
                    id="validDate9" readonly="readonly" type="text" class="Wdate" value="" /></i>
             
       </div>
              <asp:Panel runat="server" ID="DFile9" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName9" type="hidden" class="HidFfileName"/>
     </li>

     <li class="lb clear" runat="server" id="li12">
    	<i class="name fl" style="width:140px;">购销合同</i>
    	 <div class="con upload">
         <div style="float:left">
             </div>
         <div style="float:left">
          <div id="UpFileText10" style="margin-left:10px;width:240px;" runat="server">
          </div>
         </div> 
             <i class="gclor9" style="margin-left:30px;">有效期<input name="validDate10" runat="server" onclick="WdatePicker()"  style="width: 115px;"
                    id="validDate10" readonly="readonly" type="text" class="Wdate" value="" /></i>
             
       </div>
              <asp:Panel runat="server" ID="DFile10" Style="margin: 5px 5px;">
              </asp:Panel>
            <input runat="server" id="HidFfileName10" type="hidden" class="HidFfileName"/>
     </li>

</ul>
   
   

<div class="c-n-title">开票信息</div>
<ul class="coreInfo">
	<li class="lb fl"><i class="name">发票抬头</i>
     <input type="text" class="box1" placeholder="" runat="server" maxlength="50"  disabled="disabled" id="txtRise"/></li>

    	<li class="lb fl"><i class="name">发票内容</i>
     <input type="text" class="box1" placeholder="" runat="server" maxlength="50"  disabled="disabled" id="txtContent"/></li>
    	<li class="lb fl"><i class="name"><i class="red"></i>开户银行</i>
     
             <select id="txtOBank" runat="server" disabled="disabled"  onchange="Otypechange(this.options[this.selectedIndex].value)"
                               class="box1" style="width:382px;background-color:#e5e0e0;">
                                <option value=""></option>
                                <option value="1405">广州农村商业银行</option>
                                <option value="102">中国工商银行</option>
                                <option value="103">中国农业银行</option>
                                <option value="104">中国银行</option>
                                <option value="105">中国建设银行</option>
                                <option value="301">交通银行</option>
                                <option value="100">邮储银行</option>
                                <option value="303">光大银行</option>
                                <option value="305">民生银行</option>
                                <option value="306">广发银行</option>
                                <option value="302">中信银行</option>
                                <option value="310">浦发银行</option>
                                <option value="309">兴业银行</option>
                                <option value="401">上海银行</option>
                                <option value="403">北京银行</option>
                                <option value="307">平安银行</option>
                                <option value="308">招商银行</option>
                                <option value="20000" style="color: Blue;">更多银行</option>
                            </select>



    	</li>

    
    	<li class="lb fl"><i class="name"><i class="red"></i>开户账户</i>
     <input type="text" class="box1" placeholder="" runat="server" maxlength="50" id="txtOAccount" disabled="disabled" /></li>

    	<li class="lb fl"><i class="name"><i class="red"></i>纳税人登记号</i>
     <input type="text" class="box1" placeholder="" runat="server" maxlength="50" id="txtTRNumber" disabled="disabled" /></li>
	
</ul>

</div>
    </form>
</body>
</html>