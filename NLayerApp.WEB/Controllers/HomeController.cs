using AutoMapper;
using NLayerApp.BLL.DTO;
using NLayerApp.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using NLayerApp.WEB.Models.ModelsVM;
using Microsoft.AspNet.Identity;
using NLayerApp.BLL.Interfaces;

namespace NLayerApp.WEB.Controllers
{
    public class HomeController : Controller
    {
        ICustomerOfferDTOService serviceCustomerOffer;


        public HomeController(ICustomerOfferDTOService serviceCustomerOffer)
        {
            this.serviceCustomerOffer = serviceCustomerOffer;
        }
        public ActionResult Index()
        {
            var c = User.IsInRole("Customer");
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Customer"))
                {
                    return RedirectToAction("PageForCustomer", "Customer");
                }
                else if (User.IsInRole("Company"))
                {
                    return RedirectToAction("PageForCompany", "Company");
                }
            }
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}