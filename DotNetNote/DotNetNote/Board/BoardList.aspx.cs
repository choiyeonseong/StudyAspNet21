using DotNetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNote.Board
{
    public partial class BoardLlist : System.Web.UI.Page
    {
        private DbRepository _repo;

        // 검색모드이면 true, 보통 false
        public bool SearchMode { get; set; } = false;

        public int RecordCount = 0; // 총 레코드 수
        public int PageIndex = 0;   // 페이징 할때 값, 현재 보여줄 페이지 번호

        public BoardLlist()
        {
            _repo = new DbRepository(); // SqlConnection 인스턴스 생성
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!SearchMode)    // 기본 리스트
            {
                RecordCount = _repo.GetCountAll();
            }

            LblTotalRecord.Text = $"Total Record : {RecordCount}";

            if (Request["Page"]!=null)
            {
                PageIndex = Convert.ToInt32(Request["Page"]) - 1;
            }
            else
            {
                PageIndex = 0;  // 1페이지
            }

            // TODO : 쿠키 사용해서 리스트 페이지번호 유지

            // 페이징 처리
            PagingControl.PageIndex = PageIndex;
            PagingControl.RecordCount = RecordCount;

            if (!Page.IsPostBack)   // 처음 실행일때
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            if (!SearchMode)    // 기본 리스트
            {
                GrvNotes.DataSource = _repo.GetAll(PageIndex);  // 페이징 0부터 시작
            }
            GrvNotes.DataBind();    // 실제 데이터 바인딩 완성
        }
    }
}