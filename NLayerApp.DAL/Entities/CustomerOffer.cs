using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerApp.DAL.Entities
{
    //[Serializable]
    public class CustomerOffer
    {
        [Key]
        public int CustomerOfferId { get; set; }
        public DateTime Time { get; set; }
        public decimal Price { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int? OfferId { get; set; }
        public virtual Offer Offer { get; set; }

        public string Content { get; set; }

    }
}
