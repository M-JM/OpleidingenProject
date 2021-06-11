using OpleidingenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.ViewModels.OpleidingViewModel
{
    public class UpdateOpleidingCommand : EditOpleidingBase
    {
        public int Id { get; set; }

        public UpdateOpleidingCommand()
        {

        }
        public UpdateOpleidingCommand(Opleiding opleiding)
        {
            Naam = opleiding.Naam;
            Beschrijving = opleiding.Beschrijving;
            GekozenCategoryId = opleiding.CategorieId;
            AantalUren = opleiding.AantalUren;
            Niveau = opleiding.Niveau;
            Taal = opleiding.Taal;
  
        }

        public void UpdateOpleiding(Opleiding opleiding)
        {
            opleiding.Naam = Naam;
            opleiding.Beschrijving = Beschrijving;
            opleiding.CategorieId = GekozenCategoryId.Value;
            opleiding.AantalUren = AantalUren;
            opleiding.Niveau = Niveau;
            opleiding.Taal = Taal;
    
        }


    }
}
