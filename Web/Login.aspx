<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Foot.ascx" TagPrefix="uc2" TagName="Foot" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>会员注册中心  商城网</title>
    <link href="index.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">
    var xmlHttp;
    function createXMLHttpRequest()
    {
        if(window.ActiveXObject)
        {
            xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        else if(window.XMLHttpRequest)
        {
            xmlHttp = new XMLHttpRequest();
        }
    }
function AjaxCheckName(){

createXMLHttpRequest();
var getName=document.getElementById("UserName").value;
var url="CheckNameHandler.ashx?userName="+getName;
xmlHttp.open("POST",url,true);
xmlHttp.onreadystatechange=resultCheckName;
xmlHttp.send(null);
}

function resultCheckName(){

var txtRound=document.getElementById("RoundName");
if(xmlHttp.readystate==4){

if(xmlHttp.status==200){

var txtGetResponse=xmlHttp.responseText;

if(txtGetResponse=="0"){

  txtRound.className="Login_ErroRound";
  txtRound.innerHTML="错误";

}
else if(txtGetResponse=="1"){

  txtRound.className="Login_ErroRound";
  txtRound.innerHTML="已被注册";


}
else{

 txtRound.className="Login_RightRound";
 txtRound.innerHTML="正确";

}
}

}

}
    function CheckName(){
    
    var txtName=document.getElementById("UserName");
    var txtRound=document.getElementById("RoundName");
    var txtReg=/^[\w]{6,10}$/;
    var IsBool=txtReg.test(txtName.value);
    if(IsBool){
    
      txtRound.className="Login_RightRound";
      txtRound.innerHTML="*";

    
    }
    else{
    
        txtRound.className="Login_ErroRound";
        txtRound.innerHTML="错误";
    
    }
    }
    function CheckPassOne(){
    
    var txtPassOne=document.getElementById("UserPassOne");
    var txtRound=document.getElementById("RoundPassOne");
    var txtReg=/^[A-Za-z0-9_]{6,15}$/;
    var IsBool=txtReg.test(txtPassOne.value);
    if(IsBool){
    
      txtRound.className="Login_RightRound";
      txtRound.innerHTML="*";

    
    }
    else{
    
        txtRound.className="Login_ErroRound";
        txtRound.innerHTML="错误";

    
    }
    }
    function CheckPassTwo(){
    
    var txtPassOne=document.getElementById("UserPassOne");
    var txtPassTwo=document.getElementById("UserPassTwo");
    var txtRound=document.getElementById("RoundPassTwo");
    if(txtPassTwo.value==txtPassOne.value){
    
      txtRound.className="Login_RightRound";
      txtRound.innerHTML="*";

    
    }
    else{
    
        txtRound.className="Login_ErroRound";
        txtRound.innerHTML="错误";

    
    }
    }
    function CheckEmail(){
    
    var txtEmail=document.getElementById("UserEmail");
    var txtRound=document.getElementById("RoundEmail");
    var txtReg=/^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/;
    var IsBool=txtReg.test(txtEmail.value);
    if(IsBool){
    
      txtRound.className="Login_RightRound";
      txtRound.innerHTML="*";

    
    }
    else{
    
        txtRound.className="Login_ErroRound";
        txtRound.innerHTML="错误";

    
    }
    }
    function CheckPhone(){
    
    var txtPhone=document.getElementById("UserPhone");
    var txtRound=document.getElementById("RoundPhone");
    var txtReg=/^\d{3}-\d{8}$/;
    var IsBool=txtReg.test(txtPhone.value);
    if(txtPhone.value.length>0)
    {
    if(IsBool){
    
      txtRound.style.display="block";
      txtRound.className="Login_RightRound";
      txtRound.innerHTML="*";

    
    }
    else{
    
        txtRound.style.display="block";
        txtRound.className="Login_ErroRound";
        txtRound.innerHTML="错误";

    
    }
    }
    else{
    
          txtRound.style.display="none";
    
    }
    }
    function CheckPhonetele(){
    
    var txtPhone=document.getElementById("UserPhonetele");
    var txtRound=document.getElementById("RoundPhonetele");
    var txtReg=/^13[\d]{9}$/;
    var IsBool=txtReg.test(txtPhone.value);
    if(IsBool){
    
      txtRound.className="Login_RightRound";
      txtRound.innerHTML="*";

    
    }
    else{
    
        txtRound.className="Login_ErroRound";
        txtRound.innerHTML="错误";

    
    }
    }
    function CheckAdress(){
    
    var txtAdress=document.getElementById("UserAdress");
    var txtRound=document.getElementById("RoundAdress");
    var txtReg=/^[\u4e00-\u9fa5]{5,}[\u4e00-\u9fa5A-Za-z0-9]{5,25}$/;
    var IsBool=txtReg.test(txtAdress.value);
    if(IsBool){
    
      txtRound.className="Login_RightRound";
      txtRound.innerHTML="*";
    
    }
    else{
       
        txtRound.className="Login_ErroRound";
        txtRound.innerHTML="错误";

    }
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <uc1:Header id="Header1" runat="server"></uc1:Header>
            <div id="ConItemCol">
<div class="Login_Reg" id="reg_header"><span class="span">用户注册</span></div>
<div id="LoginCon">
  <table width="840" border="1" cellpadding="1" cellspacing="1" bordercolor="#E1E1E1">
    <tr>
      <td width="100" height="35" align="right">用户名：</td>
      <td width="200"><input type="text" name="textfield" id="UserName" runat="server" onkeyup="CheckName()" /><span class="Login_ErroRound" id="RoundName">*</span></td>
      <td width="536" class="Login_span"><input id="CheckExist" type="button" value="检查该用户是否存在" runat="server" onclick="AjaxCheckName()" />
          用户名只能有6-10位的数字、字母或下划线组成<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
              ControlToValidate="UserName" ErrorMessage="必填" Visible="False"></asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="RegularName" runat="server" ControlToValidate="UserName"
              ErrorMessage="*" ValidationExpression="[\w]{6,10}"></asp:RegularExpressionValidator></td>
    </tr>
	<tr>
      <td width="100" height="35" align="right">密 码：</td>
      <td width="200"><input type="password" name="textfield" id="UserPassOne" onkeyup="CheckPassOne()" runat="server" /><span class="Login_ErroRound" id="RoundPassOne">*</span></td>
      <td width="536" class="Login_span">密码只能有6-15位的数字、字母或下划线组成<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
              ControlToValidate="UserPassOne" ErrorMessage="必填" Visible="False"></asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="*" ControlToValidate="UserPassOne" ValidationExpression="[A-Za-z0-9_]{6,15}"></asp:RegularExpressionValidator></td>
    </tr>
	<tr>
      <td width="100" height="35" align="right">确认密码：</td>
      <td width="200"><input type="password" name="textfield" id="UserPassTwo" runat="server" onkeyup="CheckPassTwo()" /><span class="Login_ErroRound" id="RoundPassTwo">*</span></td>
      <td width="536" class="Login_span">两次输入的密码必须一致<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
              ControlToValidate="UserPassTwo" ErrorMessage="必填" Visible="False"></asp:RequiredFieldValidator>
          <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="UserPassOne"
              ControlToValidate="UserPassTwo" ErrorMessage="两次输入不一致"></asp:CompareValidator></td>
    </tr>
	<tr>
      <td width="100" height="35" align="right">邮 箱：</td>
      <td width="200"><input type="text" name="textfield" id="UserEmail" runat="server" onkeyup="CheckEmail()" /><span class="Login_ErroRound" id="RoundEmail">*</span></td>
      <td width="536" class="Login_span">请输入正确的邮箱<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填"
              Visible="False" ControlToValidate="UserEmail"></asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="*"
              ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="UserEmail"></asp:RegularExpressionValidator></td>
    </tr>
	<tr>
      <td width="100" height="35" align="right">电话号码：</td>
      <td width="200"><input type="text" name="textfield" id="UserPhone" runat="server" onkeyup="CheckPhone()" /><span class="Login_ErroRound" id="RoundPhone" style="display:none">*</span></td>
      <td width="536" class="Login_span">请输入正确号码方便联系，例如(010-89899888)
          <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="*" ValidationExpression="\d{3}-\d{8}" ControlToValidate="UserPhone"></asp:RegularExpressionValidator></td>
    </tr>
	<tr>
      <td width="100" height="35" align="right">手机号码：</td>
      <td width="200"><input type="text" name="textfield" id="UserPhonetele" runat="server" onkeyup="CheckPhonetele()" /><span class="Login_ErroRound" id="RoundPhonetele">*</span></td>
      <td width="536" class="Login_span">请输入正确号码方便联系，例如(13307889898)<asp:RequiredFieldValidator ID="RequiredFieldValidator6"
              runat="server" ControlToValidate="UserPhonetele" ErrorMessage="必填" Visible="False"></asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="*"
              ValidationExpression="13[\d]{9}" ControlToValidate="UserPhonetele"></asp:RegularExpressionValidator></td>
    </tr>
	<tr>
      <td width="100" height="35" align="right">详解地址：</td>
      <td width="200"><textarea name="textarea" class="LoginCon_area" id="UserAdress" runat="server" onkeyup="CheckAdress()"></textarea>
        <span class="Login_ErroRound" id="RoundAdress">*</span></td>
      <td width="536" class="Login_span">
          请输入您正确的收货地址,只能是10-30个字(例如：北京市海定区丁11号求知楼208室)<asp:RequiredFieldValidator ID="RequiredFieldValidator7"
              runat="server" ControlToValidate="UserAdress" ErrorMessage="必填" Visible="False"></asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="*" ValidationExpression="[\u4e00-\u9fa5]{5,}[\u4e00-\u9fa5A-Za-z0-9]{5,25}" ControlToValidate="UserAdress"></asp:RegularExpressionValidator></td>
    </tr>
	
		<tr>
      <td height="50" colspan="3" align="center">
          &nbsp;<asp:Button ID="LoginButton" runat="server" Text="用户注册" style="border-right: #66cc00 1px solid; border-top: #66cc00 1px solid; border-left: #66cc00 1px solid; border-bottom: #66cc00 1px solid; background-color: #ccff33" OnClick="LoginButton_Click" />
          <asp:Button ID="EntryButton" runat="server" Text="用户登录" OnClick="EntryButton_Click" CausesValidation="False" />&nbsp;</td>
      </tr>	
  </table>
</div>
</div>
            <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
