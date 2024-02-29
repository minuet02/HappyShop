<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserCenter.aspx.cs" Inherits="UserCenterPage" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Foot.ascx" TagPrefix="uc2" TagName="Foot" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
            <link href="index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
                    <uc1:Header id="Header1" runat="server"></uc1:Header>
                <div id="ConItemCol">
                  <div class="UserInfo" id="UserInfo">
                      <asp:FormView ID="InfoRepeader" runat="server">                
  
                  <HeaderTemplate>
                    <table width="220" border="0" cellpadding="0" cellspacing="0">
                      <tr>
                        <td height="30" bgcolor="#CCFF00">用户资料</td>
                      </tr>
                  </HeaderTemplate>
<ItemTemplate>
                      <tr>
                        <td height="25">用户名称：<%# Eval("UserName") %></td>
                      </tr>
                      <tr>
                        <td height="25">邮箱：<%# Eval("UserEmail") %></td>
                      </tr>
                      <tr>
                        <td height="25">电话号码：<%# Eval("UserPhone") %></td>
                      </tr>
                      <tr>
                        <td height="25">手机号码：<%# Eval("UserTelephone")%></td>
                      </tr>
                      <tr>
                        <td height="50" valign="top">详细地址：<%# Eval("UserAdress")%></td>
                      </tr>
                      </ItemTemplate>
                      <FooterTemplate>
                    </table>
                    </FooterTemplate>
                      </asp:FormView>
                  </div>
                  <div class="UserOrder" id="UserOrder">
                    <table width="100%" height="30" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFCC00">
                      <tr>
                        <td>用户订单列表</td>
                      </tr>
                    </table>
                    <asp:Repeater ID="OrderRepeater" runat="server">
                    <HeaderTemplate>
                    <table width="100%" height="25" border="0" cellpadding="0" cellspacing="0" class="UserOrderTable">
                      <tr>
                        <td width="110" align="center" bgcolor="#F0E9CB" style="height: 25px">订单号</td>
                        <td width="200" align="center" bgcolor="#F0E9CB" style="height: 25px">商品名称</td>
                        <td width="40" align="center" bgcolor="#F0E9CB" style="height: 25px">价格</td>
                        <td width="40" align="center" bgcolor="#F0E9CB" style="height: 25px">数量</td>
                        <td width="60" align="center" bgcolor="#F0E9CB" style="height: 25px">付款状态</td>
                        <td width="60" align="center" bgcolor="#F0E9CB" style="height: 25px">收货状态</td>
                        <td width="60" align="center" bgcolor="#F0E9CB" style="height: 25px">评论状态</td>
                        <td width="125" align="center" bgcolor="#F0E9CB" style="height: 25px"> 用户操作</td>
                      </tr>
                      </HeaderTemplate>
                      <ItemTemplate>
                      <tr bgcolor="#FEFEFC">
                        <td height="25" align="center"><%# Eval("OrderId")%></td>
                        <td height="25" align="center"><%# Eval("ItemName")%></td>
                        <td height="25" align="center"><%# Eval("Price")%></td>
                    <td height="25" align="center"><%# Eval("ItemTotal")%></td>
                        <td height="25" align="center"><%# IsPay(Convert.ToBoolean(Eval("Pay")))%></td>
                        <td height="25" align="center"><%# IsCheckOrder(Convert.ToBoolean(Eval("CheckOrder")))%></td>
                        <td height="25" align="center"><%# IsFeedBack(Convert.ToInt32(Eval("FeedBack")))%></td>
                        <td height="25" align="center">
                            <asp:LinkButton ID="LinkPay" runat="server">付款</asp:LinkButton>&nbsp;<asp:LinkButton
                                ID="LinkCheck" runat="server">收货</asp:LinkButton>&nbsp;<asp:LinkButton ID="LinkFeed"
                                    runat="server">评论</asp:LinkButton></td>
                      </tr>
                      </ItemTemplate>
                      <FooterTemplate>
                    </table>
                    </FooterTemplate>
                    </asp:Repeater>
                  </div>
      </div>
                <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
