// JavaScript Document             
var imgUrl=new Array();
var imgLink=new Array();


//��1��ͼ
imgUrl[1]="picture/2.jpg";
imgLink[1]="http://www.sina.com";

//��2��ͼ
imgUrl[2]="picture/3.jpg";
imgLink[2]="http://www.yali8.com";

//��3��ͼ
imgUrl[3]="picture/4.jpg";
imgLink[3]="http://www.yali8.com";

//��4��ͼ
imgUrl[4]="picture/5.jpg";
imgLink[4]="http://www.yali8.com";
//��5��ͼ
imgUrl[5]="picture/6.jpg";
imgLink[5]="http://www.yali8.com";


var num_pic =5
var focusPicNumSrc="image/"
var time1 = 0; //��ҳ��ʱ�ȴ�ͼƬ�����ʱ�䣬��λΪ�룬��������Ϊ0
var time2 = 5; //ͼƬ��ת�ļ��ʱ��

var timeout1 = time1*1000;
var timeout2 = time2*1000;
var jumpUrl = '';
var nn=1;//��ʼ����
var curFileNum = 1;//���ݸ�myPlayer���� ��ʾĿǰ��������ֵ

document.write('<style>');
document.write('.focusPic {border:1px #006600 solid; OVERFLOW: hidden;  WIDTH: 344px; POSITION: relative; HEIGHT: 242px}');
document.write('.focusPicNum {Z-INDEX: 99; left: 220px; POSITION: absolute; TOP: 350px;MARGIN-right: 3px}');
document.write('</style>');

if(navigator.appName == "Microsoft Internet Explorer"){
	setTimeout('change_img()',timeout1);
}
function change_img(){
	if(nn>num_pic) nn=1;
	setTimeout('setFocus2('+nn+')',timeout1);
	nn++;
	tt=setTimeout('change_img()',timeout2);
}
function setFocus2(i){
	jumpUrl=imgLink[i];
	curFileNum = i;
	selectLayer1(i);
	imgInit.filters.revealTrans.Transition=23;
	imgInit.filters.revealTrans.apply();
    playTran();
	document.images.imgInit.src=imgUrl[i];
}
function setFocus1(i){
	nn = i;
	ln=i;
	curFileNum = i;
	selectLayer1(i);
	setFocus2(i);
}
function selectLayer1(i){
	for (a=1;a<num_pic+1;a++ ){
		document.images['fi_'+a].src=focusPicNumSrc+a+'off.gif';
	}
	document.images['fi_'+i].src=focusPicNumSrc+i+'on.gif';
}
function goUrl(){
	ln=nn;
	if (ln ==1)if (jumpUrl!='') jumpUrl=imgLink[ln];
	jumpTarget='_blank';
	if (jumpUrl != ''){
		if (jumpTarget != '')window.open(jumpUrl,jumpTarget);
		else location.href=jumpUrl;
	}
}

function playTran(){
	if (document.all)imgInit.filters.revealTrans.play();
}
function GetObj(objName){ 
    if(document.getElementById){ 
        return eval('document.getElementById("' + objName + '")'); 
    }else if(document.layers){ 
        return eval("document.layers['" + objName +"']"); 
    }else{ 
        return eval('document.all.' + objName); 
    } 
} 
   