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

public partial class OrderPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {

            BindOrder();
        
        }
    }
    //public void Binduser()
    //{
    //    User bll = new User();
    //    IList<UserInfo> user = bll.GetUserDataByName(Session["User"].ToString());


    //}
    public void BindOrder() {

        if (Session["User"] != null)
        {

            Order bll = new Order();
            DataListOrder.DataSource = bll.GetOrderByOneName(Session["User"].ToString());
            DataListOrder.DataKeyField = "OrderId";
            DataListOrder.DataBind();

        }
        else {

            ClientScriptManager cs = this.ClientScript;
            cs.RegisterStartupScript(this.GetType(), "aa", "javascript:history.go(-1)", true);
        
        }
    
    }
    public decimal BindTotal(decimal nPrice, int nTotal) {

        return nPrice * nTotal;
    
    }

    protected void ButtonPay_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pay.aspx");

    }

    protected void DataListOrder_UpdateCommand(object source, DataListCommandEventArgs e)
    {

        Order bll = new Order();
        string txtId = DataListOrder.DataKeys[e.Item.ItemIndex].ToString();
        TextBox textbox = (TextBox)DataListOrder.Items[e.Item.ItemIndex].FindControl("OrderCount");
        string txtNum = textbox.Text.Trim().ToString();
        bll.UpdateItemTotal(int.Parse(txtNum), txtId);
        BindOrder();
        Response.Redirect("Order.aspx");
        
    }
    protected void DataListOrder_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        Order bll = new Order();
        string txtId = DataListOrder.DataKeys[e.Item.ItemIndex].ToString();
        bll.DeleteOrder(txtId);
        BindOrder();
        Response.Redirect("Order.aspx");
    }
}
