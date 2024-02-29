using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using BLL;

public partial class ViesSearchItem : System.Web.UI.Page
{
    public string txtCategory = string.Empty;
    public string txtCurrentPage = string.Empty;
    public string txtLink = string.Empty;
    public string txtPriceStart = string.Empty;
    public string txtPriceEnd = string.Empty;
    StringBuilder buiderLink = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            buiderLink.Append("?Category=" + Request.QueryString["Category"]+"");
            buiderLink.Append("&Product="+Request.QueryString["Product"]+"");
            buiderLink.Append("&PriceStart="+Request.QueryString["PriceStart"]+"");
            buiderLink.Append("&PriceEnd="+Request.QueryString["PriceEnd"]+"");
            buiderLink.Append("&Key=" + Request.QueryString["Key"] + "");

            LinkBind();
            PsPageData();
            PageData();

        }
    }
    protected PagedDataSource PsPageData() {

        Item bll = new Item();
        PagedDataSource ps = new PagedDataSource();
        txtPriceStart = Request.QueryString["PriceStart"];
        txtPriceEnd = Request.QueryString["PriceEnd"];

        ps.DataSource = bll.SearchItemByCategoryIdByItem(Request.QueryString["Category"], Request.QueryString["Product"], decimal.Parse(txtPriceStart), decimal.Parse(txtPriceEnd), Request.QueryString["Key"]);
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
        if (ps.PageSize<1) {

            ContentNav.InnerHtml = "没有找到你您所需要的信息";
        
        }
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
           LinkIndex.NavigateUrl = "" + buiderLink.ToString() + "&page=1";
           LinkUp.NavigateUrl = "" + buiderLink.ToString() + "&page=" + txtPa + "";
        
        }
        if (PsPageData().IsLastPage)
        {

            LinkDown.Enabled = false;
            LinkEnd.Enabled = false;

        }
        else {

            int txtPa = Convert.ToInt32(txtCurrentPage) + 1;
            LinkDown.NavigateUrl = "" + buiderLink.ToString() + "&page=" + txtPa + "";
            LinkEnd.NavigateUrl = "" + buiderLink.ToString() + "&page=" + PsPageData().PageCount + "";
        
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

                    builder.Append("<a href=\"" + buiderLink.ToString() + "&page=" + i + "\">[" + i + "]</a>");
                
                }
            
            }

            else
            {

                if (i == 1)
                {
                    builder.Append("[" + i + "]");
                }
                else {

                    builder.Append("<a href=\"" + buiderLink.ToString() + "&page=" + i + "\">[" + i + "]</a>");
                
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

