using System;
using System.Web;
using System.Collections;
using System.Web.SessionState;


/// <summary>
/// Global 的摘要说明
/// </summary>
namespace Applica
{
    public class Global:System.Web.HttpApplication
    {
        public Global()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        protected void Application_Start(Object sender, EventArgs e) {

            Application["Count"] = 1;
        
        }
        protected void Session_Start(Object sender, EventArgs e) {

            Application.Lock();
            Application["Count"] = Convert.ToInt32(Application["Count"]) + 1;
            Application.UnLock();
        }
        protected void Session_End(Object sender, EventArgs e) {

            Application.Lock();
            Application["Count"] = Convert.ToInt32(Application["Count"]) - 1;
            Application.UnLock();
        
        }
        protected void Application_End(Object sender, EventArgs e) { }
    }
}