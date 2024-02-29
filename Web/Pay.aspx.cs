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
using BLL;
using Model;

public partial class Pay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {

            BindOrder();
            if (Session["User"] != null)
            {
                BindOrderData();
            }
        }
    }
    public void BindOrderData() {

        Order bll = new Order();
        FormViewOrderData.DataSource = bll.GetOrderByTwoName(Request.QueryString["OrderId"], Session["User"].ToString());
        FormViewOrderData.DataBind();
    
    }
    public void BindOrder() {

        User bll = new User();
        if (Session["User"] != null) {

            FormViewOrder.DataSource = bll.GetUserDataByName(Session["User"].ToString());
            FormViewOrder.DataBind();
        
        }
    
    }
    public decimal TotalPrice(decimal nPrice, int nTotal) {

        return nPrice * nTotal;
    
    }

    protected void ButtonPay_Click(object sender, EventArgs e)
    {
        string txtModel = ((DropDownList)FormViewOrder.FindControl("PostSelect")).SelectedItem.Text.ToString();
        string txtId = ((Label)FormViewOrderData.FindControl("LaOrder")).Text.Trim().ToString();
        string txtPost = ((TextBox)FormViewOrder.FindControl("UserPost")).Text.Trim().ToString();
        string txtAdress = ((TextBox)FormViewOrder.FindControl("Adress")).Text.Trim().ToString();
        string txtPhone = ((TextBox)FormViewOrder.FindControl("Phone")).Text.Trim().ToString();
        string txtPhonetele = ((TextBox)FormViewOrder.FindControl("Phonetele")).Text.Trim().ToString();
        Order bll = new Order();
        OrderInfo orderInfo = new OrderInfo(txtId,txtModel, txtAdress, int.Parse(txtPost), txtPhone, Int64.Parse(txtPhonetele));
        int rows = bll.UpdateDataOrder(orderInfo, txtId);
        if (rows > 0)
        {
            BindOrderData();
            Response.Redirect("PaySuccess.aspx");
        }
    }
}
