using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Initiation.Models
{
    public class FormModel
    {
        [Required]
        public string Nom {get;set;}
        [Required]
        [RegularExpression(@".*@.*", ErrorMessage = "Ce n'est pas une addresse email... fait un effort!")]
        public string Email {get;set;}
        [Required (ErrorMessage= "Qu'est-ce qui se passe... tu n'as rien à dire? Dans ce cas, pourquoi vouloir me contacter?")]
        public string Commentaire { get; set; }
    }
}