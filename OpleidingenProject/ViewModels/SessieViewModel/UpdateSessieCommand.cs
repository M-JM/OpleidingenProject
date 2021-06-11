using OpleidingenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.ViewModels.SessieViewModel
{
    public class UpdateSessieCommand : EditSessieBase
    {
        public int Id { get; set; }

        public UpdateSessieCommand()
        {

        }

        public UpdateSessieCommand(Sessie sessie)
        {
            AantalPlaatsen = sessie.AantalPlaatsen;
            TypeLeerVorm = sessie.TypeLeerVorm;
            Prijs = sessie.Prijs;
            StartDatum = sessie.StartDatum;
            EindDatum = sessie.EindDatum;
            GekozenOpleidingId = sessie.OpleidingId;
        }

        public void UpdateSessie(Sessie sessie)
        {
            sessie.AantalPlaatsen = AantalPlaatsen;
            sessie.TypeLeerVorm = TypeLeerVorm;
            sessie.Prijs = Prijs;
            sessie.StartDatum = StartDatum;
            sessie.EindDatum = EindDatum;
            sessie.OpleidingId = GekozenOpleidingId.Value;
        }


    }
}
