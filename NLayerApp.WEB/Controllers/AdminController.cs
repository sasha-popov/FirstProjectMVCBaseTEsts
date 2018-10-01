using AutoMapper;
using Newtonsoft.Json;
using NLayerApp.BLL.DTO;
using NLayerApp.BLL.Interfaces;
using NLayerApp.WEB.Models.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayerApp.WEB.Controllers
{
    public class AdminController : Controller
    {
        ICategoryDTOService serviceCategory;

        public AdminController(ICategoryDTOService serviceCategory)
        {
            this.serviceCategory = serviceCategory;
        }
        // GET: Admin
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {

            return View();
          }




    }
}