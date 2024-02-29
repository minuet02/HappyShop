using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Model;
using BLL;

public partial class CategoryItem : System.Web.UI.Page
{
    protected string txtTitle = string.Empty;
    public string txtCategory = string.Empty;
    public string txtCurrentPage = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        ReTitle();
        if (!IsPostBack)
        {
            LinkBind();
            PsPageData();
            PageData();

        }
    }
    protected string ReTitle() {

        if (Request.QueryString["Category"] != null)
        {
            txtCategory = Request.QueryString["Category"].ToString();
            switch (txtCategory)
            {

                case "Dress":
                    txtTitle = "服 装  商城网";
                    CategoryName.Text = "服 装 系 列";
                    break;
                case "Cosmetic":
                    txtTitle = "化妆品  商城网";
                    CategoryName.Text = "化妆品系列";
                    break;
                case "Shoes":
                    txtTitle = "运动鞋  商城网";
                    CategoryName.Text = "运动鞋系列";
                    break;
                case "Raiment":
                    txtTitle = "服 饰  商城网";
                    CategoryName.Text = "服 饰 系 列";
                    break;
                case "Number":
                    txtTitle = "数码产品  商城网";
                    CategoryName.Text = "数码产品系列";
                    break;
            }
        }
        else {

            txtTitle = "服 装  商城网";
            CategoryName.Text = "服 装 系 列";
        
        }
        return txtTitle;
    }
    //分页
    protected PagedDataSource PsPageData() {

        Item bll = new Item();
        PagedDataSource ps = new PagedDataSource();
        if (Request.QueryString["Category"] != null)
        {

            txtCategory = Request.QueryString["Category"].ToString();

        }
        else {

            txtCategory = "Dress";
        
        }
        ps.DataSource = bll.GetItemByAllCategory(txtCategory);

        ps.AllowPaging = true;
        ps.PageSize = 24;
        string txtPa = Request.QueryString["page"];
        string txtCurrent = string.Empty;
        if (txtPa != null)
        {
            ps.CurrentPageIndex = Convert.ToInt32(txtPa) - 1;
        }
        else {

            ps.CurrentPageIndex = 0;
        
        }

        RepeaterCategory.DataSource = ps;
        RepeaterCategory.DataBind();
        return ps;
    
    }
    //分页链接判断
    public void LinkBind() {

        string txtPage = string.Empty;
        LinkIndex.Enabled = true;
        LinkUp.Enabled = true;
        LinkDown.Enabled = true;
        LinkEnd.Enabled = true;
        txtPage = Request.QueryString["page"];
        if (txtPage != null)
        {

            txtCurrentPage = txtPage;

        }
        else {

            txtCurrentPage = "1";
        
        }
        if (PsPageData().IsFirstPage) {

            LinkIndex.Enabled = false;
            LinkUp.Enabled = false;
        
        }
       else {

           int txtPa = Convert.ToInt32(txtCurrentPage) - 1;
           LinkIndex.NavigateUrl = "?page=1";
           LinkUp.NavigateUrl = "?page=" + txtPa + "";
        
        }
        if (PsPageData().IsLastPage)
        {

            LinkDown.Enabled = false;
            LinkEnd.Enabled = false;

        }
        else {

            int txtPa = Convert.ToInt32(txtCurrentPage) + 1;
            LinkDown.NavigateUrl = "?page=" + txtPa + "";
            LinkEnd.NavigateUrl = "?page=" + PsPageData().PageCount + "";
        
        }

    
    }
    //分页链接的判断
    protected void PageData() {

        StringBuilder builder = new StringBuilder();
        int txtPageCount = PsPageData().PageCount;
        string txtCur = Request.QueryString["page"];
        for (int i = 1; i <= txtPageCount; i++) {

            if (txtCur != null) {

                if (txtCur == i.ToString())
                {

                    builder.Append("[" + i + "]");

                }
                else {

                    builder.Append("<a href=\"?page=" + i + "\">[" + i + "]</a>");
                
                }
            
            }

            else
            {

                if (i == 1)
                {
                    builder.Append("[" + i + "]");
                }
                else {

                    builder.Append("<a href=\"?page=" + i + "\">[" + i + "]</a>");
                
                }

            }
        
        }

        FootTwoNum.InnerHtml = builder.ToString();
    
    }
    public string SubName(string nName) {

        string txtName = string.Empty;
        if (nName.Length < 8)
        {

            return nName;

        }
        else {

            txtName = nName.Substring(0, 8);
            return txtName;
        
        }
    
    }
}
