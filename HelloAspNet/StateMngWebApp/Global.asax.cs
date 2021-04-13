using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace StateMngWebApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Now"] = DateTime.Now;

            Application["Visit"] = 0;   // 페이지 접속자 수
        }
        protected void Application_End(object sender, EventArgs e)
        {
            // logic없으면 삭제해도 무관
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Now"] = DateTime.Now;

            // 접속할때마다 접속자수 증가
            Application.Lock();
            Application["Visit"] = Convert.ToInt32(Application["Visit"]) + 1;
            Application.UnLock();
        }
        protected void Session_End(object sender, EventArgs e)
        {
            // 나갈때마다 접속자수 감소
            Application.Lock();
            Application["Visit"] = Convert.ToInt32(Application["Visit"]) - 1;
            Application.UnLock();
        }
    }
}