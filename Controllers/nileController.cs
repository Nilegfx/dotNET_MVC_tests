using MvcApplication1.Filters;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{

    public class nileController : Controller
    {
        //
        // GET: /nile/

        public ActionResult Index()
        {
            if (Request.IsLocal)
            {
                ViewBag.Locality = "local";
            }
            else
            {
                ViewBag.Locality = "not local";
            }
            return View();
        }


        [LogingNile]
        public ActionResult SayHi()
        {

            ViewBag.theParams = Request.Params;
            ViewBag.message = "say Hi message here";

            return View();
        }

        public ActionResult testPartial()
        {
            
            return View();
        }

        public ActionResult TheReviews()
        {
            var Model =
                from r in _reviews
                orderby r.City
                select r;

            return View(Model);
        }

        static List<Review> _reviews = new List<Review>
        {
            new Review
            {
                Id =  1,
                Name = "ahmed",
                Country = "Egypt",
                City = "Cairo",
                Rating = 5
            },
            new Review
            {
                Id =  2,
                Name = "ayoub",
                Country = "Egypt",
                City = "Hurghada",
                Rating = 8
            },
            new Review
            {
                Id =  3,
                Name = "samar",
                Country = "Egypt",
                City = "Giza",
                Rating = 3
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            },
            new Review
            {
                Id =  4,
                Name = "ethar",
                Country = "Saudia Arabia",
                City = "Mekka",
                Rating = 6
            }
        };
    }
}
