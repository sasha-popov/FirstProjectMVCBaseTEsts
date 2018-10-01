//using Newtonsoft.Json;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.DAL.Entities
{
    [Serializable]
    public class Offer
    {
        [Key]
        public int OfferId { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }

        public int? CategoryId { get; set; }
        //[JsonIgnore]
        [IgnoreMap]
        public virtual Category Category { get; set; }
        //  [JsonIgnore]
        [IgnoreMap]
        public virtual ICollection<Executer> Executers { get; set; }
        // [JsonIgnore]
        [IgnoreMap]
        public virtual ICollection<CustomerOffer> CustomerOffers { get; set; }
        //  [JsonIgnore]
        public virtual ICollection<CompanyOffer> CompanyOffers { get; set; }


        public Offer()
        {

            Executers = new List<Executer>();
            CustomerOffers = new List<CustomerOffer>();
            CompanyOffers = new List<CompanyOffer>();

        }

    }
}