using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.Web.BaseControllers;
using IsTakip.Web.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Member.Controllers
{
    [Area(AreaInfo.Member)]
    [Authorize(Roles = RoleInfo.Member)]
    public class HomeController : BaseIdentityController
    {
        #region CTOR - DEPENDENCY INJECTION
        private readonly IRaporService _raporService;
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;
        public HomeController(IRaporService raporService, UserManager<AppUser> userManager, IGorevService gorevService, 
                              IBildirimService bildirimService) :base(userManager)
        {
            _raporService = raporService;
            _gorevService = gorevService;
            _bildirimService = bildirimService;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = TempdataInfo.Anasayfa;

            var user = await GetirGirisYapanKullanici();

            ViewBag.RaporSayisi = _raporService.GetirRaporSayisiilAppUserId(user.Id);
            ViewBag.TamamlananGorevSayisi = _gorevService.GetirGorevSayisiTamamlananileAppUserId(user.Id);
            ViewBag.TamamlanmasiGerekenGorevSayisi = _gorevService.GetirGorevSayisiTamamlanmasiGerekenAppUserId(user.Id);
            ViewBag.OkunmamisBildirimSayisi = _bildirimService.GetirOkunmayanSayisiileAppUserId(user.Id);

            return View();
        } 
        #endregion
    }
}
