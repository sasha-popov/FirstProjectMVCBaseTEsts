using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.Linq;
using System.Web;

namespace NLayerApp.WEB.Models.ModelsVM
{

    // [DataContract(IsReference =false)]
    //[Serializable]
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Offers = new List<OfferViewModel>();
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OfferViewModel> Offers { get; set; }


    }
}