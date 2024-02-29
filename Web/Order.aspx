<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="OrderPage" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Foot.ascx" TagPrefix="uc2" TagName="Foot" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <uc1:Header id="Header1" runat="server"></uc1:Header>
    <div id="ConItemCol">
        <asp:DataList ID="DataListOrder" runat="server" OnDeleteCommand="DataListOrder_DeleteCommand" OnUpdateCommand="DataListOrder_UpdateCommand">
        <HeaderTemplate>
          <table width="920" border="1" align="center" cellpadding="1" cellspacing="1" bordercolor="#CCCCCC">
    <tr>
      <td width="100" height="35" align="center" bgcolor="#CCCCCC">订单号</td>
      <td width="200" align="center" bgcolor="#CCCCCC">商品名称</td>
      <td width="100" align="center" bgcolor="#CCCCCC">价格</td>
      <td width="100" align="center" bgcolor="#CCCCCC">数量</td>
      <td width="100" height="35" align="center" bgcolor="#CCCCCC">总价</td>
      <td width="100" align="center" bgcolor="#CCCCCC">修改购买数量</td>
      <td width="200" align="center" bgcolor="#CCCCCC">操作</td>
    </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr bgcolor="#F6F6F6">
      <td height="30" align="center"><%# Eval("OrderId")%></td>
      <td height="30" align="center"><%# Eval("ItemName")%></td>
      <td height="30" align="center"><%# Eval("Price")%></td>
      <td height="30" align="center">&nbsp;<asp:TextBox ID="OrderCount" runat="server" BackColor="WhiteSmoke" BorderColor="Gray"
              BorderWidth="1px" Width="30px" Text='<%# Eval("ItemTotal")%>'></asp:TextBox></td>
      <td height="30" align="center"><%# BindTotal(decimal.Parse(Eval("Price").ToString()), int.Parse(Eval("ItemTotal").ToString()))%></td>
      <td height="30" align="center">
          <asp:Button ID="UpdateCount" runat="server" BackColor="WhiteSmoke" BorderColor="Silver"
              BorderWidth="1px" Text="修改数量" CommandName="update" /></td>
      <td height="30" align="center">
      
          <asp:Button ID="DeleteOrder" CommandName="delete" runat="server" Text="删除订单" BackColor="Khaki" BorderColor="Gray" BorderWidth="1px" />
          <a href="Pay.aspx?OrderId=<%# Eval("OrderId")%>">去收银台结帐</a></td>
    </tr>
        </ItemTemplate>
        <FooterTemplate>
        </table>
        </FooterTemplate>
        </asp:DataList>

</div>
    <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
