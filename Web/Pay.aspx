<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pay.aspx.cs" Inherits="Pay" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Foot.ascx" TagPrefix="uc2" TagName="Foot" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
        <link href="index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <script language="javascript">
    function CheckPost(){
    
    var txtPost=document.getElementById("UserPost").value;
    var txtReg=/^[0-9]{6}$/
    var IsBool=txtReg.test(txtPost);
    if(IsBool){
    
    document.getElementById("spanPost").innerHTML="正确";
    
    }
    else{
    
        document.getElementById("spanPost").innerHTML="错误";
    
    }
    }
    </script>

    <link href="../index.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <uc1:Header id="Header1" runat="server"></uc1:Header>
         <div id="ConItemCol">
             <asp:FormView ID="FormViewOrder" runat="server">
             <ItemTemplate>
               <table width="720" border="1" align="center" cellpadding="1" cellspacing="1" bordercolor="#CCCCCC">
    <tr>
      <td height="25">请选择邮局的方式：
          <asp:DropDownList ID="PostSelect" runat="server" AutoPostBack="false">
          <asp:ListItem Text="平邮" Value="0"></asp:ListItem>
          <asp:ListItem Text="快递" Value="1"></asp:ListItem>
          </asp:DropDownList>
      平邮10块 快递30块 </td>
    </tr>
    <tr>
      <td height="25">用户详细地址：
      <asp:TextBox ID="Adress" style="width: 519px" Text='<%# Eval("UserAdress")%>' runat="server"></asp:TextBox></td>
    </tr>
	<tr>
      <td style="height: 25px">用户邮编：
      <asp:TextBox ID="UserPost" onkeyup="CheckPost()" runat="server"></asp:TextBox><span id="spanPost">不能为空</span></td>
    </tr>
    <tr>
      <td height="25">电话号码：
      <asp:TextBox ID="Phone" Text='<%# Eval("UserPhone")%>' runat="server"></asp:TextBox></td>
    </tr>
    <tr>
      <td height="25">手机号码：
      <asp:TextBox ID="Phonetele" Text='<%# Eval("UserTelephone")%>' runat="server"></asp:TextBox></td>
    </tr>
    <tr>
      <td height="25"></td>
    </tr>
  </table>
  
             </ItemTemplate>
             </asp:FormView>
             <br />
                         <asp:Button ID="ButtonPay" CommandName="Update" runat="server" BackColor="GreenYellow" BorderColor="DarkSeaGreen"
              BorderWidth="1px" Text="提交付款" OnClick="ButtonPay_Click" />
              <br />
              <br />
             <asp:FormView ID="FormViewOrderData" runat="server">
             <ItemTemplate>
                          <table width="520" border="1" align="left" cellpadding="1" cellspacing="1" bordercolor="#CCCCCC">
        <tr>
          <td width="100" align="center" bgcolor="#CCCCCC" style="height: 37px">订单号</td>
          <td width="200" align="center" bgcolor="#CCCCCC" style="height: 37px">商品名称</td>
          <td width="100" align="center" bgcolor="#CCCCCC" style="height: 37px">价格</td>
          <td width="100" align="center" bgcolor="#CCCCCC" style="height: 37px">数量</td>
           <td width="100" align="center" bgcolor="#CCCCCC" style="height: 37px">总价格</td>
          </tr>
        <tr bgcolor="#F6F6F6">
          <td height="30" align="center"><asp:Label ID="LaOrder" runat="server" Text='<%# Eval("OrderId")%>'></asp:Label></td>
          <td height="30" align="center"><%# Eval("ItemName")%></td>
          <td height="30" align="center"><%# Eval("Price")%></td>
          <td height="30" align="center"><%# Eval("ItemTotal")%></td>
          <td height="30" align="center"><%# TotalPrice(decimal.Parse(Eval("Price").ToString()), int.Parse(Eval("ItemTotal").ToString()))%></td>
          </tr>
      </table>
             </ItemTemplate>
             </asp:FormView>
             </div>
             <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
