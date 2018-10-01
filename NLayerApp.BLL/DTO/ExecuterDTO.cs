using NLayerApp.BLL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.DAL.Entities
{
    public class ExecuterDTO
    {
        public int ExecuterId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        public int? CompanyId { get; set; }
        public virtual CompanyDTO Company { get; set; }

        public int? OfferId { get; set; }
        public virtual OfferDTO Offer { get; set; }

    }
}