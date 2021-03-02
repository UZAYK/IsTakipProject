using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Member.Controllers
{
    [Area("Member")]
    public class IsEmriController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IRaporService _raporService;

        public object RaporUpdateViewModel { get; private set; }

        public IsEmriController(IGorevService gorevService, UserManager<AppUser> userManager, IRaporService raporService)
        {
            _gorevService = gorevService;
            _raporService = raporService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "isemri";
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var gorevler = _gorevService.GetirTumTablolarla(I => I.AppUserId == user.Id && !I.Durum);

            List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();
            foreach (var item in gorevler)
            {
                GorevListAllViewModel model = new GorevListAllViewModel();
                model.Id = item.Id;
                model.Aciklama = item.Aciklama;
                model.Aciliyet = item.Aciliyet;
                model.Ad = item.Ad;
                model.AppUser = item.AppUser;
                model.Raporlar = item.Raporlar;
                model.OlusturulmaTarihi = item.OlusturulmaTarihi;
                models.Add(model);
            }
            return View(models);
        }

        public IActionResult EkleRapor(int id)
        {
            var gorev = _gorevService.GetirAciliyetileId(id);
            RaporAddViewModel model = new RaporAddViewModel();
            model.GorevId = id;
            model.Gorev = gorev;
            return View(model);
        }

        [HttpPost]
        public IActionResult EkleRapor(RaporAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _raporService.Kaydet(new Rapor()
                {
                    GorevId = model.GorevId,
                    Detay = model.Detay,
                    Tanim = model.Tanim,

                });
                return RedirectToAction("Index");

            }
            return View(model);
        }

        public IActionResult GuncelleRapor(int id)
        {
            TempData["Active"] = "isemri";

            var rapor = _raporService.GetirGorevileId(id);
            RaporUpdateViewModel model = new RaporUpdateViewModel();
            model.Id = rapor.Id;
            model.Tanim = rapor.Tanim;
            model.Detay = rapor.Detay;
            model.Gorev = rapor.Gorev;
            model.GorevId = rapor.GorevId;
            return View(model);
        }

        [HttpPost]
        public IActionResult GuncelleRapor(RaporUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                {
                    var guncellenecekRapor = _raporService.GetirIdile(model.Id);
                    guncellenecekRapor.Tanim = model.Tanim;
                    guncellenecekRapor.Detay = model.Detay;

                    _raporService.Guncelle(guncellenecekRapor);

                }
                return RedirectToAction("Index");

            }
            return View(model);
        }
        public IActionResult TamamlaGorev(int gorevId)
        {
            var guncellenecekGorev = _gorevService.GetirIdile(gorevId);
            guncellenecekGorev.Durum = true;
            _gorevService.Guncelle(guncellenecekGorev);
            return Json(null);
        }
    }
}
