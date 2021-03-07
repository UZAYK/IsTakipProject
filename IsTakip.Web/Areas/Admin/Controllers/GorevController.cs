using AutoMapper;
using IsTakip.Business.Interfaces;
using IsTakip.DTO.DTOs.GorevDtos;
using IsTakip.Entities.Concrete;
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
        private readonly IMapper _mapper;
        public GorevController(IGorevService gorevService, IAciliyetService aciliyetService, IMapper mapper)
        {
            _gorevService = gorevService;
            _aciliyetService = aciliyetService;
            _mapper = mapper;
        }

        #endregion

        #region Index / Ana Sayfa
        public IActionResult Index()
        {
            TempData["Active"] = "gorev";

            return View(_mapper.Map<List<GorevListDto>>(_gorevService.GetirIdAciliyetTamamlanmayan()));
        }
        #endregion

        #region Görev Ekle
        public IActionResult EkleGorev()
        {
            TempData["Active"] = "gorev";
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim");
            return View(new GorevAddDto());
        }

        [HttpPost]
        public IActionResult EkleGorev(GorevAddDto model)
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
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(),
                "Id", "Tanim", gorev.AciliyetId);

            return View(_mapper.Map<GorevUpdateDto>(gorev));

        }
        [HttpPost]
        public IActionResult GuncelleGorev(GorevUpdateDto model)
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
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(),
               "Id", "Tanim", model.AciliyetId);
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
