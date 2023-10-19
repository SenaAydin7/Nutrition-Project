using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using NutritionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutritionProject.Controllers
{
    public class UserDetailsController : Controller
    {
        UserDetailsManager udm = new UserDetailsManager(new EfUserDetailDal());
        UserManager um = new UserManager(new EfUserDal());


        [HttpGet()]
        public ActionResult GetUserDetails(int id)
        {
            var result = udm.GetUserDetails(id);
            
            return View(result);
        }


    }
}