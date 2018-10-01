using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.BLL.DTO
{
    public class CompanyOfferDTO
    {

        public int CompanyOfferId { get; set; }

        public virtual ICollection<OfferDTO> OffersDTO { get; set; }

        public virtual ICollection<CompanyDTO> CompaniesDTO { get; set; }
        public string UserId { get; set; }
        public List<int> OffersId { get; set; }

        public int Duration { get; set; }

        public int Price { get; set; }

        public CompanyOfferDTO()
        {
            OffersId = new List<int>();
            OffersDTO = new List<OfferDTO>();
            CompaniesDTO = new List<CompanyDTO>();
        }
    }
}