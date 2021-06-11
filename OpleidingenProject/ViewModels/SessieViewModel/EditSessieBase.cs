using OpleidingenProject.Models;
using OpleidingenProject.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.ViewModels.SessieViewModel
{
    public class EditSessieBase
    {

        [Display(Name = "Aantal Plaatsen")]
        [Required(ErrorMessage = "Gelieve het aantal plaatsen op te geven")]
        [Range(1, int.MaxValue, ErrorMessage = "Minstens één plaats is vereist")]
        public int AantalPlaatsen { get; set; }

        [Display(Name = "Leer Vorm")]
        [Required(ErrorMessage = "Gelieve een leer vorm te selecteren")]
        public LeerVorm TypeLeerVorm { get; set; }

        [Required(ErrorMessage = "Gelieve de kostprijs op te geven")]
        [Range(1, int.MaxValue, ErrorMessage = "Prijs moet min. 1€ zijn")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public int Prijs { get; set; }

        [DateValidation]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime StartDatum { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime EindDatum { get; set; }

        public bool IsDeleted { get; set; }

        [Display(Name = "Opleiding")]
        [Required(ErrorMessage = "Gelieve een opleiding te selecteren waarvoor je een sessie wilt aanmaken")]
        public int? GekozenOpleidingId { get; set; }

        public IEnumerable<Opleiding> Opleidingen { get; set; }

    }
}
