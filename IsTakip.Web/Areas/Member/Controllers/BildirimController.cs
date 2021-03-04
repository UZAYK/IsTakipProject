﻿using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.Web.Areas.Admin.Models;
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
        private readonly UserManager<AppUser> _userManager;
        public BildirimController(IBildirimService bildirimService, UserManager<AppUser> userManager)
        {
            _bildirimService = bildirimService;
            _userManager = userManager;
        }
        #endregion

        #region Index / Ana Sayfa
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "bildirim";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var bildirimler = _bildirimService.GetirOkunmayanlar(user.Id);
            List<BildirimListViewModel> models = new List<BildirimListViewModel>();
            foreach (var item in bildirimler)
            {
                BildirimListViewModel model = new BildirimListViewModel();
                model.Id = item.Id;
                model.Aciklama = item.Aciklama;
                models.Add(model);
            }
            return View(models);
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
