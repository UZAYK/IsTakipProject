using AutoMapper;
using IsTakip.DTO.DTOs.AppUserDtos;
using IsTakip.Entities.Concrete;
using IsTakip.Web.BaseControllers;
using IsTakip.Web.StringInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Member.Controllers
{
    [Area(AreaInfo.Member)]
    [Authorize(Roles = RoleInfo.Member)]
    public class ProfilController : BaseIdentityController
    {
        #region CTOR - DEPENDENCY INJECTION
        private readonly IMapper _mapper;
        public ProfilController(UserManager<AppUser> userManager, IMapper mapper):base(userManager)
        {
            _mapper = mapper;
        }
        #endregion

        #region Index/Ana Sayfa
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = TempdataInfo.Profil;
            var appUser = await GetirGirisYapanKullanici();
            return View(_mapper.Map<AppUserListDto>(appUser));
        }
      
        [HttpPost]
        public async Task<IActionResult> Index(AppUserListDto model, IFormFile resim)
        {
            if (ModelState.IsValid)
            {
                var guncellencekKullanici = _userManager.Users.FirstOrDefault(I => I.Id == model.Id);
                if (resim != null)
                {
                    string uzanti = Path.GetExtension(resim.FileName);
                    string resimAd = Guid.NewGuid() + uzanti;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + resimAd);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await resim.CopyToAsync(stream);
                    }

                    guncellencekKullanici.Picture = resimAd;
                }

                guncellencekKullanici.Name = model.Name;
                guncellencekKullanici.SurName = model.SurName;
                guncellencekKullanici.Email = model.Email;

                var result = await _userManager.UpdateAsync(guncellencekKullanici);
                if (result.Succeeded)
                {
                    TempData["message"] = "Güncelleme işleminiz başarı ile gerçekleşti";
                    return RedirectToAction("Index");
                }

                HataEkle(result.Errors);
            }
            return View(model);
        } 
        #endregion
    }
}
