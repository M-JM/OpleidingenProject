using OpleidingenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.ViewModels.SessieViewModel
{
    public class SessieDetailViewModel
    {

        public int Id { get; set; }

        public int AantalPlaatsen { get; set; }

        public int Prijs { get; set; }

        public int NogBeschikbarePlaatsen { get; set; }

        public LeerVorm TypeLeerVorm { get; set; }

        public DateTime StartDatum { get; set; }

        public DateTime EindDatum { get; set; }



    }
}
