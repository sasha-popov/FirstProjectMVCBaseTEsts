using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.BLL.DTO
{
    public class CompanyDTO
    {

        public int CompanyId { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        //public string PhoneNumber { get; set; }

        public string UserId { get; set; }

        public virtual ICollection<CompanyOfferDTO> CompanyOffersDTO { get; set; }
        public CompanyDTO()
        {
            CompanyOffersDTO = new List<CompanyOfferDTO>();
        }

    }
}