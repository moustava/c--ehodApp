using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EhodBoutiqueEnLigne.Models.ViewModels
{
    public class ProductViewModel
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.Product) , ErrorMessageResourceName = "ErrorMissingName")]
        public string Name { get; set; }

        public string Description { get; set; }
        
        public string Details { get; set; }

        [Required(ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.Product) , ErrorMessageResourceName = "ErrorMissingStock")]
        [Range(1, int.MaxValue, ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.Product), ErrorMessageResourceName = "ErrorStockValue")]
        public string Stock { get; set; }

        [Required(ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.Product) , ErrorMessageResourceName = "ErrorMissingPrice")]
        [Range(0.01, double.MaxValue, ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.Product), ErrorMessageResourceName = "ErrorPriceValue")]
        public string Price { get; set; }
    }
}
