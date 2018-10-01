using NLayerApp.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.BLL.DTO;
using AutoMapper;
using NLayerApp.DAL.Entities.Interfaces;
using NLayerApp.DAL.Entities;

namespace NLayerApp.BLL.Services
{
    public class CompanyOfferDTOService : ICompanyOfferDTOService
    {
        IUnitOfWork Database { get; set; }

        public CompanyOfferDTOService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void Create(CompanyOfferDTO companyOffer)
        {
            var companyId =Database.Companies.GetUserID(companyOffer.UserId).CompanyId;
            List<Offer> offers = new List<Offer>();
            foreach (var offerId in companyOffer.OffersId)
            {
                offers.Add(Database.Offers.Get(offerId));
            }           
            CompanyOffer companyOfferdal = new CompanyOffer();
            companyOfferdal.Price = 99999;
            companyOfferdal.Offers = offers;
            companyOfferdal.Companies.Add(Database.Companies.Get(companyId));


            Database.CompanyOffers.Create(companyOfferdal);
            Database.Save();

        }
    }
}
