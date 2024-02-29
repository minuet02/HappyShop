<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Entry.aspx.cs" Inherits="Entry" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Foot.ascx" TagPrefix="uc2" TagName="Foot" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>会员登录中心  商城网</title>
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
<table width="360" border="0" cellpadding="0" cellspacing="0" bgcolor="#FFFFFF" class="login_border" align="center">
            <tr>
              <td height="41" colspan="4" align="left"><table width="100%" height="39" border="0" cellpadding="0" cellspacing="0" bgcolor="#D8E1E9">
                  <tr>
                    <td align="center" class="font1">用 户 登 录</td>
                  </tr>
              </table></td>
            </tr>
            <tr>
              <td colspan="3" valign="top"><table width="100%" border="1" cellpadding="0" cellspacing="5" bordercolor="#F0F0F0" class="f12">
                  <tr>
                    <td width="60" height="50" align="right">用户名：</td>
                    <td width="180">
                        <asp:TextBox ID="UserName" runat="server"  BorderColor="Silver" BorderWidth="1" Height="16px" Width="130px" Wrap="False"
                      ></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" ErrorMessage="不能为空"></asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td height="50" align="right">密 码：</td>
                    <td>
                        <asp:TextBox ID="PassWord" runat="server" BorderColor="Silver" BorderWidth="1px" TextMode="Password" Height="16px" Width="130px"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator2" runat="server" ControlToValidate="PassWord" ErrorMessage="不能为空"></asp:RequiredFieldValidator></td>
                  </tr>
				  <tr>
                    <td height="50" align="right">验证码：</td>
                    <td>
                        <asp:TextBox ID="CheckCode" runat="server" BorderColor="Silver" BorderWidth="1px" Height="16px" Width="60px"></asp:TextBox>
                        &nbsp;
                        <img src="CheckImage.aspx" id="imgCheckCode" onclick="this.src=this.src+'?'" style="cursor:pointer;" />
                        </td>
                        
                    <td>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator3" runat="server" ControlToValidate="CheckCode" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
                        </td>
				  </tr>
				  <tr>
				  <td></td>
				  <td>
                      </td>
				  <td></td>
				  </tr>
              </table></td>
            </tr>
            <tr>
              <td width="70" height="45" align="center" valign="bottom">&nbsp;&nbsp;&nbsp;&nbsp;</td>
              <td width="140" align="center" valign="bottom">
                  <asp:Button ID="ButtonEntry" runat="server" BackColor="GreenYellow" BorderColor="DarkGreen"
                      BorderWidth="1px" Text="登 录" OnClick="ButtonEntry_Click" /></td>
              <td width="150" align="left" valign="bottom"></td>
            </tr>
            <tr>
              <td height="15" colspan="3" align="center" valign="middle">&nbsp;</td>
            </tr>
          </table>
</div>
                <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
