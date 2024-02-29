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
using BLL;
using Model;

public partial class ItemPage : System.Web.UI.Page
{
    protected string txtTitle = string.Empty;
    protected int txtRequestId;
    protected void Page_Load(object sender, EventArgs e)
    {
        Item bll = new Item();
        if (Request.QueryString["Id"] != null)
        {
            txtRequestId = Convert.ToInt32(Request.QueryString["Id"]);

            txtTitle = bll.GetTitle(txtRequestId)+"  商城网";
            FormViewItem.DataSource = bll.GetItemById(txtRequestId);
            FormViewItem.DataBind();
            bll.UpdateClick(txtRequestId);
        }
        else {

            Response.Redirect("Default.aspx");
        
        }
       
    }

    protected void Shopping_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["User"] == null)
        {

            Response.Redirect("Entry.aspx");

        }
        else
        {

            Order bll = new Order();
            string txtItemName = ((Label)FormViewItem.FindControl("LaItemName")).Text.Trim().ToString();
            string txtItemPrice = ((Label)FormViewItem.FindControl("LaPrice")).Text.Trim().ToString();

            OrderInfo info = new OrderInfo(DateTime.Now.ToString("yyyyMMddHHmmss"), Session["User"].ToString(), txtItemName, decimal.Parse(txtItemPrice),1);
            int rows = bll.InsertOrder(info);
            if (rows > 0)
            {

                Response.Redirect("Order.aspx");

            }
            else
            {

                Response.Redirect("Item.aspx?Id=" + Request.QueryString["Id"] + "");

            }

        }
    }
}
