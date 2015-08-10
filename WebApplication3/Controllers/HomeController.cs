using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace WebApplication3.Controllers
{
    [AccessDeniedAuthorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PersonModel personModel = new PersonModel
            {
                PersonId = 1,
                PersonFirstName = "Jan",
                PersonLastName = "Kowalski",
                PersonPhone = "+48611234345"
            };

            Mapper.CreateMap<PersonModel, PersonViewModel>();
            PersonViewModel personViewModel = Mapper.Map<PersonViewModel>(personModel);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    class PersonModel
    {
        public int PersonId { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string PersonPhone { get; set; }
    }

    class PersonViewModel
    {
        public int PersonId { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
    }
}