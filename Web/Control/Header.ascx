<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header.ascx.cs" Inherits="Control_Header" %>
<link href="../index.css" rel="stylesheet" type="text/css" />
<div id="HeaderShow">
  <div class="Logon" id="Logon"><a><img src="Image/logo1.gif" width="183" height="76" border="0" /></a></div>  
  <div class="Login" id="Login"><TABLE cellSpacing=0 cellPadding=0 border=0>
                    <TBODY>
                    <TR>
                      <TD width=284 style="height: 23px"></TD>
                      <TD id="UserLogin" vAlign=center align=right width=25 runat="server" style="height: 23px"><IMG 
                        height=18 src="Image/login.gif" width=18></TD>
                      <TD vAlign="bottom" align="middle" style="height: 23px">
                          <asp:HyperLink ID="LinkEntry" runat="server" NavigateUrl="~/Entry.aspx">登录</asp:HyperLink> | <asp:HyperLink
                              ID="LinkLogin" runat="server" NavigateUrl="~/Login.aspx">注册</asp:HyperLink><asp:Label ID="LabelWelcome" runat="server"
                                  Text="Label" Visible="false"></asp:Label>
                        </TD>       
                      <TD vAlign=center align=right width=28 style="height: 23px"><IMG height=19 
                        src="Image/cart.gif" width=26 /></TD>
                      <TD class=font1 vAlign=bottom align=middle width=176 style="height: 23px"><A 
                        class=font2 
                        href="http://localhost:6885/DSFree/Shopping.aspx"><SPAN 
                        class=font2></SPAN></A> &nbsp;<A 
                        href="UserCenter.aspx">会员中心</A> 
  | <A 
                        href="MessWord.aspx">客户留言</A></TD></TR></TBODY></TABLE></div>
    <div class="Search" id="Sheach">
      <TABLE cellSpacing=0 cellPadding=0 border=0>
                    <TBODY>
                    <TR>
                      <TD width=108 background=Image/find.gif style="height: 39px"></TD>
                      <TD vAlign=center align=middle 
                      background=Image/find_bg.gif style="width: 429px; height: 39px;"><!--Form Start-->                       

                        <TABLE cellSpacing=0 cellPadding=0 width=430 border=0>
                          <TBODY>
                          <TR>
                            <TD vAlign=center align=middle width=104 style="height: 24px"><SPAN 
                              id=ctl00_lbSelect>
                                <asp:DropDownList ID="DropDownListSearch" runat="server" Width="105px">
                                </asp:DropDownList></SPAN></TD>
                            <TD class=font3 align=middle 
                              width=48 style="height: 24px"><NOBR>关键字</NOBR></TD>
                            <TD align=left width=133 style="height: 24px"><INPUT class=font1 
                              size=18 id="SearchKey" runat="server"></TD>
                            <TD align=middle width=59 style="height: 24px">
                                <asp:ImageButton ID="ImageButtonSearch" ImageUrl="~/Image/f_bt.gif" runat="server" OnClick="ImageButtonSearch_Click" /></TD>
                            <TD align=middle style="height: 24px; width: 72px;"><A 
                              href="ViewSearch.aspx"><IMG 
                              height=20 alt=高级搜索 src="Image/a_bt.gif" 
                              width=64 border=0></A></TD><TD width="10"><%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" controltovalidate="SearchKey"></asp:RequiredFieldValidator>--%></TD></TR></TBODY></TABLE><!--Form End--></TD>
    <TD width=16 
                    background=Image/find_r.gif style="height: 39px"></TD>
      </TR></TBODY></TABLE></div>
					<div id="Nav" class="Nav" runat="server"></div>
					<div class="CommText" id="CommendText">
					  <table cellspacing="0" cellpadding="0" border="0">
                        <tbody>
                          <tr>
                            <td width="20" height="26"></td>
                            <td width="105"><span class="STYLE1">最新商品推荐</span></td>
                            <td width="10" height="26"></td>
                            <td width="815" height="26"><div id="ProductOne" class="ProductOne" runat="server"></div></td>
                            <td width="10" 
      height="26"></td>
                          </tr>
                        </tbody>
				      </table>
					</div>
  <div class="CommPic" id="CommPic" runat="server">
  <div id="demo" align="left" style="OVERFLOW:hidden;WIDTH:950px;COLOR:#ffffff">
      <table width="950px" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td id="demo1" runat="server"></td>
          <td id="demo2" align="left"></td>
        </tr>
      </table>
    </div>
  <script language="javascript" type="text/javascript"> 
  var speed=30   
  demo2.innerHTML=Header1_demo1.innerHTML   
  function   Marquee(){   
  if(demo2.offsetWidth-demo.scrollLeft<=0)   
  demo.scrollLeft-=Header1_demo1.offsetWidth   
  else{   
  demo.scrollLeft++   
  }   
  }   
  var   MyMar=setInterval(Marquee,speed)   
  demo.onmouseover=function()   {clearInterval(MyMar)}   
  demo.onmouseout=function()   {MyMar=setInterval(Marquee,speed)}   
  </script>
  </div>	
</div>