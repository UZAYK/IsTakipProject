using AutoMapper;
using IsTakip.Business.Interfaces;
using IsTakip.DTO.DTOs.BildirimDtos;
using IsTakip.Entities.Concrete;
using IsTakip.Web.BaseControllers;
using IsTakip.Web.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Member.Controllers
{
    [Area(AreaInfo.Member)]
    [Authorize(Roles = RoleInfo.Member)]
    public class BildirimController : BaseIdentityController
    {
        #region CTOR - DEPENDENCY INJECTION
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;
        public BildirimController(IBildirimService bildirimService, UserManager<AppUser> userManager, IMapper mapper) : base(userManager)
        {
            _bildirimService = bildirimService;
            _mapper = mapper;
        }
        #endregion

        #region Index / Ana Sayfa
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = TempdataInfo.Bildirim;

            var user = await GetirGirisYapanKullanici();

            _mapper.Map<List<BildirimListDto>>(_bildirimService.GetirOkunmayanlar(user.Id));
            
            return View(_mapper.Map<List<BildirimListDto>>(_bildirimService.GetirOkunmayanlar(user.Id)));
        }
        [HttpPost]
        public IActionResult Index(int id)
        {
            var guncellenecekBildirim = _bildirimService.GetirIdile(id);
            guncellenecekBildirim.Durum = true;
            _bildirimService.Guncelle(guncellenecekBildirim);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
