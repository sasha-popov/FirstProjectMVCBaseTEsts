using NLayerApp.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.BLL.DTO;
using AutoMapper;
using NLayerApp.DAL.Entities;
using NLayerApp.DAL.Entities.Interfaces;

namespace NLayerApp.BLL.Services
{
    public class OfferDTOService : IOfferDTOService
    {
        IUnitOfWork Database { get; set; }

        public OfferDTOService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void Create(OfferDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OfferDTO> Find(string userId)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Offer, OfferDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Offer>, List<OfferDTO>>(Database.Offers.FindWithCompanyOffer(x => x.Companies.Any(y=>y.UserId==userId)));
        }
    }
}
