<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vote.aspx.cs" Inherits="VotePage" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Foot.ascx" TagPrefix="uc2" TagName="Foot" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<title>商城投票结果</title>
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
      <div id="MyVote">
            &nbsp;<asp:Repeater ID="RepeaterVote" runat="server">
      <HeaderTemplate>
      <table width="300" border="1" cellpadding="1" cellspacing="1" bordercolor="#CCCCCC">
    <tr>
      <td width="100" height="30" align="center" valign="middle" bgcolor="#CCCCCC">名 称</td>
      <td width="100" align="center" valign="middle" bgcolor="#CCCCCC">票 数</td>
      <td width="100" align="center" valign="middle" bgcolor="#CCCCCC">百分比</td>
    </tr> 
      </HeaderTemplate>
      <ItemTemplate>
       <tr>
      <td height="35" align="center" valign="middle"><%# Eval("VoteName") %></td>
      <td height="35" align="center" valign="middle"><%# Eval("VoteNum") %></td>
      <td height="35" align="center" valign="middle"><%# BindPercert(Eval("VoteNum").ToString())%>%</td>
    </tr>
      </ItemTemplate>
      <FooterTemplate>          
     </table>
      </FooterTemplate>
      </asp:Repeater><br />
          <asp:RadioButtonList ID="MyRadioButtonList" runat="server">
          </asp:RadioButtonList><br />
          <asp:Button ID="MyVoteButton" runat="server" Text="我要投票" OnClick="MyVoteButton_Click" /></div>
  </div>
        <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
