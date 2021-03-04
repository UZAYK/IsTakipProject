using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.Web.Areas.Admin.Models;
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
    public class IsEmriController : Controller
    {
        #region CTOR - DEPENDENCY INJECTION
        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;
        private readonly IDosyaService _dosyaService;
        private readonly UserManager<AppUser> _userManager;
        public IsEmriController(IAppUserService appUserService, IGorevService gorevService, UserManager<AppUser> userManager, IDosyaService dosyaService)
        {
            _appUserService = appUserService;
            _gorevService = gorevService;
            _userManager = userManager;
            _dosyaService = dosyaService;
        }
        #endregion

        #region Index / Ana Sayfa
        public IActionResult Index()
        {
            TempData["Active"] = "isemri";

            List<Gorev> gorevler = _gorevService.GetirTumTablolarla();
            List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();

            foreach (var item in gorevler)
            {
                GorevListAllViewModel model = new GorevListAllViewModel();
                model.Id = item.Id;
                model.Aciklama = item.Aciklama;
                model.Aciliyet = item.Aciliyet;
                model.Ad = item.Ad;
                model.OlusturulmaTarihi = item.OlusturulmaTarihi;
                model.AppUser = item.AppUser;
                model.Raporlar = item.Raporlar;
                models.Add(model);

            }
            return View(models);
        }
        #endregion

        #region Personel Ata
        public IActionResult AtaPersonel(int id, string s, int sayfa = 1)
        {
            TempData["Active"] = "isemri";

            ViewBag.AktifSayfa = sayfa;
            ViewBag.Aranan = s;

            int toplamSayfa;
            var gorev = _gorevService.GetirAciliyetileId(id);
            var personeller = _appUserService.GetirAdminOlmayanlar(out toplamSayfa, s, sayfa);

            ViewBag.ToplamSayfa = toplamSayfa;

            List<AppUserListViewModel> appUserListsModel = new List<AppUserListViewModel>();
            foreach (var item in personeller)
            {
                AppUserListViewModel model = new AppUserListViewModel();
                model.Id = item.Id;
                model.Name = item.Name;
                model.SurName = item.SurName;
                model.Email = item.Email;
                model.Picture = item.Picture;
                appUserListsModel.Add(model);
            }
            ViewBag.Personeller = appUserListsModel;

            GorevListViewModel gorevModel = new GorevListViewModel();
            gorevModel.Id = gorev.Id;
            gorevModel.Ad = gorev.Ad;
            gorevModel.Aciklama = gorev.Aciklama;
            gorevModel.Aciliyet = gorev.Aciliyet;
            gorevModel.OlusturulmaTarihi = gorev.OlusturulmaTarihi;
            return View(gorevModel);
        }
        #endregion

        #region Detaylandır
        public IActionResult Detaylandir(int id)

        {
            TempData["Active"] = "isemri";
            var gorev = _gorevService.GetirRaporlarileId(id);
            GorevListAllViewModel model = new GorevListAllViewModel();
            model.Id = gorev.Id;

            model.Raporlar = gorev.Raporlar;
            model.Aciklama = gorev.Aciklama;
            model.Ad = gorev.Ad;
            model.AppUser = gorev.AppUser;

            return View(model);
        }
        #endregion

        #region Excel İşlemleri
        public IActionResult GetirExcel(int id)
        {
            return File(_dosyaService.AktarExcel(_gorevService.GetirRaporlarileId(id).Raporlar),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", Guid.NewGuid() + ".xlsx");

        }
        #endregion

        #region PDF İşlemleri
        public IActionResult GetirPdf(int id)
        {
            var path = _dosyaService.AktarPdf(_gorevService.GetirRaporlarileId(id).Raporlar);
            return File(path, "application/pdf", Guid.NewGuid() + ".pdf");
        }

        #endregion

        #region Personel Ata
        [HttpPost]
        public IActionResult AtaPersonel(PersonelGorevlendirViewModel model)
        {
            TempData["Active"] = "isemri";

            var guncellenecekGorev = _gorevService.GetirIdile(model.GorevId);
            guncellenecekGorev.AppUserId = model.PersonelId;
            _gorevService.Guncelle(guncellenecekGorev);
            return RedirectToAction("Index");
        }
        #endregion

        #region Personel Görevlendir
        public IActionResult GorevlendirPersonel(PersonelGorevlendirViewModel model)
        {
            TempData["Active"] = "Isemri";

            var user = _userManager.Users.FirstOrDefault(I => I.Id == model.PersonelId);
            var gorev = _gorevService.GetirAciliyetileId(model.GorevId);

            AppUserListViewModel userModel = new AppUserListViewModel();
            userModel.Id = user.Id;
            userModel.Name = user.Name;
            userModel.Picture = user.Picture;
            userModel.SurName = user.SurName;
            userModel.Email = user.Email;

            GorevListViewModel gorevModel = new GorevListViewModel();
            gorevModel.Id = gorev.Id;
            gorevModel.Aciklama = gorev.Aciklama;
            gorevModel.Aciliyet = gorev.Aciliyet;
            gorevModel.Ad = gorev.Ad;
            //gorevModel.Durum = gorev.Durum;

            PersonelGorevlendirListViewModel personelGorevlendirModel = new PersonelGorevlendirListViewModel();
            personelGorevlendirModel.AppUser = userModel;
            personelGorevlendirModel.Gorev = gorevModel;

            return View(personelGorevlendirModel);
        } 
        #endregion
    }
}
