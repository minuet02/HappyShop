<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Item.aspx.cs" Inherits="ItemPage" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Foot.ascx" TagPrefix="uc2" TagName="Foot" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title><%=txtTitle %></title>
    <link href="index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <uc1:Header id="Header1" runat="server"></uc1:Header>
            <div id="ConItemCol">
                <asp:FormView ID="FormViewItem" runat="server">
                <ItemTemplate>
                               <table width="940" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr>
      <td width="442" height="502" rowspan="15" valign="top"><img src="<%# Eval("ItemBigImage")%>" width="440" height="500" /></td>
      <td width="18" rowspan="15" valign="top" bgcolor="#f9ffec"></td>
      <td width="480" height="28" valign="middle" class="ItemLine">商品名称：<asp:Label ID="LaItemName" runat="server" Text='<%# Eval("ItemName")%>'></asp:Label></td>
    </tr>
    <tr>
      <td height="28" valign="middle" class="ItemLine">市场价：<%# Eval("AgoraPrice")%></td>
    </tr>
    <tr>
      <td height="28" valign="middle" class="ItemLine">VIP价：<%# Eval("VipPrice")%></td>
    </tr>
    <tr>
      <td height="28" valign="middle" class="ItemLine">会员价：<asp:Label ID="LaPrice" runat="server" Text='<%# Eval("MemberPrice")%>'></asp:Label></td>
    </tr>
    <tr>
      <td height="28" valign="middle" class="ItemLine">地区：<%# Eval("Area")%></td>
    </tr>
    <tr>
      <td height="28" valign="middle" class="ItemLine">新鲜度：<%# Eval("Fresh")%></td>
    </tr>
    <tr>
      <td height="28" valign="middle" class="ItemLine">品牌：<%# Eval("Brand")%></td>
    </tr>
    <tr>
      <td valign="middle" class="ItemLine" style="height: 28px">点击次数：<%# Eval("ClickTime")%></td>
    </tr>
    <tr>
      <td height="28" valign="middle" class="ItemLine">出售总量：<%# Eval("Sale")%></td>
    </tr>
    <tr>
      <td height="28" valign="middle" class="ItemLine">剩余：<%# Eval("Remnant")%></td>
    </tr>
    <tr>
      <td height="28" valign="middle" class="ItemLine">是否为推荐的商品：<%# Eval("Comment")%></td>
    </tr>
    <tr>
      <td height="28" valign="middle" class="ItemLine"></td>
    </tr>
    <tr>
      <td height="56" valign="middle" class="ItemLine">
          <asp:ImageButton ID="Shopping" runat="server" ImageUrl="Image/putcart.gif" OnClick="Shopping_Click" /></td>
    </tr>
    <tr>
      <td height="28" valign="top" class="ItemLine"></td>
    </tr>
  </table>
</ItemTemplate>
                </asp:FormView>
                &nbsp;

 
</div>
            <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
