using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IsTakip.Web.ViewsComponents
{
    public class Wrapper : ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly IBildirimService _bildirimService;
        public Wrapper(UserManager<AppUser> userManager, IBildirimService bildirimService)
        {
            _userManager = userManager;
            _bildirimService = bildirimService;
        }

        public IViewComponentResult Invoke()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            AppUserListViewModel model = new AppUserListViewModel();

            model.Id = user.Id;
            model.Name = user.Name;
            model.Picture = user.Picture;
            model.SurName = user.SurName;
            model.Email = user.Email;

            var bildirimler = _bildirimService.GetirOkunmayanlar(user.Id).Count;
            ViewBag.BildirimSayisi = bildirimler;

            var roles = _userManager.GetRolesAsync(user).Result;

            if (roles.Contains("Admin"))
            {
                return View(model);
            }
            return View("Member", model);

        }
    }
}
