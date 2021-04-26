using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortpolioWeb.Data;
using PortpolioWeb.Models;

namespace PortpolioWeb.Controllers
{
    public class AccountsController : Controller
    {
        private readonly PortpolioWebContext _context;

        public AccountsController(PortpolioWebContext context)
        {
            _context = context;
        }

        // GET: Accounts
        [HttpGet]
        public IActionResult Login()
        {
            var account = new Account();
            return View(account);
        }

        // GET: Accounts/Details/5
        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email, Password")] Account account)
        {
            if (ModelState.IsValid)
            {
                var result = CheckAccount(account.Email, account.Password);
                if (result == null)
                {   // 계정이 없음 - 화면을 Home/Index로 이동
                    ViewBag.Message = "해당 계정이 없습니다.";
                    return View("Login");
                }
                else
                {   // 로그인
                   HttpContext.Session.SetString("UserEmail", result.Email);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View("Login");
        }

        private Account CheckAccount(string email, string password)
        {
            return _context.Account.SingleOrDefault(a => a.Email.Equals(email) && a.Password.Equals(password));
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
