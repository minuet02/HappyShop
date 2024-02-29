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
using Model;
using BLL;

public partial class ViewSearch : System.Web.UI.Page
{
    public string txtCategory = string.Empty;
    public string txtProduct = string.Empty;
    public string txtPriceStart = string.Empty;
    public string txtPriceEnd = string.Empty;
    public string txtItem = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCategory();
        }

    }
    public void BindCategory() {

        Category bll = new Category();
        IList<CategoryInfo> category = bll.GetCategory();
        SelectCategory.Items.Add(new ListItem("所有商品", "all"));

        for (int i = 0; i < category.Count; i++)
        {

            SelectCategory.Items.Add(new ListItem(category[i].CategoryName, category[i].CategoryId));

        }
    
    }
    protected void ButtonSearch_Click(object sender, EventArgs e)
    {
        txtCategory = SelectCategory.SelectedItem.Value;
        txtProduct = SelectProduct.SelectedItem.Value;
        txtPriceStart = PriceStart.Value.Trim().ToString();
        if (string.IsNullOrEmpty(txtPriceStart)) {

            txtPriceStart = "0";
        
        }
        txtPriceEnd = PriceEnd.Value.Trim().ToString();
        if (string.IsNullOrEmpty(txtPriceEnd)) {

            txtPriceEnd = "0";
        
        }
        txtItem = Server.HtmlEncode(ItemName.Value.Trim().ToString().Replace(",", ""));
        if (string.IsNullOrEmpty(txtItem)) {

            txtItem = "0";
        
        }
        if (int.Parse(txtPriceStart) > int.Parse(txtPriceEnd))
        {

            Response.Redirect("ViewSearch.aspx");

        }

        Response.Redirect("ViewSearchItem.aspx?Category=" + txtCategory + "&Product=" + txtProduct + "&PriceStart=" + txtPriceStart + "&PriceEnd=" + txtPriceEnd + "&Key=" + txtItem + "");

    }
    protected void SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        Product bll = new Product();
        string txtCategory = string.Empty;
        SelectProduct.Items.Clear();

        SelectProduct.Enabled = true;
        IList<ProductInfo> product = bll.GetProductByCategory(SelectCategory.SelectedItem.Value);
        SelectProduct.Items.Add(new ListItem("所有目录", "all"));
        for (int i = 0; i < product.Count; i++)
        {

            SelectProduct.Items.Add(new ListItem(product[i].ProductName, product[i].ProductId));


        }
    }
}
