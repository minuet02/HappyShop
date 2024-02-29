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

public partial class MessWord : System.Web.UI.Page
{
    public string txtCategory = string.Empty;
    public string txtCurrentPage = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["User"] != null) {

                UserName.Value = Session["User"].ToString();
            
            }
            LinkBind();
            PsPageData();
            PageData();

        }
    }
    //分页
    protected PagedDataSource PsPageData()
    {

        UserMess dll = new UserMess();
        PagedDataSource ps = new PagedDataSource();
        ps.DataSource = dll.GetUserMess();
        ps.AllowPaging = true;
        ps.PageSize = 10;
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

    protected void ButtonFaBiao_Click(object sender, EventArgs e)
    {
        string txtName = Server.HtmlEncode(UserName.Value);
        string txtContent = MessText.Value;
        UserMess mess = new UserMess();
        UserMessInfo info = new UserMessInfo(txtName, txtContent, DateTime.Now.ToString());
        if (Page.IsValid)
        {
            mess.InsertMess(info);
        }
        //PsPageData();
        Response.Redirect("MessWord.aspx");

    }

    public string ReImg(string nImg) {

        nImg = nImg.Replace("\n", "<br>");
        nImg = nImg.Replace("[:", "<img width='20' height='20' src='MeFace\\");
        nImg = nImg.Replace(":]", ".gif' />");
        return nImg;
    
    }
}

