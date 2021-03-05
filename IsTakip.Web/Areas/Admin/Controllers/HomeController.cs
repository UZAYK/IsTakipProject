using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        #region CTOR - DEPENDENCY INJECTION
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;
        private readonly IRaporService _raporService;
        private readonly UserManager<AppUser> _userManager;
        public HomeController(IRaporService raporService, UserManager<AppUser> userManager,
                              IBildirimService bildirimService, IGorevService gorevService)
        {
            _userManager = userManager;
            _bildirimService = bildirimService;
            _raporService = raporService;
            _gorevService = gorevService;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "anasayfa";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.AtanmayiBekleyenGorevSayisi = _gorevService.GetirAtanmayiBekleyenGorevSayisi();
            ViewBag.TamamlanmisGorevSayisi = _gorevService.GetirTamamlanmisGorevSayisi();
            ViewBag.OkunmamisBildirimSayisi = _bildirimService.GetirOkunmayanSayisiileAppUserId(user.Id);
            ViewBag.ToplamRaporSayisi = _raporService.GetirRaporSayisi();

            return View();
        }

        #endregion
    }
}
