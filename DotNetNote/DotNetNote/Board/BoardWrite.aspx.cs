﻿using DotNetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNote.Board
{
    public partial class BoardWrite : System.Web.UI.Page
    {
        public BoardWriteFormType FormType { get; set; } = BoardWriteFormType.Write; // default : 글쓰기

        private string _Id; //리스트에서 넘겨주는 번호

        protected void Page_Load(object sender, EventArgs e)
        {
            _Id = Request["Id"];    //  GET / POST 모두 다 받음
            if (!Page.IsPostBack)
            {
                switch (FormType)
                {
                    case BoardWriteFormType.Write:
                        LblTitleDescription.Text = "글쓰기 - 다음 필드들을 입력하세요.";
                        break;

                    case BoardWriteFormType.Modify:
                        LblTitleDescription.Text = "글수정 - 다음 필드들을 입력하세요.";
                        DisplayDataForModify();
                        break;

                    case BoardWriteFormType.Reply:
                        LblTitleDescription.Text = "글답변 - 다음 필드들을 입력하세요.";
                        DisplayDataForReply();
                        break;
                }
            }
        }

        protected void chkUpload_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            if (IsImageTextCorrect())
            {
                // TODO : 파일 업로드

                Note note = new Note();
                note.Id = Convert.ToInt32(_Id); //값이 없으면 0
                note.Name = txtName.Text;
                note.Email = txtEmail.Text;
                note.Title = txtTitle.Text;
                note.Homepage = txtHomepage.Text;
                note.Content = txtContent.Text;
                note.FileName = "";
                note.FileSize = 0;
                note.Password = txtPassword.Text;
                note.PostIp = Request.UserHostAddress;
                note.Encoding = rdoEncoding.SelectedValue;  // Text, Html, Mixed

                DbRepository repo = new DbRepository();
                switch (FormType)
                {
                    case BoardWriteFormType.Write:
                        repo.Add(note);
                        Response.Redirect("BoardList.aspx");
                        break;
                    case BoardWriteFormType.Modify:
                        break;
                    case BoardWriteFormType.Reply:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                lblError.Text = "보안코드가 틀렸습니다. 다시 입력하세요.";
            }
        }

        private bool IsImageTextCorrect()
        {
            if (Page.User.Identity.IsAuthenticated) // 이미 로그인 된 상태
            {
                return true;
            }
            else
            {
                if (Session["ImageText"] != null)
                {
                    return (txtImageText.Text == Session["ImageText"].ToString());
                }
            }
            return false;   // 보안코드 일치하지 않음
        }

        private void DisplayDataForModify()
        {
            throw new NotImplementedException();
        }

        private void DisplayDataForReply()
        {
            throw new NotImplementedException();
        }
    }
}