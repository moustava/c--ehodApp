﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;

namespace EhodBoutiqueEnLigne.Models.ViewModels
{
    public class OrderViewModel
    {


        [BindNever]
        public int OrderId { get; set; }

        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        
       [Required(ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.Order) , ErrorMessageResourceName = "ErrorMissingName")]
        public string Name { get; set; }

        
       [Required(ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.Order) , ErrorMessageResourceName = "ErrorMissingAddress")]
        public string Address { get; set; }

        
       [Required(ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.Order) , ErrorMessageResourceName = "ErrorMissingCity")]
        public string City { get; set; }

        
       [Required(ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.Order) , ErrorMessageResourceName = "ErrorMissingZipCode")]
        public string Zip { get; set; }

        
       [Required(ErrorMessageResourceType = typeof(EhodVenteEnLigne.Resources.Models.Order) , ErrorMessageResourceName = "ErrorMissingCountry")]
        public string Country { get; set; }

        [BindNever]
        public DateTime Date { get; set; }
    }
}
