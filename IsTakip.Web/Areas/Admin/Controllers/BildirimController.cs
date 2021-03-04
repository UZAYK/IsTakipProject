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
    public class BildirimController : Controller
    {
        private readonly IBildirimService _bildirimService;
        private readonly UserManager<AppUser> _userManager;
        public BildirimController(IBildirimService bildirimService, UserManager<AppUser> userManager)
        {
            _bildirimService = bildirimService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
           
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
            TempData["Active"] = "bildirim";

            var guncellenecekBildirim = _bildirimService.GetirIdile(id);
            guncellenecekBildirim.Durum = true;
            _bildirimService.Guncelle(guncellenecekBildirim);
            return RedirectToAction("Index");
        }
    }
}
