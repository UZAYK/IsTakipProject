using AutoMapper;
using IsTakip.Business.Interfaces;
using IsTakip.DTO.DTOs.AppUserDtos;
using IsTakip.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IsTakip.Web.ViewsComponents
{
    public class Wrapper : ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;
        public Wrapper(UserManager<AppUser> userManager, IBildirimService bildirimService, IMapper mapper)
        {
            _userManager = userManager;
            _bildirimService = bildirimService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var identityUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var model = _mapper.Map<AppUserListDto>(identityUser);


            var bildirimler = _bildirimService.GetirOkunmayanlar(model.Id).Count;

            ViewBag.BildirimSayisi = bildirimler;
            var roles = _userManager.GetRolesAsync(identityUser).Result;

            if (roles.Contains("Admin"))
            {
                return View(model);
            }
            return View("Member", model);

        }
    }
}
