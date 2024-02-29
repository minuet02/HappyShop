<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Src="~/Control/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Control/Foot.ascx" TagPrefix="uc2" TagName="Foot" %>
<%@ Register Src="~/Control/ItemByCategoryId.ascx" TagPrefix="uc3" TagName="ItemByCategoryId" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>商城首页-服装-化妆品-运动鞋-服饰-数码产品</title>
    <link href="index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
    <link href="../index.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <uc1:Header id="Header1" runat="server"></uc1:Header>
    <div id="ContentShow">
  <div id="ContentLeft">
	  <div class="ContentCol" id="DressCol">
	    <table height="29" cellspacing="0" cellpadding="0" width="700" border="0">
          <tbody>
            <tr>
              <td width="27" background="Image/new0.gif"></td>
              <td width="558" align="left" valign="middle" 
                background="Image/new1.gif" class="FontWhite">服 装</td>
              <td align="left" width="68" background="Image/new1.gif"><a 
                  href="CategoryItem.aspx?Category=Dress" 
                  target="_blank"><img height="29" src="Image/more0.gif" 
                  width="51" border="0" /></a></td>
              <td width="7" 
background="Image/new2.gif"></td>
            </tr>
          </tbody>
        </table>
      <uc3:ItemByCategoryId ID="ShowDress" runat="server" GetCategory="Dress" />
	  </div>
	  <div class="ContentCol" id="cosmetic">
	    
        <table height="29" cellspacing="0" cellpadding="0" width="700" border="0">
          <tbody>
            <tr>
              <td width="27" background="Image/Recommend0.gif"></td>
              <td width="558" align="left" valign="middle" 
                background="Image/Recommend1.gif" class="FontWhite">化妆品</td>
              <td align="left" width="68" background="Image/Recommend1.gif"><a 
                  href="CategoryItem.aspx?Category=Cosmetic" 
                  target="_blank"><img height="29" src="Image/more1.gif" 
                  width="50" border="0" /></a></td>
              <td width="7" 
background="Image/Recommend2.gif"></td>
            </tr>
          </tbody>
        </table>
        <uc3:ItemByCategoryId ID="ShowCosmeticCol" runat="server" GetCategory="Cosmetic" />
	  </div>
<%--	  <div id="adOne" class="adStyle" runat="server"></div>--%>
      <div class="ContentCol" id="ShoesCol">
        <table height="29" cellspacing="0" cellpadding="0" width="700" border="0">
          <tbody>
            <tr>
              <td width="27" background="Image/hot0.gif"></td>
              <td width="558" align="left" valign="middle" 
                background="Image/hot1.gif" class="FontWhite">运动鞋</td>
              <td align="left" width="68" background="Image/hot1.gif"><a 
                  href="CategoryItem.aspx?Category=Shoes" 
                  target="_blank"><img height="29" src="Image/more2.gif" 
                  width="50" border="0" /></a></td>
              <td width="7" 
background="Image/hot2.gif"></td>
            </tr>
          </tbody>
        </table>
        <uc3:ItemByCategoryId ID="ShowShoesCol" runat="server" GetCategory="Shoes" />
      </div>
      <div class="ContentCol" id="RaimentCol">
        <table height="29" cellspacing="0" cellpadding="0" width="700" border="0">
          <tbody>
            <tr>
              <td width="27" background="Image/new0.gif"></td>
              <td width="558" align="left" valign="middle" 
                background="Image/new1.gif" class="FontWhite">服 饰</td>
              <td align="left" width="68" background="Image/new1.gif"><a 
                  href="CategoryItem.aspx?Category=Raiment" 
                  target="_blank"><img height="29" src="Image/more0.gif" 
                  width="51" border="0" /></a></td>
              <td width="7" 
background="Image/new2.gif"></td>
            </tr>
          </tbody>
        </table>
        <uc3:ItemByCategoryId ID="ShowRaimentCol" runat="server" GetCategory="Raiment" />
      </div>
      <div class="ContentCol" id="NumberCol">
<table height="29" cellspacing="0" cellpadding="0" width="700" border="0">
  <tbody>
    <tr>
      <td width="27" background="Image/hot0.gif"></td>
      <td width="558" align="left" valign="middle" 
                background="Image/hot1.gif" class="FontWhite">数码产品</td>
      <td align="left" width="68" background="Image/hot1.gif"><a 
                  href="CategoryItem.aspx?Category=Number"
                  target="_blank"><img height="29" src="Image/more2.gif" 
                  width="50" border="0" /></a></td>
      <td width="7" 
background="Image/hot2.gif"></td>
    </tr>
  </tbody>
