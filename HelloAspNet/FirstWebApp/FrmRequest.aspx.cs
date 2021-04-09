using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserID = "";
            string strPassword = string.Empty;  // ""
            string strName = "";
            string strAge = "";

            //strUserID = Request.QueryString["TxtUserID"];   // GET 방식 가져올때 ex) [url]?key=value&key=value 
            strUserID = Request.Params["TxtUserID"];          // 1. GET/POST 모두 불러옴
            strPassword = Request.Params["TxtPassword"];    
            strName = Request.Form["TxtName"];  // POST 방식 
            strAge = Request["TxtAge"];     // 2. GET/POST 모두 불러옴

            var result = $@"입력하신 아이디는 {strUserID} 이고<br />
                            암호는 {strPassword}입니다.<br />
                            이름은 {strName}이고,<br />
                            나이는 {strAge}입니다.<br />";
            LblResult.Text = result;

            LblIpAddress.Text = Request.UserHostAddress;    // ::1 = 127.0.0.1
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}