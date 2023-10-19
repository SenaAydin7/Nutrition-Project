using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.DTO;
using System;
using NutritionProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutritionProject.Controllers
{
    public class UserDayController : Controller
    {

        UserDayManager udm = new UserDayManager(new EfUserDayDal());



        [HttpGet()]
        public ActionResult GetUserDayDetails(int id)
        {
            var result = udm.GetUserDayDetails(id);
            return View(result);
        }

     
    }
}