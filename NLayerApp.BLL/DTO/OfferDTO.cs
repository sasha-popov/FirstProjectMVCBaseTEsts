//using Newtonsoft.Json;
using AutoMapper;
using NLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.BLL.DTO
{

    public class OfferDTO
    {

        public int OfferId { get; set; }

        public string Name { get; set; }

        public int? CategoryId { get; set; }
        public virtual CategoryDTO Category { get; set; }

        //  [JsonIgnore]
        // [IgnoreMap]
        public virtual ICollection<ExecuterDTO> Executers { get; set; }
        // [JsonIgnore]
        //[IgnoreMap]
        public virtual ICollection<CustomerOfferDTO> CustomerOffers { get; set; }
        //  [JsonIgnore]
        //[IgnoreMap]
        public virtual ICollection<CompanyOfferDTO> CompanyOffers { get; set; }

        public OfferDTO()
        {
            Executers = new List<ExecuterDTO>();
            CustomerOffers = new List<CustomerOfferDTO>();
            CompanyOffers = new List<CompanyOfferDTO>();
        }

    }
}