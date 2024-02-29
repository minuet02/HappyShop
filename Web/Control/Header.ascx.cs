using System;
using System.Web;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Text;
using Model;
using BLL;


public partial class Control_Header : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["User"] != null)
            {

                LinkEntry.Visible = false;
                LinkLogin.Visible = false;
                LabelWelcome.Visible = true;
                LabelWelcome.Text = "欢迎您：" + Session["User"].ToString();

            }
            else {

                LinkEntry.Visible = true;
                LinkLogin.Visible = true;
                LabelWelcome.Visible = false;
            
            }
            BindSelectCategory();
            BindDataItem();
            BindDataCategory();
            BindProductAll();
            
        }
    }
    public void BindSelectCategory() {

        Category bll = new Category();
        IList<CategoryInfo> category = bll.GetCategory();

        DropDownListSearch.Items.Add(new ListItem("所有商品","all"));
        for (int i = 0; i < category.Count; i++) {

            DropDownListSearch.Items.Add(new ListItem(category[i].CategoryName, category[i].CategoryId));
        
        }
    
    }
    public void BindDataItem()
    {
        Item bll = new Item();
        IList<ItemInfo> item = bll.GetItemByNew();
        StringBuilder builder = new StringBuilder();
        builder.Append("<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\"><tr>");
        for (int i = 0; i < item.Count; i++)
        {
            builder.Append("<td><a href=\"Item.aspx?Id=" + item[i].ItemId + "\"><img src=\"" + item[i].ItemImage + "\" width=\"102\" height=\"90\" border=\"0\" /></a>");
            builder.Append("<br /><span class=\"FontOne\">" + SubName(item[i].ItemName) + "</span>");
            builder.Append("<span class=\"FontTwo\">Vip价格:" + item[i].VipPrice.ToString() + "</span><span class=\"FontThree\">会员价:" + item[i].MemberPrice + "</span></td>");
        }
        builder.Append("</tr></table>");
        demo1.InnerHtml = builder.ToString();
    }

    public void BindDataCategory() {

        Category bll = new Category();
        IList<CategoryInfo> category = bll.GetCategory();
        StringBuilder builder = new StringBuilder();
        builder.Append("<div class=\"NavOne\" id=\"div6\"><ul><li class=\"NavOne_li1\"><a href=\"Default.aspx\">首 页</a></li><li class=\"NavOne_li2\"></li>");
        builder.Append("<li class=\"NavOne_li3\">Home</li></ul></div>");                  
				      
        for (int i = 0; i < category.Count; i++) {

            builder.Append("<div class=\"NavOne\" id=\"div223\"><ul><li class=\"NavOne_li1\"><a href=\"CategoryItem.aspx?Category="+category[i].CategoryId+"\">" + category[i].CategoryName + "</a>");
            builder.Append("</li><li class=\"NavOne_li2\"></li><li class=\"NavOne_li3\">"+category[i].CategoryId+"</li></ul></div>");  
        
        }
        builder.Append("<div class=\"NavOne\" id=\"div66\"><ul><li class=\"NavOne_li1\"><a href=\"Helper.aspx\">帮助中心</a></li><li class=\"NavOne_li2\"></li>");
        builder.Append("<li class=\"NavOne_li3\">Helper</li></ul></div>");
        Nav.InnerHtml = builder.ToString();        
    
    }
    public void BindProductAll() {

        Product bll = new Product();
        IList<ProductInfo> product = bll.GetProduct();
        StringBuilder builder = new StringBuilder();
        builder.Append("<ul>");
        for (int i = 0; i < product.Count; i++) {

            builder.Append("<li><a href=\"ProductItem.aspx?Product=" + product[i].ProductId + "\">" + product[i].ProductName + "</a></li>");
        
        }
        builder.Append("</ul>");
        ProductOne.InnerHtml = builder.ToString();
    
    }
    public string SubName(string nName)
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
    protected void ImageButtonSearch_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        string txtCategory=DropDownListSearch.SelectedItem.Value;
        string txtKey=SearchKey.Value.Trim().ToString();
        Response.Redirect("SearchItem.aspx?Category=" + txtCategory + "&Key=" + txtKey + "");
    }
}
