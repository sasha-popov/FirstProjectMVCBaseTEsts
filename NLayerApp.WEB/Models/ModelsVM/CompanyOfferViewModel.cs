using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.WEB.Models.ModelsVM
{
    public class CompanyOfferViewModel
    {
        [Key]
        public int CompanyOfferId { get; set; }

        public virtual ICollection<OfferViewModel> Offers { get; set; }

        public string UserId { get; set; }
        public List<int> OffersId { get; set; }

        public virtual ICollection<CompanyViewModel> Companies { get; set; }

        public int Duration { get; set; }

        public int Price { get; set; }

        public CompanyOfferViewModel()
        {
            OffersId = new List<int>();
            Offers = new List<OfferViewModel>();
            Companies = new List<CompanyViewModel>();
        }
    }
}