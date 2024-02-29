<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MessWord.aspx.cs" Inherits="MessWord" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Foot.ascx" TagPrefix="uc2" TagName="Foot" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>留言版   商城网</title>
            <link href="index.css" rel="stylesheet" type="text/css" />
            <script type="text/javascript">
function Over(obj){

document.getElementById(obj).className="faceBg";

}
function Out(obj){

document.getElementById(obj).className="";

}
function AddFace(obj){

    var str="[:"+obj+":]";
    var ubb=document.getElementById("MessText");
    var ubbLength=ubb.value.length;
    ubb.focus();
    if(typeof document.selection !="undefined")
    {
        document.selection.createRange().text=str;  
    }
    else
    {
        ubb.value=ubb.value.substr(0,ubb.selectionStart)+str+ubb.value.substring(ubb.selectionStart,ubbLength);
    }
}
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
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <uc1:Header id="Header1" runat="server"></uc1:Header><div id="ContentColMess">        
 <div class="ContentNav" id="ContentNav"><span>当前的位置</span> <img src="Image/sign.gif" width="13" height="13" /> 用户留言</div>
 <div id="ConMessage">
 <asp:Repeater runat="server" ID="RepeaterCategory">
 <ItemTemplate> 
   <table width="928" height="35" border="1" cellpadding="1" cellspacing="1" bordercolor="#CCFF00">
     <tr bgcolor="#BCEF76">
       <td width="720" height="30"><span style="color:#3E3F46">发表人：</span><span style="color:#FF6600"><%#Eval("Name") %></span></td>
       <td><span style="color:#3E3F46">发表时间：</span><span style="color:#999999"><%# Eval("DateTim") %></span> </td>
     </tr>
     <tr>
       <td colspan="2" bgcolor="#F4FEE7" class="MessTdStyle"><%# ReImg(Eval("Content").ToString())%></td>
     </tr>
   </table>
   </ItemTemplate>
 </asp:Repeater>
 </div>
    <div id="ConCateFoot">
	 <div class="CatFootRight" id="CatFootRight">
	  <asp:Label ID="CurrPage" runat="server" Text="1" Visible="False"></asp:Label><div class="FootOneNum" id="FootOneNum">	  
          <asp:HyperLink ID="LinkIndex" runat="server">首页</asp:HyperLink> 
          <asp:HyperLink ID="LinkUp" runat="server">上一页</asp:HyperLink></div> <div class="FootTwoNum" id="FootTwoNum" runat="server"></div>
          <div class="FootThreeNum" id="FootThreeNum">
          <asp:HyperLink ID="LinkDown" runat="server">下一页</asp:HyperLink><asp:HyperLink
              ID="LinkEnd" runat="server">尾页</asp:HyperLink></div></div>
	</div>
    <div id="FaBiao">
      <table width="928" height="35" border="1" cellpadding="1" cellspacing="1" bordercolor="#CCFF00">
        <tr bgcolor="#BCEF76">
          <td height="30" colspan="3"><strong>我要留言</strong></td>
        </tr>
        <tr>
          <td width="60" bgcolor="#F4FEE7" class="MessTdStyle">用户名：          </td>
          <td width="843" colspan="2" bgcolor="#F4FEE7" class="MessTdStyle"><input type="text" name="textfield" id="UserName" runat="server" />
              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*"
                  ValidationExpression="^\w{2,10}$" ControlToValidate="UserName"></asp:RegularExpressionValidator>（用户名只能是2到10位的字母、数字或下划线组成）</td>
        </tr>
		<tr>
          <td width="60" height="35" bgcolor="#F4FEE7" class="MessTdStyle">表情：          </td>
          <td width="843" colspan="2" bgcolor="#F4FEE7" class="MessTdStyle"><table width="0" border="0" cellpadding="0">
            <tr>
              <td id="01" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/01.gif" width="20" height="20" /></td>
              <td id="02" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/02.gif" width="20" height="20" /></td>
			                <td id="03" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/03.gif" width="20" height="20" /></td>
							              <td id="04" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/04.gif" width="20" height="20" /></td>
										                <td id="05" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/05.gif" width="20" height="20" /></td>
														              <td id="06" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/06.gif" width="20" height="20" /></td>
																	                <td id="07" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/07.gif" width="20" height="20" /></td>
																					              <td id="08" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)" style="width: 26px"><img src="MeFace/08.gif" width="20" height="20" /></td>
																								                <td id="09" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/09.gif" width="20" height="20" /></td>
																												              <td id="10" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/10.gif" width="20" height="20" /></td>
																															                <td id="11" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/11.gif" width="20" height="20" /></td>
																																			              <td id="12" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)" style="width: 26px"><img src="MeFace/12.gif" width="20" height="20" /></td>
																																						                <td id="13" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/13.gif" width="20" height="20" /></td>
																																										              <td id="14" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/14.gif" width="20" height="20" /></td>
																																													                <td id="15" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/15.gif" width="20" height="20" /></td>
																																																	              <td id="16" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/16.gif" width="20" height="20" /></td>
																																																				                <td id="17" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/17.gif" width="20" height="20" /></td>
																																																								              <td id="18" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/18.gif" width="20" height="20" /></td>
																																																											                <td id="19" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/19.gif" width="20" height="20" /></td>
					              <td id="20" onmouseover="Over(this.id)" onmouseout="Out(this.id)" onclick="AddFace(this.id)"><img src="MeFace/20.gif" width="20" height="20" /></td>																																																										
            </tr>
          </table></td>
		</tr>
        <tr>
          <td bgcolor="#F4FEE7" class="MessTdStyle">内容：</td>
          <td colspan="2" bgcolor="#F4FEE7" class="MessTdStyle"><textarea id="MessText" name="textarea" runat="server"></textarea>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="MessText"
                  ErrorMessage="*"></asp:RequiredFieldValidator>(内容不能为空,必须在500次以内)</td>
        </tr>
        				<tr>
          <td height="40" bgcolor="#F4FEE7" class="MessTdStyle">&nbsp;验证码：</td>
          <td width="100" bgcolor="#F4FEE7" class="MessTdStyle">&nbsp;<input name="textfield" type="text" class="ValImg" id="ValImg" runat="server" />
              <asp:RequiredFieldValidator
              ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="ValImg"></asp:RequiredFieldValidator></td>
		  <td bgcolor="#F4FEE7" class="MessTdStyle" style="width: 730px">
              <img src="CheckImage.aspx" id="imgCheckCode" onclick="this.src=this.src+'?'" style="cursor:pointer;" /></td>
		  </tr>
		<tr>
          <td width="60" height="50" bgcolor="#F4FEE7" class="MessTdStyle">&nbsp;</td>
          <td width="843" colspan="2" bgcolor="#F4FEE7" class="MessTdStyle">&nbsp;<asp:Button ID="ButtonFaBiao" runat="server" Text="发表留言" OnClick="ButtonFaBiao_Click" /></td>
		</tr>
      </table>
    </div>
</div> 
 
            <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
