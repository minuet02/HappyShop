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
using Model;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string PassSafe(string nPass) {

        byte[] passWord = System.Text.Encoding.UTF8.GetBytes(nPass);
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        byte[] passMd5 = md5.ComputeHash(passWord);
        string strPass = System.Text.Encoding.UTF8.GetString(passMd5).Trim().Replace("'","!");
        return strPass;

    
    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        User bll = new User();
        UserInfo userInfo = new UserInfo(UserName.Value, PassSafe(UserPassOne.Value), UserEmail.Value, UserPhone.Value, Int64.Parse(UserPhonetele.Value), UserAdress.Value, Request.UserHostAddress);

        if (Page.IsValid)
        {

            bll.InsertUser(userInfo);
            Session["User"] = UserName.Value.Trim().ToString();
            HttpContext.Current.Response.Redirect("LoginSuccess.aspx");

        }
        else
        {

            Response.Redirect("Login.aspx");

        }
    }
    protected void EntryButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("Entry.aspx");
    }
}
