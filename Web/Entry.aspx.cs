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

public partial class Entry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonEntry_Click(object sender, EventArgs e)
    {
        User bll = new User();
        string txtName=UserName.Text.Trim().ToString();
        string txtPass=PassSafe(PassWord.Text.Trim().ToString());
        string getCode = Session["Code"].ToString();
        bool IsCode;
        if (CheckCode.Text.Trim().ToString() == getCode)
        {

            IsCode = true;

        }
        else {

            IsCode = false;
        
        }
        if (bll.CheckUser(txtName, txtPass) && IsCode)
        {
            Session["User"] = txtName;
            Response.Redirect("Default.aspx");

        }
        else {

            Response.Redirect("Entry.aspx");
        
        }
    }
    public string PassSafe(string nPass)
    {

        byte[] passWord = System.Text.Encoding.UTF8.GetBytes(nPass);
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        byte[] passMd5 = md5.ComputeHash(passWord);
        string strPass = System.Text.Encoding.UTF8.GetString(passMd5).Trim().Replace("'", "!");
        return strPass;


    }
}
