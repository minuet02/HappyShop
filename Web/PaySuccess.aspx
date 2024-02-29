<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaySuccess.aspx.cs" Inherits="PaySuccess" %>
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
                             <div id="ConItemCol">
  <table width="720" height="300" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr>
      <td align="center">
          您已经付款成功，稍后管理员就发货，请你注意查收</td>
    </tr>
  </table>
</div>
              <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
