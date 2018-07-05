using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminLteUi.ViewModels.RoleViewModels;
using CoreLibrary.IdentityCore;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AdminLteUi.Controllers
{
    public class RolesController : Controller
    {
        readonly RoleManager<ApplicationRole> _roleManager = new RoleManager<ApplicationRole>(
            new RoleStore<ApplicationRole>(new ApplicationDbContext()));

        // GET: Roles
        public ActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateRole(CreateRoleViewModel roleVm)
        {
            var idResult = _roleManager.Create(new ApplicationRole(roleVm.Name, roleVm.Description));
            if (idResult.Succeeded)
            {
                ModelState.Clear();
                return View();
            }

            return View(roleVm);

        }
    }
}