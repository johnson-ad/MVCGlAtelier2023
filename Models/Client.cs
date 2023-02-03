using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //pour les anotations
using System.ComponentModel.DataAnnotations.Schema; //pour les anotaions du model de la data base

namespace MVCGlAtelier2023.Models
{
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] // DatabaseGeneratedOption a none permet de desactiver l'auto-incremmente
        public int IdPers { get; set; }

        [Display(Name ="Sexe"), Required(ErrorMessage ="*"), MaxLength(10,ErrorMessage ="Taile maximale 10")]
        public string Sexe { get; set; }

        [Display(Name ="Statut inscription")]
        public bool StatutInscription { get; set; }

        [Display(Name = "Statut")]
        public bool Statut { get; set; }
    }

    public class ClientViewModel
    {
        [Key]
        public int IdPers { get; set; }

        [Display(Name = "Sexe"), Required(ErrorMessage = "*"), MaxLength(10, ErrorMessage = "Taile maximale 10")]
        public string Sexe { get; set; }

        [Display(Name = "Nom"), MaxLength(80, ErrorMessage = "Taile maximale 80"), Required(ErrorMessage = "*")]
        public string NomPers { get; set; }

        [Display(Name = "Prenom"), MaxLength(80, ErrorMessage = "Taile maximale 80"), Required(ErrorMessage = "*")]
        public string PrenomPers { get; set; }

        [Display(Name = "Adresse"), MaxLength(150, ErrorMessage = "Taile maximale 150")]
        public string AdressePers { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email"), MaxLength(80, ErrorMessage = "Taile maximale 80"), Required(ErrorMessage = "*")]
        public string EmailPers { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telephone"), MaxLength(20, ErrorMessage = "Taile maximale 20"), Required(ErrorMessage = "*")]
        public string TelPers { get; set; }
    }
}