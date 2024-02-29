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

public partial class SearchItem : System.Web.UI.Page
{
    public string txtCategory = string.Empty;
    public string txtCurrentPage = string.Empty;
    public string txtLink = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtLink = "?Category=" + Request.QueryString["Category"] + "&Key=" + Request.QueryString["Key"] + "&";
            LinkBind();
            PsPageData();
            PageData();

        }
    }
    protected PagedDataSource PsPageData() {

        Item bll = new Item();
        PagedDataSource ps = new PagedDataSource();
        ps.DataSource = bll.SearchItemByCategoryId(Request.QueryString["Category"],Request.QueryString["Key"]);
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
           LinkIndex.NavigateUrl = "" + txtLink + "page=1";
           LinkUp.NavigateUrl = "" + txtLink + "page=" + txtPa + "";
        
        }
        if (PsPageData().IsLastPage)
        {

            LinkDown.Enabled = false;
            LinkEnd.Enabled = false;

        }
        else {

            int txtPa = Convert.ToInt32(txtCurrentPage) + 1;
            LinkDown.NavigateUrl = "" + txtLink + "page=" + txtPa + "";
            LinkEnd.NavigateUrl = "" + txtLink + "page=" + PsPageData().PageCount + "";
        
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

                    builder.Append("<a href=\"" + txtLink + "page=" + i + "\">[" + i + "]</a>");
                
                }
            
            }

            else
            {

                if (i == 1)
                {
                    builder.Append("[" + i + "]");
                }
                else {

                    builder.Append("<a href=\"" + txtLink + "page=" + i + "\">[" + i + "]</a>");
                
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

