<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewSearch.aspx.cs" Inherits="ViewSearch" %>
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
    <script language="javascript">
    <!--
    function CheckPrice(){
    
    var priceStart=document.getElementById("PriceStart").value;
    var priceEnd=document.getElementById("PriceEnd").value;
    var reg=/^\d{1,4}\.\d{1,2}$|^\d{1,4}$/;
    var IsBool=reg.test(priceStart);
    var IsBoolTwo=reg.test(priceEnd);
        
    if(IsBool & IsBoolTwo){
    
    if(Math.round(priceStart)>Math.round(priceEnd)){
    
            document.getElementById("spanPrice").innerHTML="错误";
    
    }
    else{
    
        document.getElementById("spanPrice").innerHTML="正确";
        
        }
    
    }
    else{
    
        document.getElementById("spanPrice").innerHTML="错误";
    
    }
    }
    -->
    </script>

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
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                                      </asp:ScriptManager>
    <div>
            <uc1:Header id="Header1" runat="server"></uc1:Header>
                            <div id="ConItemCol">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>

  <table width="720" border="0" align="center" cellpadding="0" cellspacing="0">
    <tr>
      <td height="50" colspan="3" align="center" valign="middle">&nbsp;</td>
    </tr>
    <tr>
      <td rowspan="4" align="center" valign="top">&nbsp;</td>
      <td width="80" height="35" align="left" valign="top"><p>商品的类别：&nbsp;</p>        </td>
      <td width="380" align="left" valign="top"><asp:DropDownList ID="SelectCategory" runat="server" Width="110px" AutoPostBack="True" OnSelectedIndexChanged="SelectCategory_SelectedIndexChanged"> </asp:DropDownList>
          </td>
    </tr>
    <tr>
      <td height="35" align="left" valign="top">商品的目录：&nbsp;</td>
      <td height="35" align="left" valign="top"><asp:DropDownList ID="SelectProduct" runat="server" Width="108px"> 
          <asp:ListItem Value="all">所有目录</asp:ListItem>
      </asp:DropDownList>
          </td>
    </tr>
        <tr>
      <td height="35" align="left" valign="top">商品的价格：</td>
      <td height="35" align="left" valign="top"><input name="text" type="text" id="PriceStart" runat="server" style="width: 60px" />
          -
          <input name="text" type="text" id="PriceEnd" runat="server" style="width: 60px" />
          元 按会员价搜索(例如10-50.55)<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
              ControlToValidate="PriceStart" ErrorMessage="*" ValidationExpression="^\d{1,4}\.\d{1,2}$|^\d{1,4}$"></asp:RegularExpressionValidator>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="PriceEnd"
              ErrorMessage="*" ValidationExpression="^\d{1,4}\.\d{1,2}$|^\d{1,4}$"></asp:RegularExpressionValidator><span id="spanPrice"></span></td>
    </tr>
    <tr>
      <td height="35" align="left" valign="top">商品的名称：</td>
      <td height="35" align="left" valign="top"><input name="text" type="text" id="ItemName" runat="server" onfocus="CheckPrice()" style="width: 262px" />
         </td>
    </tr>
    <tr>
      <td height="35" align="left" valign="top">&nbsp;</td>
      <td height="35" align="left" valign="top"><asp:Button ID="ButtonSearch" runat="server" Text="高级搜索" BackColor="#E0E0E0" BorderColor="Gray" BorderWidth="1px" OnClick="ButtonSearch_Click" /></td>
    </tr>
  </table>
                                    
</ContentTemplate>
 </asp:UpdatePanel>
</div>
            <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
