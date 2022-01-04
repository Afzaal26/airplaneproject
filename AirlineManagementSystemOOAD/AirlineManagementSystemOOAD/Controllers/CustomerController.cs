using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using AirlineManagementSystemOOAD.Models;

namespace AirlineManagementSystemOOAD.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        private airline_managementEntities db = new airline_managementEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string name, string pass)
        {
            var log = db.Logins.Where(x => x.Name == name && x.Password == pass).FirstOrDefault();
            if (log != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Please Enter Correct User Name Or Password!";
            }
            return View();
        }

        public ActionResult Booking(int id = 0)
        {
            TicketBook tb = new TicketBook();
            return View();
        }

        [HttpPost]
        public ActionResult Booking(TicketBook t)
        {
            using (airline_managementEntities ticket = new airline_managementEntities())
            {
                if (t.FlyingFrom == "-Select-" || t.FlyingTo == "-Select-")
                {
                    ViewBag.message = "Please Enter City";
                }
                else if (t.FlyingFrom == t.FlyingTo)
                {
                    ViewBag.message = "Error! Locations Are Same: ";
                }
                else if (t.Gender == "-Select-")
                {
                    ViewBag.message = "Please Enter Gender ";
                }
                else
                {
                    if (t.FClass == "Business class")
                    {

                        t.TotalAmount = t.Adults * 12000;
                        t.n = Convert.ToInt32(t.TotalAmount + (t.Child * 8000));
                        t.TotalAmount = t.n;
                        ticket.TicketBooks.Add(t);
                        ticket.SaveChanges();
                        ModelState.Clear();
                        ViewBag.Message = "Success";
                        return RedirectToAction("Details");

                    }
                    else if (t.FClass == "Economy class")
                    {
                        t.TotalAmount = t.Adults * 8000;
                        t.n = Convert.ToInt32(t.TotalAmount + (t.Child * 4000));
                        t.TotalAmount = t.n;
                        ticket.TicketBooks.Add(t);
                        ticket.SaveChanges();
                        ModelState.Clear();
                        ViewBag.Message = "Success";
                        return RedirectToAction("Details");
                    }
                    else if (t.FClass == "First class")
                    {
                        t.TotalAmount = t.Adults * 10000;
                        t.n = Convert.ToInt32(t.TotalAmount + (t.Child * 6000));
                        t.TotalAmount = t.n;
                        ticket.TicketBooks.Add(t);
                        ticket.SaveChanges();
                        ModelState.Clear();
                        ViewBag.Message = "Success";
                        return RedirectToAction("Details");
                    }
                }
            }
            return View("Booking", new TicketBook());
        }
        public ActionResult Details()
        {
            var fetch = db.TicketBooks.ToList();
            return View(fetch);
        }
        public ActionResult About()
        {
            return View();
        }
    }
}