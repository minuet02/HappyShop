<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchItem.aspx.cs" Inherits="SearchItem" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Foot.ascx" TagPrefix="uc2" TagName="Foot" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
            <link href="index.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Header id="Header1" runat="server"></uc1:Header>
        
        <div id="ContentCol">        
         <div class="ContentNav" id="ContentNav">搜索结果 : </div>
       <asp:Repeater ID="RepeaterCategory" runat="server">
       <HeaderTemplate>
          <div id="ConCategoryPic">
          </HeaderTemplate>
          <ItemTemplate>
            <div class="ConCatePic" id="div15"><a href="Item.aspx?Id=<%#Eval("ItemId") %>"><img src="<%#Eval("ItemImage") %>" width="110" height="110" border="0" /></a><span class="FontOne"><%# SubName(Eval("ItemName").ToString())%></span><span class="FontTwo">VIP价：<%# Eval("VipPrice")%></span><span class="FontThree">会员价：<%# Eval("MemberPrice") %></span><span class="FontFour">市场价：<%#Eval("AgoraPrice")%></span></div>
        </ItemTemplate>
        <FooterTemplate>
          </div>
          </FooterTemplate>
          </asp:Repeater>
        	<div id="ConCateFoot">
	  <div class="CatFootRight" id="CatFootRight">
	  <asp:Label ID="CurrPage" runat="server" Text="1" Visible="False"></asp:Label><div class="FootOneNum" id="FootOneNum">	  
          <asp:HyperLink ID="LinkIndex" runat="server">首页</asp:HyperLink> 
          <asp:HyperLink ID="LinkUp" runat="server">上一页</asp:HyperLink></div> <div class="FootTwoNum" id="FootTwoNum" runat="server"></div>
          <div class="FootThreeNum" id="FootThreeNum">
          <asp:HyperLink ID="LinkDown" runat="server">下一页</asp:HyperLink><asp:HyperLink
              ID="LinkEnd" runat="server">尾页</asp:HyperLink></div></div>
	</div>
</div>        
        <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
