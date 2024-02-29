using System;
using System.Web;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using Model;
using BLL;
using System.Text;

public partial class Control_ItemByCategoryId : System.Web.UI.UserControl
{
    public string txtCategoery = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        BindItemByCategory();
    }
    public void BindItemByCategory()
    {

        StringBuilder buider = new StringBuilder();
        StringBuilder buiderTwo = new StringBuilder();
        Item bll = new Item();
        buiderTwo.Append("<div class=\"ColText\" id=\"ColText\"><ul>");
        IList<ItemInfo> item = bll.GetItemByCategory(GetCategory);
        for (int i = 0; i < item.Count; i++)
        {

            if (i < 5)
            {
                buider.Append("<div class=\"DressPic\" id=\"div15\"><a href=\"Item.aspx?Id=" + item[i].ItemId + "\"><img src=\"" + item[i].ItemImage + "\" width=\"110\" height=\"110\" border=\"0\" /></a>");
                buider.Append("<span class=\"FontOne\">" + SubNameOne(item[i].ItemName) + "</span><span class=\"FontTwo\">VIP价格:" + item[i].VipPrice + "</span><span class=\"FontThree\">");
                buider.Append("会员价:" + item[i].MemberPrice + "</span><span class=\"FontFour\">市场价:" + item[i].AgoraPrice + "</span></div>");
            }
            else
            {

                buiderTwo.Append("<li><a href=\"Item.aspx?Id=" + item[i].ItemId.ToString() + "\" class=\"STYLE2\">" + SubNameTwo(item[i].ItemName) + "</a></li>");

            }
        }
        buiderTwo.Append("</ul></div>");
        ShowDressCol.InnerHtml = buider.ToString() + buiderTwo.ToString();

    }
    public string GetCategory
    {

        get { return txtCategoery; }
        set { txtCategoery = value; }

    }
    public string SubNameOne(string nName)
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
    public string SubNameTwo(string nName)
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
}