</table>
<uc3:ItemByCategoryId ID="ShowNumberCol" runat="server" GetCategory="Number" />
      </div>
  </div>
	<div id="ContentRight">
	    <div id="Broad">
          <table cellspacing="0" cellpadding="0" width="236" border="0">
            <tbody>
              <tr>
                <td width="132" background="Image/anounce.gif" 
                height="38"></td>
                <td width="101" align="right" background="Image/anounce_m.gif"><a 
                  href="http://localhost:6885/DSFree/News.aspx"></a></td>
                <td width="4" 
            background="Image/anounce_r.gif"></td>
              </tr>
            </tbody>
          </table>
	      <table cellspacing="0" cellpadding="0" width="236" border="0">
            <tbody>
              <tr>
                <td height="142" valign="top" bgcolor="#f8f8f8" class="BrandBorder"><div id="Affiche">本店开张有优惠，欢迎大家来订购，来到电子商城，买到您最合适，最便宜的商品,把方便带给大家，把快乐送给你.</div>                <p>&nbsp;</p>
                </td>
              </tr>
              <tr>
                <td background="Image/anounce_b.gif" 
            height="6"></td>
              </tr>
            </tbody>
          </table>
        </div>
		<div class="RightLine" id="ClickLine">
          <table cellspacing="0" cellpadding="0" width="236" border="0">
            <tbody>
              <tr>
                <td width="128" background="Image/hotpoint.gif" 
                height="38">&nbsp;</td>
                <td width="101" align="right" background="Image/hotpoint_m.gif"></td>
                <td width="7" 
            background="Image/hotpoint_r.gif"></td>
              </tr>
            </tbody>
          </table>
		  <table cellspacing="0" cellpadding="0" width="236" border="0">
            <tbody>
              <tr>
                <td valign="top" bgcolor="#f8f8f8" class="BrandBorder"><div class="RigthText" id="ClickText" runat="server"></div></td>
              </tr>
              <tr>
                <td background="Image/anounce_b.gif" 
            height="6"></td>
              </tr>
            </tbody>
          </table>
  </div>
  <div class="RightLine" id="CommendLine">
          <table cellspacing="0" cellpadding="0" width="236" border="0">
            <tbody>
              <tr>
                <td width="118" 
                height="38" background="Image/compoint.gif" class="spanRight">推荐的商品</td>
                <td width="101" align="right" background="Image/compoint_m.gif"></td>
                <td width="7" 
            background="Image/compoint_r.gif"></td>
              </tr>
            </tbody>
      </table>
		  <table cellspacing="0" cellpadding="0" width="236" border="0">
            <tbody>
              <tr>
                <td valign="top" bgcolor="#f8f8f8" class="BrandBorder">
				<div class="RightComText" id="CommendText" runat="server"></div>
				</td>
              </tr>
              <tr>
                <td background="Image/anounce_b.gif" 
            height="6"></td>
              </tr>
            </tbody>
          </table>
  </div>
<div id="Customer">
  <table cellspacing="0" cellpadding="0" width="236" border="0">
    <tbody>
      <tr>
        <td width="118" 
                height="38" background="Image/compoint.gif" class="spanRight">客服中心</td>
        <td width="101" align="right" background="Image/compoint_m.gif"></td>
        <td width="7" 
            background="Image/compoint_r.gif"></td>
      </tr>
    </tbody>
  </table>
  <table cellspacing="0" cellpadding="0" width="236" border="0">
            <tbody>
              <tr>
                <td align="center" valign="top" bgcolor="#f8f8f8" class="BrandBorder"><table cellspacing="0" cellpadding="0" width="223" border="0">
                  <tbody>
                    <tr>
                      <td class="font10" valign="center" align="right" width="50" 
                      height="26">电话：</td>
                      <td valign="center" align="left" 
                        width="180">010-12345678</td>
                    </tr>
                    
                  
                    <tr>
                      <td valign="bottom" align="right" 
                        height="23">Email：</td>
                      <td valign="bottom" 
                        align="left">shop@gmail.com</td>
                    </tr>
                    <tr>
                      <td height="8"></td>
                      <td></td>
                    </tr>
                  </tbody>
                </table></td>
              </tr>
              <tr>
                <td background="Image/anounce_b.gif" 
            height="6"></td>
              </tr>
            </tbody>
      </table>
      </div>
	  <div id="Vote">
  <table cellspacing="0" cellpadding="0" width="236" border="0">
    <tbody>
      <tr>
        <td width="118" 
                height="38" background="Image/compoint.gif" class="spanRight">投票调查</td>
        <td width="101" align="right" background="Image/compoint_m.gif">&nbsp;<a href="Vote.aspx">查看投票结果</a></td>
        <td width="7" 
            background="Image/compoint_r.gif"></td>
      </tr>
    </tbody>
  </table>
  <table cellspacing="0" cellpadding="0" width="236" border="0">
            <tbody>
              <tr>
                <td valign="top" bgcolor="#f8f8f8" class="BrandBorder"><table cellspacing="0" cellpadding="0" width="95%" 
                        align="center" border="0">
                  <tbody>
                    <tr>
                      <td>
                          <asp:RadioButtonList ID="RadioVoteList" runat="server">
                          </asp:RadioButtonList></td>
                    </tr>
                    <tr>
                      <td align="middle">&nbsp;&nbsp;
                          <asp:ImageButton ID="VoteBnt" runat="server" ImageUrl="Image/vote.gif" OnClick="VoteBnt_Click" />
                      </td>
                    </tr>
                  </tbody>
                </table></td>
              </tr>
              <tr>
                <td background="Image/anounce_b.gif" 
            height="6"></td>
              </tr>
            </tbody>
      </table>
      </div>
  </div>		
	</div>	
    <uc2:Foot id="Foot1" runat="server"></uc2:Foot>
    </div>
    </form>
</body>
</html>
