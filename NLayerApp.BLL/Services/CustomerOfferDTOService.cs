using AutoMapper;
using NLayerApp.BLL.DTO;
using NLayerApp.BLL.Infrastructure;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Entities.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System;
namespace NLayerApp.BLL.Services
{
    public class CustomerOfferDTOService : ICustomerOfferDTOService
    {
        IUnitOfWork Database { get; set; }

        public CustomerOfferDTOService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<CustomerOfferDTO> GetCustomerOffers(string userId)
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CustomerOffer, CustomerOfferDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<CustomerOffer>, List<CustomerOfferDTO>>(Database.CustomerOffers.Find(x=>x.Customer.UserId==userId));
        }

        public CustomerOfferDTO GetCustomerOffer(int? id)
        {
            if (id == null)
                throw new ValidationException("write id services", "");
            var customerOffer = Database.CustomerOffers.Get(id.Value);
            if (customerOffer == null)
                throw new ValidationException("Not found", "");

            return new CustomerOfferDTO { CustomerId=customerOffer.CustomerId,Content=customerOffer.Content, CustomerOfferId=customerOffer.CustomerOfferId,OfferId=customerOffer.OfferId, Price=customerOffer.Price,Time=customerOffer.Time };
        }

        public void Dispose()
        {
            Database.Dispose();
        }


        public void Create(CustomerOfferDTO customerOffer)
        {
            customerOffer.CustomerId = Database.Customers.GetUserID(customerOffer.UserId).CustomerId;
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CustomerOfferDTO, CustomerOffer>()).CreateMapper();
            var customerOfferF = mapper.Map<CustomerOfferDTO, CustomerOffer>(customerOffer);
            Database.CustomerOffers.Create(customerOfferF);
            Database.Save();

        }




        //public IEnumerable<OfferDTO> GetAllOffers()
        //{
        //    var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Offer, OfferDTO>()).CreateMapper();
        //    return mapper.Map<IEnumerable<Offer>, List<OfferDTO>>(Database.Offers.GetAll());
        //}
    }
}

