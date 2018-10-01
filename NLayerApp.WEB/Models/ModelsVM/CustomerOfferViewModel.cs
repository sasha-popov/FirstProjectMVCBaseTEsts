using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.WEB.Models.ModelsVM
{
    public class CustomerOfferViewModel
    {
        public int CustomerOfferId { get; set; }
        public DateTime Time { get; set; }
        public decimal Price { get; set; }

        public int? CustomerId { get; set; }
        //public virtual CustomerViewModel Customer { get; set; }
        public string UserId { get; set; }

        public int? OfferId { get; set; }
       // public virtual Offer Offer { get; set; }

        public string Content { get; set; }

    }
}
