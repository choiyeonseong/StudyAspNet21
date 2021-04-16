﻿using DotNetNote.Models;
using System;
using System.Web.UI;

namespace DotNetNote.Board
{
    public partial class BoardView : System.Web.UI.Page
    {
        private string _Id; // 현재 게시글 번호

        protected void Page_Load(object sender, EventArgs e)
        {
            lnkDelete.NavigateUrl = $"BoardDelete.aspx?Id={Request["Id"]}";
            lnkModify.NavigateUrl = $"BoardWrite.aspx?Id={Request["Id"]}&Mode=Edit";
            lnkReply.NavigateUrl = $"BoardWrite.aspx?Id={Request["Id"]}&Mode=Reply";

            _Id = Request["Id"];
            if (_Id == null)
                Response.Redirect("BoardList.aspx");

            if (!Page.IsPostBack)   // 처음 실행할때
                DisplayData();
        }

        private void DisplayData()
        {
            var repo = new DbRepository();
            Note note = repo.GetNoteById(Convert.ToInt32(_Id));

            lblNum.Text = _Id;
            lblName.Text = note.Name;
            lblEmail.Text = string.Format("<a href='mailto:{0}'>{0}</a>", note.Email);
            lblTitle.Text = note.Title;

            string content = note.Content;

            // 인코딩 방식 : Text, Html, Mixed
            string encoding = note.Encoding;
            if (encoding == "Text")
            {
                lblContent.Text = Helpers.HtmlUtility.EncodeWithTabAndSpace(content);
            }
            else if (encoding == "Mixed")
            {
                lblContent.Text = content.Replace("\r\n", "<br />");
            }
            else // HTML 
            {
                lblContent.Text = content;  // 변환없음
            }

            lblReadCount.Text = note.ReadCount.ToString();
            lblHomepage.Text = $"<a href='{note.Homepage}' target='_blank'>{note.Homepage}</a>";
            lblPostDate.Text = note.PostDate.ToString();
            lblPostIP.Text = note.PostIp;

            if (note.FileName.Length > 1)   // 파일이 첨부되어있음
            {
                lblFile.Text = $"{note.FileName} / 다운로드 {note.DownCount}";
            }
            else
            {
                lblFile.Text = "(None)";
            }
        }
    }
}