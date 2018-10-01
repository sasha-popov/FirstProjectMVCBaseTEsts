using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.WEB.Models.ModelsVM
{
    [Serializable]
    public class OfferViewModel
    {
        [Key]
        public int OfferId { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }

        public int? CategoryId { get; set; }
        public virtual CategoryViewModel Category { get; set; }

        //[JsonIgnore]
        //public virtual CategoryViewModel Category { get; set; }
        //[JsonIgnore]
        //public virtual ICollection<Executer> Executers { get; set; }
        //[JsonIgnore]
        //public virtual ICollection<CustomerOffer> CustomerOffers { get; set; }
        //[JsonIgnore]
        //public virtual ICollection<CompanyOfferViewModel> CompanyOffers { get; set; }


        public OfferViewModel()
        {
            //Executers = new List<Executer>();
            //CustomerOffers = new List<CustomerOffer>();
            //CompanyOffers = new List<CompanyOfferViewModel>();

        }

    }
}