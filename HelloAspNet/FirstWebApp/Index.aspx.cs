using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnClick_Click(object sender, EventArgs e)
        {
            LblResult.Text = $"안녕하세요 {TxtDisplay.Text}!";
            Response.Write("반갑습니다.<br />"); // 서버에서 처리하면서 수행, 응답을 받은 값을 출력
        }
    }
}