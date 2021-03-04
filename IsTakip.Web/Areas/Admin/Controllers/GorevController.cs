using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class GorevController : Controller
    {
        #region CTOR - DEPENDENCY INJECTION
        private readonly IGorevService _gorevService;
        private readonly IAciliyetService _aciliyetService;
        public GorevController(IGorevService gorevService, IAciliyetService aciliyetService)
        {
            _gorevService = gorevService;
            _aciliyetService = aciliyetService;
        }

        #endregion

        #region Index / Ana Sayfa
        public IActionResult Index()
        {
            TempData["Active"] = "gorev";

            List<Gorev> gorevler = _gorevService.GetirIdAciliyetTamamlanmayan();
            List<GorevListViewModel> models = new List<GorevListViewModel>();
            foreach (var item in gorevler)
            {
                GorevListViewModel model = new GorevListViewModel
                {
                    Aciklama = item.Aciklama,
                    Aciliyet = item.Aciliyet,
                    Ad = item.Ad,
                    AciliyetId = item.AciliyetId,
                    Durum = item.Durum,
                    Id = item.Id,
                    OlusturulmaTarihi = item.OlusturulmaTarihi,
                };
                models.Add(model);
            }
            return View(models);
        }
        #endregion

        #region Görev Ekle
        public IActionResult EkleGorev()
        {
            TempData["Active"] = "gorev";
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim");
            return View(new GorevAddViewModel());
        }

        [HttpPost]
        public IActionResult EkleGorev(GorevAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _gorevService.Kaydet(new Gorev
                {
                    Aciklama = model.Aciklama,
                    Ad = model.Ad,
                    AciliyetId = model.AciliyetId,
                });
                return RedirectToAction("Index");
            }

            return View(model);
        }
        #endregion

        #region Görev Güncelle
        public IActionResult GuncelleGorev(int id)
        {
            TempData["Active"] = "gorev";

            var gorev = _gorevService.GetirIdile(id);
            GorevUpdateViewModel model = new GorevUpdateViewModel
            {
                Id = gorev.Id,
                AciliyetId = gorev.AciliyetId,
                Ad = gorev.Ad,
                Aciklama = gorev.Aciklama
            };
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(),
                "Id", "Tanim", gorev.AciliyetId);

            return View(model);

        }
        [HttpPost]
        public IActionResult GuncelleGorev(GorevUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _gorevService.Guncelle(new Gorev()
                {
                    Id = model.Id,
                    Aciklama = model.Aciklama,
                    Ad = model.Ad,
                    AciliyetId = model.AciliyetId,
                });
                return RedirectToAction("Index");
            } 

            return View(model);
        }
        #endregion

        #region Görev Sil
        public IActionResult SilGorev(int id)
        {
            _gorevService.Sil(new Gorev { Id = id });
            return Json(null);
        } 
        #endregion
    }
}
