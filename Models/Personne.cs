using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations; //pour les anotations
using System.ComponentModel.DataAnnotations.Schema; //pour les anotaions du model de la data base
using System.ComponentModel;

namespace MVCGlAtelier2023.Models
{
    public class Personne
    {
        [Key]
        public int IdPers { get; set; }

        [Display(Name = "Nom"), MaxLength(80, ErrorMessage = "Taile maximale 80"), Required(ErrorMessage = "*")]
        public string NomPers { get; set; }

        [Display(Name = "Prenom"), MaxLength(80, ErrorMessage = "Taile maximale 80"), Required(ErrorMessage = "*")]
        public string PrenomPers { get; set; }

        [Display(Name = "Adresse"), MaxLength(150, ErrorMessage = "Taile maximale 150")]
        public string AdressePers { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email"), MaxLength(80, ErrorMessage = "Taile maximale 80"), Required(ErrorMessage = "*")]
        public string EmailPers { get; set; }
    }
}