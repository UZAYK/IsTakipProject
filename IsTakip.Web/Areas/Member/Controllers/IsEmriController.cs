using AutoMapper;
using IsTakip.Business.Interfaces;
using IsTakip.DTO.DTOs.GorevDtos;
using IsTakip.DTO.DTOs.RaporDtos;
using IsTakip.Entities.Concrete;
using IsTakip.Web.BaseControllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Member.Controllers
{
    [Authorize(Roles = "Member")]
    [Area("Member")]
    public class IsEmriController : BaseIdentityController
    {
        #region CTOR - DEPENDENCY INJECTION
        private readonly IGorevService _gorevService;
        private readonly IRaporService _raporService;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;

        public object RaporUpdateViewModel { get; private set; }

        public IsEmriController(IGorevService gorevService, UserManager<AppUser> userManager,
                                IRaporService raporService, IBildirimService bildirimService, IMapper mapper):base(userManager)
        {
            _gorevService = gorevService;
            _raporService = raporService;
            _bildirimService = bildirimService;
            _mapper = mapper;
        }
        #endregion

        #region Index/Ana Sayfa
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "isemri";
            var user = await GetirGirisYapanKullanici();
            
            return View(_mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarla(I => I.AppUserId == user.Id && !I.Durum)));
        }

        #endregion

        #region Rapor Ekleme
        public IActionResult EkleRapor(int id)
        {
            var gorev = _gorevService.GetirAciliyetileId(id);
            RaporAddDto model = new RaporAddDto
            {
                GorevId = id,
                Gorev = gorev
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EkleRapor(RaporAddDto model)
        {
            if (ModelState.IsValid)
            {
                _raporService.Kaydet(new Rapor()
                {
                    GorevId = model.GorevId,
                    Detay = model.Detay,
                    Tanim = model.Tanim,
                });
                var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");
                var aktifKulanici = await GetirGirisYapanKullanici();

                foreach (var admin in adminUserList)
                {
                    _bildirimService.Kaydet(new Bildirim()
                    {
                        Aciklama = $"{aktifKulanici.Name} {aktifKulanici.SurName} yeni bir rapor yazdı.",
                        AppUserId = admin.Id,
                    });
                }

                return RedirectToAction("Index");

            }
            return View(model);
        }
        #endregion

        #region Rapor Güncelleme
        public IActionResult GuncelleRapor(int id)
        {
            TempData["Active"] = "isemri";

            var rapor = _raporService.GetirGorevileId(id);
            RaporUpdateDto model = new RaporUpdateDto
            {
                Id = rapor.Id,
                Tanim = rapor.Tanim,
                Detay = rapor.Detay,
                Gorev = rapor.Gorev,
                GorevId = rapor.GorevId
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult GuncelleRapor(RaporUpdateDto model)
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
        #endregion

        #region Görev Tamamlama
        public async Task<IActionResult> TamamlaGorevAsync(int gorevId)
        {
            var guncellenecekGorev = _gorevService.GetirIdile(gorevId);
            guncellenecekGorev.Durum = true;
            _gorevService.Guncelle(guncellenecekGorev);

            var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");
            var aktifKulanici = await GetirGirisYapanKullanici();

            foreach (var admin in adminUserList)
            {
                _bildirimService.Kaydet(new Bildirim()
                {
                    Aciklama = $"{aktifKulanici.Name} {aktifKulanici.SurName} vermiş olduğunuz görevi tamamladı.",
                    AppUserId = admin.Id,
                });
            }
            return Json(null);
        }
        #endregion
    }
}
