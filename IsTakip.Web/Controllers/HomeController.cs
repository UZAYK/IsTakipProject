using IsTakip.Business.Interfaces;
using IsTakip.DTO.DTOs.AppUserDtos;
using IsTakip.Entities.Concrete;
using IsTakip.Web.BaseControllers;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Controllers
{
    public class HomeController : BaseIdentityController
    {
        #region CTOR
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ICustomLogger _customLogger;
        public HomeController(UserManager<AppUser> userManager, ICustomLogger customLogger,
            SignInManager<AppUser> signInManager) : base(userManager)
        {
            _signInManager = signInManager;
            _customLogger = customLogger;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Giriş Yap
        [HttpPost]
        public async Task<IActionResult> GirisYap(AppUserSignInDto model)
        {
            TempData["Active"] = "cikis";

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    var identityResult = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
                    if (identityResult.Succeeded)
                    {
                        var roller = await _userManager.GetRolesAsync(user);
                        if (roller.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home", new { area = "Member" });
                        }
                    }
                }
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
            }
            return View("Index", model);
        }
        #endregion

        #region Kayıt Ol
        public IActionResult KayitOl()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> KayitOl(AppUserAddDto model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Name = model.Name,
                    SurName = model.SurName
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var addRoleResult = await _userManager.AddToRoleAsync(user, "Member");
                    if (addRoleResult.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    HataEkle(addRoleResult.Errors);
                }
                HataEkle(result.Errors);
            }
            return View(model);
        }
        #endregion

        #region Çıkış Yap
        public async Task<IActionResult> CikisYap()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        #endregion

        public IActionResult StatusCode(int? code)
        {
            if (code == 404)
            {
                ViewBag.Code = code;
                ViewBag.Message = "Sayfa Bulunmadı";
            }

            return View();
        }

        public IActionResult Error()
        {
            var exceptionHandler = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            ViewBag.Path = exceptionHandler.Path;

            _customLogger.LogError($"Hatanın oluştuğu yer :{exceptionHandler.Path}\nHatanın mesajı :{exceptionHandler.Error.Message}\nStack Trace :{exceptionHandler.Error.StackTrace}");

            //ViewBag.Message = exceptionHandler.Error.Message;

            return View();
        }

        public void Hata()
        {
            throw new Exception("Bu bir hata");
        }
    }
}
