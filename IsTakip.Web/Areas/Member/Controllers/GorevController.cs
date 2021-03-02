using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsTakip.Web.Areas.Member.Controllers
{
    public class GorevController : Controller
    {
        [Authorize(Roles = "Member")]
        [Area("Member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
