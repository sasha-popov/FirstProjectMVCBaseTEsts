using AutoMapper;
using Microsoft.AspNet.Identity;
using NLayerApp.BLL.DTO;
using NLayerApp.BLL.Interfaces;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Entities.Interfaces;
using NLayerApp.WEB.Models.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayerApp.WEB.Controllers
{
    public class CompanyController : Controller
    {
        ICategoryDTOService serviceCategory;
        ICompanyOfferDTOService serviceCompanyOffer;
        ICompanyDTOService serviceCompany;
        IOfferDTOService serviceOffer;

        IUnitOfWork db;


        public CompanyController(ICategoryDTOService serviceCategory,ICompanyOfferDTOService serviceCompanyOffer, ICompanyDTOService serviceCompany, IOfferDTOService serviceOffer, IUnitOfWork db)
        {
            this.serviceCategory = serviceCategory;
            this.serviceCompanyOffer = serviceCompanyOffer;
            this.serviceCompany = serviceCompany;
            this.serviceOffer = serviceOffer;
            this.db = db;
        }
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Company")]
        public ActionResult RegisterOfCompanyOffers()
        {
            IEnumerable<CategoryDTO> CateforyDtos = serviceCategory.GetCategories();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, CategoryViewModel>()).CreateMapper();
            var categories = mapper.Map<IEnumerable<CategoryDTO>, List<CategoryViewModel>>(CateforyDtos);


            return View(categories);
        }

        [HttpPost]
        [Authorize(Roles = "Company")]
        public ActionResult RegisterOfCompanyOffers(List<OfferVM> offers)
        {
            var companyOffer = new CompanyOfferViewModel();
            companyOffer.UserId = User.Identity.GetUserId();
            var offersId = offers.Where(x => x.Selected);
            foreach (var x in offersId)
            {
                companyOffer.OffersId.Add(x.OfferId);
            }
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CompanyOfferViewModel, CompanyOfferDTO>()).CreateMapper();
            var companyOfferDTO = mapper.Map<CompanyOfferViewModel, CompanyOfferDTO>(companyOffer);
            serviceCompanyOffer.Create(companyOfferDTO);
            return RedirectToAction("PageForCompany");
        }

        [HttpGet]
        [Authorize(Roles = "Company")]
        public ActionResult PageForCompany()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OfferDTO, OfferViewModel>()).CreateMapper();
            var offersCompany = mapper.Map<IEnumerable<OfferDTO>, IEnumerable<OfferViewModel>>(serviceOffer.Find(User.Identity.GetUserId()));

            return View(offersCompany);
        }
    }
}