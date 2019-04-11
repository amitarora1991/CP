using CP.CoreWeb.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CP.CustomerPortal.Controllers.AppAuthorization
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        // GET: Account
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(UserInfo model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //var result = await

            return View();
        }
    }
}