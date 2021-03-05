using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class HomeController : Controller
    {
        #region CTOR - DEPENDENCY INJECTION
        private readonly IRaporService _raporService;
        private readonly UserManager<AppUser> _userManager;
        public HomeController(IRaporService raporService, UserManager<AppUser> userManager)
        {
            _raporService = raporService;
            _userManager = userManager;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "anasayfa";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.RaporSayisi = _raporService.GetirRaporSayisiilAppUserId(user.Id);

            return View();
        } 
        #endregion
    }
}
