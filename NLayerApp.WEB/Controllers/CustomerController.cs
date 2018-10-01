using AutoMapper;
using Microsoft.AspNet.Identity;
using NLayerApp.BLL.DTO;
using NLayerApp.BLL.Infrastructure;
using NLayerApp.BLL.Interfaces;
using NLayerApp.WEB.Models.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayerApp.WEB.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerOfferDTOService serviceCustomerOffer;
        ICategoryDTOService serviceCategory;
        ICompanyDTOService serviceCompany;

        public CustomerController(ICustomerOfferDTOService serviceCustomerOffer, ICategoryDTOService serviceCategory, ICompanyDTOService serviceCompany)
        {
            this.serviceCustomerOffer = serviceCustomerOffer;
            this.serviceCategory = serviceCategory;
            this.serviceCompany = serviceCompany;
        }
        public ActionResult Index()
        {
            return RedirectToAction("PageForCustomer");
        }

        [Authorize(Roles = "Customer")]
        public ActionResult MyOffers()
        {
            IEnumerable<CustomerOfferDTO> customerOfferDtos = serviceCustomerOffer.GetCustomerOffers(User.Identity.GetUserId());
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CustomerOfferDTO, CustomerOfferViewModel>()).CreateMapper();
            var customerOffers = mapper.Map<IEnumerable<CustomerOfferDTO>, List<CustomerOfferViewModel>>(customerOfferDtos);
            return View(customerOffers);
        }

        [Authorize(Roles = "Customer")]
        [HttpGet]
        public ActionResult ServiceCreation(string nameCategory, int idOffer, string nameOffer)
        {
            ViewBag.nameCategory = nameCategory;
            ViewBag.nameOffer = nameOffer;
            ViewBag.idOffer = idOffer;
            return View();
        }

        [Authorize(Roles = "Customer")]
        [HttpPost]
        public ActionResult ServiceCreation(CustomerOfferViewModel customerOffer)
        {
            customerOffer.Time = DateTime.Now;
            customerOffer.UserId = User.Identity.GetUserId();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CustomerOfferViewModel, CustomerOfferDTO>()).CreateMapper();
            var customerOfferDTO = mapper.Map<CustomerOfferViewModel, CustomerOfferDTO>(customerOffer);
            serviceCustomerOffer.Create(customerOfferDTO);
            return RedirectToAction(actionName: "ListOfCompanies", routeValues: new { offerId = customerOffer.OfferId });
        }

        [HttpGet]
        [Authorize(Roles = "Customer")]
        public ActionResult PageForCustomer()
        {
            IEnumerable<CategoryDTO> CateforyDtos = serviceCategory.GetCategories();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, CategoryViewModel>()).CreateMapper();
            var categories = mapper.Map<IEnumerable<CategoryDTO>, List<CategoryViewModel>>(CateforyDtos);
            return View(categories);
        }

        public ActionResult ListOfCompanies(int offerId)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CompanyDTO, CompanyViewModel>()).CreateMapper();
            var customerOfferDTO = mapper.Map<IEnumerable<CompanyDTO>, IEnumerable<CompanyViewModel>>(serviceCompany.Find(offerId));
            return View(customerOfferDTO);
        }




    }
}