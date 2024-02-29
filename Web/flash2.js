// JavaScript Document
document.write('<DIV class=focusPicNum>');
for (i=1;i<num_pic+1;i++ )
{
document.write('<A href=javascript:setFocus1('+i+');><IMG height=16 src='+focusPicNumSrc+i+'off.gif width=22 border=0 MARGIN-right=2 name=fi_'+i+'></A>');
}
document.write('</DIV>');
document.write('<a id=PicLink href="javascript:goUrl()"><img src="'+imgUrl[1]+'" width=332 name=imgInit height="242" border="0" style="FILTER: revealTrans(duration=2,transition=6)"></a>');
document.images.imgInit.src=imgUrl[1];
    