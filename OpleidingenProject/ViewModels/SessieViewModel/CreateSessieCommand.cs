using OpleidingenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.ViewModels.SessieViewModel
{
    public class CreateSessieCommand : EditSessieBase
    {
        public Sessie ToSessie()
        {
            return new Sessie()
            {
                AantalPlaatsen = AantalPlaatsen,
                TypeLeerVorm = TypeLeerVorm,
                Prijs = Prijs,
                StartDatum = StartDatum,
                EindDatum = EindDatum,
                IsDeleted = false,
                OpleidingId = GekozenOpleidingId.Value

            };
        }


    }
}
