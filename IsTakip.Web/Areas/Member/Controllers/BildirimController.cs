using AutoMapper;
using IsTakip.Business.Interfaces;
using IsTakip.DTO.DTOs.BildirimDtos;
using IsTakip.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class BildirimController : Controller
    {
        #region CTOR - DEPENDENCY INJECTION
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public BildirimController(IBildirimService bildirimService, UserManager<AppUser> userManager, IMapper mapper)
        {
            _bildirimService = bildirimService;
            _userManager = userManager;
            _mapper = mapper;
        }
        #endregion

        #region Index / Ana Sayfa
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "bildirim";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
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
