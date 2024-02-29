<%@ WebHandler Language="C#" Class="CheckNameHandler" %>

using System;
using System.Web;
using BLL;

public class CheckNameHandler : IHttpHandler {

    public string txtGetName = string.Empty;
    public void ProcessRequest (HttpContext context) {        

        context.Response.ContentType = "text/plain";
        string flag = string.Empty;
        txtGetName = context.Request.QueryString["userName"].ToString();
        User bll = new User();
        bool txtIsName = bll.CheckName(txtGetName);
        if (!CheckNameSize(txtGetName)) {

            flag = "0";
        
        }
        else if (!txtIsName)
        {

            flag = "2";

        }
        else {
            
            flag = "1";
        
        }
        context.Response.Write(flag);

    }

    public bool CheckNameSize(string nName) {

        return (System.Text.RegularExpressions.Regex.IsMatch(nName, @"^[\w]{6,10}$"));
    
    }
    public bool IsReusable {
        
        get {
            return false;
        }
    }

}