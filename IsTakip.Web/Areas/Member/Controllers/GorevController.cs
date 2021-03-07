using AutoMapper;
using IsTakip.Business.Concrete;
using IsTakip.Business.Interfaces;
using IsTakip.DTO.DTOs.GorevDtos;
using IsTakip.Entities.Concrete;
using IsTakip.Web.BaseControllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Member.Controllers
{
    [Authorize(Roles = "Member")]
    [Area("Member")]
    public class GorevController : BaseIdentityController
    {
        #region CTOR - DEPENDENCY INJECTION
        private readonly IGorevService _gorevService;
        private readonly IMapper _mapper;
        public GorevController(UserManager<AppUser> userManager, IGorevService gorevService, IMapper mapper) : base(userManager)
        {
            _gorevService = gorevService;
            _mapper = mapper;
        }
        #endregion

        #region Index/Ana Sayfa
        public async Task<IActionResult> Index(int aktifSayfa = 1)
        {
            TempData["Active"] = "gorev";

            var user = await GetirGirisYapanKullanici();


            var gorevler = _mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarlaTamamlanmayan(out int toplamSayfa, user.Id, aktifSayfa));

            ViewBag.ToplamSayfa = toplamSayfa;
            ViewBag.AktifSayfa = aktifSayfa;


            return View(gorevler);
        }
        #endregion
    }
}
