using AutoMapper;
using IsTakip.Business.Interfaces;
using IsTakip.DTO.DTOs.AppUserDtos;
using IsTakip.DTO.DTOs.GorevDtos;
using IsTakip.Entities.Concrete;
using IsTakip.Web.BaseControllers;
using IsTakip.Web.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IsTakip.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class IsEmriController : BaseIdentityController
    {
        #region CTOR - DEPENDENCY INJECTION
        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;
        private readonly IMapper _mapper;
        private readonly IDosyaService _dosyaService;
        private readonly IBildirimService _bildirimService;

        public IsEmriController(IAppUserService appUserService, IGorevService gorevService, IBildirimService bildirimService,
                                UserManager<AppUser> userManager, IDosyaService dosyaService, IMapper mapper) :base(userManager)
        {
            _appUserService = appUserService;
            _gorevService = gorevService;
            _dosyaService = dosyaService;
            _bildirimService = bildirimService;
            _mapper = mapper;
        }
        #endregion

        #region Index / Ana Sayfa
        public IActionResult Index()
        {
            TempData["Active"] = TempdataInfo.IsEmri;

            return View(_mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarla()));
        }
        #endregion

        #region Personel Ata
        public IActionResult AtaPersonel(int id, string s, int sayfa = 1)
        {
            TempData["Active"] = TempdataInfo.IsEmri;

            ViewBag.AktifSayfa = sayfa;

            ViewBag.Aranan = s;

            var personeller = _mapper.Map<List<AppUserListDto>>(_appUserService.GetirAdminOlmayanlar(out int toplamSayfa, s, sayfa));
            ViewBag.ToplamSayfa = toplamSayfa;

            ViewBag.Personeller = personeller;

            return View(_mapper.Map<GorevListDto>(_gorevService.GetirAciliyetileId(id)));
        }

        [HttpPost]
        public IActionResult AtaPersonel(PersonelGorevDto model)
        {
            var guncellenecekGorev = _gorevService.GetirIdile(model.GorevId);
            guncellenecekGorev.AppUserId = model.PersonelId;

            _gorevService.Guncelle(guncellenecekGorev);

            _bildirimService.Kaydet(new Bildirim
            {
                AppUserId = model.PersonelId,
                Aciklama = $"{guncellenecekGorev.Ad} adlı iş için görevlendirildiniz."
            });
            return RedirectToAction("Index");
        }
        #endregion

        #region Personel Görevlendir
        public IActionResult GorevlendirPersonel(PersonelGorevDto model)
        {
            TempData["Active"] = TempdataInfo.IsEmri;

            PersonelGorevlendirListDto personelGorevlendirModel = new PersonelGorevlendirListDto
            {
                AppUser = _mapper.Map<AppUserListDto>(_userManager.Users.FirstOrDefault(I => I.Id == model.PersonelId)),
                Gorev = _mapper.Map<GorevListDto>(_gorevService.GetirAciliyetileId(model.GorevId))
            };
            return View(personelGorevlendirModel);
        }
        #endregion

        #region Detaylandır
        public IActionResult Detaylandir(int id)
        {
            TempData["Active"] = TempdataInfo.IsEmri;

            return View(_mapper.Map<GorevListAllDto>(_gorevService.GetirRaporlarileId(id)));
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
    }
}
