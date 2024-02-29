using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Xml;
using BLL;
using Model;

public partial class _Default : System.Web.UI.Page
{
    public string txtImage = string.Empty;
    public string txtLink = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        BindClickTime();
        BindCommend();
        BindADThree();
        if (!Page.IsPostBack)
        {
            BindVote();
        }
    }
    public void BindClickTime() {

        Item bll = new Item();
        IList<ItemInfo> item = bll.GetItemByClickTime();
        StringBuilder builder=new StringBuilder();
        for (int i = 0; i < item.Count; i++) {

            if (i < 9)
            {

                builder.Append("<span>0" + (i+1) + "、<a href=\"Item.aspx?Id=" + item[i].ItemId + "\">" + SubNameOne(item[i].ItemName) + "</a></span>");

            }
            else {

                builder.Append("<span>" + (i+1) + "、<a href=\"Item.aspx?Id=" + item[i].ItemId + "\">" + SubNameOne(item[i].ItemName) + "</a></span>");
            
            }
        
        }
        ClickText.InnerHtml = builder.ToString();
    
    }
    public void BindCommend() {

        Item bll = new Item();
        IList<ItemInfo> item = bll.GetItemByCommend();
        StringBuilder builder=new StringBuilder();
        for (int i = 0; i < item.Count; i++) {
        
            builder.Append("<dl><a href=\"Item.aspx?Id="+item[i].ItemId+"\"><img src=\""+item[i].ItemImage+"\" border=\"0\" width=\"110\" height=\"110\" /></a>");
            builder.Append("<dd class=\"FontOne\">" + SubNameTwo(item[i].ItemName) + "</dd><dd class=\"FontTwo\">VIP:"+item[i].VipPrice+"</dd>");
            builder.Append("<dd class=\"FontThree\">会员价:"+item[i].MemberPrice+"</dd><dd class=\"FontFour\">市场价:"+item[i].AgoraPrice+"</dd></dl>");
        
        }
        CommendText.InnerHtml = builder.ToString();
    
    }
    public string BindADOne() {

        string txtPath = Server.MapPath("App_Data/ad.xml");
        string reImage=string.Empty;
        XmlDocument doc = new XmlDocument();
        doc.Load(txtPath);
        XmlNodeList listImage = doc.GetElementsByTagName("Image");

        foreach (XmlNode node in listImage) {

            reImage += node.InnerText.ToString() + "|";
        
        }
        txtImage = reImage.Substring(0,reImage.LastIndexOf("|"));
        return txtImage;
    
    }
    public string BindADTwo()
    {
        string txtPath = Server.MapPath("App_Data/ad.xml");
        string reLink = string.Empty;
        XmlDocument doc = new XmlDocument();
        doc.Load(txtPath);
        XmlNodeList listLink = doc.GetElementsByTagName("ImageLink");

        foreach (XmlNode nodeLink in listLink)
        {

            reLink += nodeLink.InnerText + "|";

        }
        txtLink = reLink.Substring(0,reLink.LastIndexOf("|"));
        return txtLink;

    }
    public void BindADThree() {

        string txtName = string.Empty;
        string txtImage = string.Empty;
        string txtWidth = string.Empty;
        string txtHeight = string.Empty;
        string txtPath = Server.MapPath("App_Data/adOne.xml");
        XmlDocument doc = new XmlDocument();
        doc.Load(txtPath);
        XmlNodeList list = doc.SelectSingleNode("IndexAD").ChildNodes;
        foreach (XmlNode node in list) {
        
            XmlElement ele=(XmlElement)node;
            if (ele.GetAttribute("vis") == "1") {

                XmlNodeList nodeList = node.ChildNodes;
                foreach (XmlNode nn in nodeList) {

                    if (nn.Name == "Image") { txtName = nn.InnerText.Trim().ToString(); }
                    if (nn.Name == "Width") { txtWidth = nn.InnerText.Trim().ToString(); }
                    if (nn.Name == "Height") { txtHeight = nn.InnerText.Trim().ToString(); }
                
                }
            
            }
        }
        txtImage = txtName.Substring(txtName.LastIndexOf(".")+1);
        txtImage = txtImage.ToUpper();

        // adOne.InnerHtml = GetName(txtImage, txtName, txtWidth, txtHeight);
    
    }
    public string GetName(string nName,string nPath,string nWidth,string nHeight) {

        StringBuilder builder = new StringBuilder();
        if (nName != "SWF")
        {

            builder.Append("<img id=\"adImg\" src=\"" + nPath + "\" border=\"0\" />");

        }
        else {

            builder.Append("<object classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0\"");
            builder.Append(" width=\""+nWidth+"\" height=\""+nHeight+"\"><param name=\"movie\" value=\"" + nPath + "\" />");
            builder.Append("<param name=\"quality\" value=\"high\" /><embed src=\""+nPath+"\" quality=\"high\"");
            builder.Append(" pluginspage=\"http://www.macromedia.com/go/getflashplayer\" type=\"application/x-shockwave-flash\"");
            builder.Append(" width=\"" + nWidth + "\" height=\"" + nHeight + "\"></embed></object>");
        
        }
        return builder.ToString();
    
    }
    public string SubNameOne(string nName)
    {

        if (nName.Length < 14)
        {

            return nName;

        }
        else
        {
            return nName.Substring(0, 14);
        }
    }
    public string SubNameTwo(string nName)
    {

        if (nName.Length < 8)
        {

            return nName;

        }
        else
        {
            return nName.Substring(0, 8);
        }
    }
    public void BindVote() {

        Vote bll = new Vote();
        RadioVoteList.DataSource = bll.GetVote();
        RadioVoteList.DataTextField = "VoteName";
        RadioVoteList.DataValueField = "VoteId";
        RadioVoteList.DataBind();
    
    }
    protected void VoteBnt_Click(object sender, ImageClickEventArgs e)
    {
        Vote bll = new Vote();
        foreach (ListItem item in RadioVoteList.Items) {

            if (item.Selected == true) {

                bll.UpdateVote(int.Parse(item.Value.ToString()));
            
            }        
        }
        BindVote();
        Response.Redirect("Vote.aspx");
    }
}
