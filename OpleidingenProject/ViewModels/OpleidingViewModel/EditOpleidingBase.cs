using Microsoft.AspNetCore.Http;
using OpleidingenProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.ViewModels.OpleidingViewModel
{
    public class EditOpleidingBase
    {
        [Display(Name = "Opleiding naam")]
        [Required(ErrorMessage = "Een opleidingsnaam is verplicht")]
        public string Naam { get; set; }

        [Required(ErrorMessage = "Een Beschrijving is verplicht")]
        public string Beschrijving { get; set; }
        [Required(ErrorMessage = "Niveau indicatie is een vereiste")]
        public NiveauOpleiding Niveau { get; set; }

        [Display(Name = "Opleidingstaal")]
        [Required(ErrorMessage = "Gelieve een opleidingstaal te selecteren")]
        public Talen Taal { get; set; }


        [Display(Name = "Aantal Uren")]
        [Required(ErrorMessage = "Gelieve het aantal les uren op te geven")]
        [Range(1, int.MaxValue, ErrorMessage = "Minstens één uur les is vereist")]
        public int AantalUren { get; set; }

        public bool IsDeleted { get; set; }
 
        [Display(Name = "Categorie")]
        [Required(ErrorMessage = "Gelieve een categorie te selecteren")]
        public int? GekozenCategoryId { get; set; }

        public IEnumerable<Categorie> Categorieen { get; set; }



    }
}
