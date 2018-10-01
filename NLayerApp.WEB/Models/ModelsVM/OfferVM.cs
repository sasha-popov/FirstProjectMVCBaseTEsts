using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLayerApp.WEB.Models.ModelsVM
{
    public class OfferVM
    {
        public int OfferId { get; set; }
        public string Name { get; set; }

        public int? CategoryId { get; set; }
        public virtual CategoryViewModel Category { get; set; }
        public bool Selected { get; set; }
    }
}