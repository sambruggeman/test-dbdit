using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dbdit.BLL;
using dbdit.BLL.Models;
using dbdit.BLL.Lib;

namespace dbdit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISecurity _security;
        private readonly IUserProfile _userProfile;

        public HomeController(ISecurity security, IUserProfile userProfile)
        {
            _security = security;
            _userProfile = userProfile;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            BResult result;

            LoginModel loginModel = new LoginModel();
            loginModel.UserName = "Sam";
            loginModel.Password = "P@ssw0rd";

            _security.Login(loginModel, out result);

            if (result.IsValid)
            {
                ViewBag.Message = "Success";
            }
            else
            {
                ViewBag.Message = "Failed";
            }

            return View();
        }

        [Authorize(Roles = Constants.Admin)]
        public ActionResult Contact()
        {
            BResult result;
            ViewBag.Message = "Your contact page.";

            var user = _userProfile.GetById(WebMatrix.WebData.WebSecurity.CurrentUserId, out result);

            if (result.IsValid)
            {
                return View(user);
            }

            return View();
        }
    }
}
