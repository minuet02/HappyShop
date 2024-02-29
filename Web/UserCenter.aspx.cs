using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Security.Cryptography;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;

public partial class UserCenterPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindUserInfo();
            BindUserOrder();
        }

    }
    public void BindUserInfo() {

        User user = new User();
        if (Session["User"] != null)
        {

            InfoRepeader.DataSource = user.GetUserDataByName(Session["User"].ToString());
            InfoRepeader.DataBind();

        }
        else {

            Response.Redirect("Default.aspx");
        
        }
    
    }
    public void BindUserOrder() {

        Order order=new Order();
        if (Session["User"] != null)
        {
            OrderRepeater.DataSource = order.GetOrderAndOrderStatus(Session["User"].ToString());
            OrderRepeater.DataBind();
        }
        else
        {

            Response.Redirect("Default.aspx");

        }   
    
    }
    public string IsPay(bool nPay) {

        if (nPay)
        {

            return "已付款";

        }
        else {

            return "没付款";
        
        }
    
    }
    public string IsCheckOrder(bool nCheckOrder)
    {

        if (nCheckOrder)
        {

            return "已收到";

        }
        else
        {

            return "没收到";

        }

    }
    public string IsFeedBack(int nFeedBack)
    {

        if (nFeedBack==0)
        {

            return "无";

        }
        else if (nFeedBack == 1)
        {

            return "好评";

        }
        else {

            return "差";
        
        }

    }
}
