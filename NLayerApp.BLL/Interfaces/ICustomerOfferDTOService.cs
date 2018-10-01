using NLayerApp.BLL.DTO;
using System.Collections.Generic;

namespace NLayerApp.BLL.Infrastructure
{
    public interface ICustomerOfferDTOService
    {
        CustomerOfferDTO GetCustomerOffer(int? id);
        IEnumerable<CustomerOfferDTO> GetCustomerOffers(string userId);
        void Create(CustomerOfferDTO item);
        void Dispose();

    }
}
