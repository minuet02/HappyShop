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
using Model;
using BLL;

public partial class ProductItem : System.Web.UI.Page
{
    protected string txtTitle = string.Empty;
    public string txtCategory = string.Empty;
    public string txtCurrentPage = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ReTitle();
            Item bll = new Item();
            CategoryName.Text = bll.GetCategoryNameByProductId(GetProductId());
            LinkBind();
            PsPageData();
            PageData();

        }
    }
    protected void ReTitle() {

        txtCategory = Request.QueryString["Product"];
        switch (txtCategory) {
        
            case "Coat":
                txtTitle = "外 套  商城网";
                break;
            case "Computer":
                txtTitle = "电 脑  商城网";
                break;
            case "HuFu":
                txtTitle = "护 肤  商城网";
                break;
            case "MianMo":
                txtTitle = "面 膜  商城网";
                break;
            case "MP3":
                txtTitle = "MP3  商城网";
                break;
            case "PeiShi":
                txtTitle = "配 饰  商城网";
                break;
            case "Shirt":
                txtTitle = "衬 衫  商城网";
                break;
            case "ShouJi":
                txtTitle = "手 机  商城网";
                break;
            case "Skirt":
                txtTitle = "裙 子  商城网";
                break;
            case "Soprts":
                txtTitle = "运动鞋  商城网";
                break;
            case "TouShi":
                txtTitle = "头 饰  商城网";
                break;
            default:
                txtTitle = "拖鞋  商城网";
                break;
        
        }

    
    }
    //获得类别的名称
    public string GetProductId()
    {

        txtCategory = Request.QueryString["Product"];
        if (txtCategory == null)
        {

            return "Coat";

        }
        else
        {

            return txtCategory;

        }

    }
    //分页
    protected PagedDataSource PsPageData()
    {

        Item bll = new Item();
        PagedDataSource ps = new PagedDataSource();
        ps.DataSource = bll.GetItemByProduct(GetProductId());
        ps.AllowPaging = true;
        ps.PageSize = 24;
        string txtPa = Request.QueryString["page"];
        string txtCurrent = string.Empty;
        if (txtPa != null)
        {
            ps.CurrentPageIndex = Convert.ToInt32(txtPa) - 1;
        }
        else
        {

            ps.CurrentPageIndex = 0;

        }

        RepeaterCategory.DataSource = ps;
        RepeaterCategory.DataBind();
        return ps;

    }
    //分页链接判断
    public void LinkBind()
    {

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
        else
        {

            txtCurrentPage = "1";

        }
        if (PsPageData().IsFirstPage)
        {

            LinkIndex.Enabled = false;
            LinkUp.Enabled = false;

        }
        else
        {

            int txtPa = Convert.ToInt32(txtCurrentPage) - 1;
            LinkIndex.NavigateUrl = "?page=1";
            LinkUp.NavigateUrl = "?page=" + txtPa + "";

        }
        if (PsPageData().IsLastPage)
        {

            LinkDown.Enabled = false;
            LinkEnd.Enabled = false;

        }
        else
        {

            int txtPa = Convert.ToInt32(txtCurrentPage) + 1;
            LinkDown.NavigateUrl = "?page=" + txtPa + "";
            LinkEnd.NavigateUrl = "?page=" + PsPageData().PageCount + "";

        }


    }
    //分页链接的判断
    protected void PageData()
    {

        StringBuilder builder = new StringBuilder();
        int txtPageCount = PsPageData().PageCount;
        string txtCur = Request.QueryString["page"];
        for (int i = 1; i <= txtPageCount; i++)
        {

            if (txtCur != null)
            {

                if (txtCur == i.ToString())
                {

                    builder.Append("[" + i + "]");

                }
                else
                {

                    builder.Append("<a href=\"?page=" + i + "\">[" + i + "]</a>");

                }

            }

            else
            {

                if (i == 1)
                {
                    builder.Append("[" + i + "]");
                }
                else
                {

                    builder.Append("<a href=\"?page=" + i + "\">[" + i + "]</a>");

                }

            }

        }

        FootTwoNum.InnerHtml = builder.ToString();

    }
    public string SubName(string nName)
    {

        string txtName = string.Empty;
        if (nName.Length < 8)
        {

            return nName;

        }
        else
        {

            txtName = nName.Substring(0, 8);
            return txtName;

        }

    }
}

