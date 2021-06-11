using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpleidingenProject.Models;

namespace OpleidingenProject.ViewModels.OpleidingViewModel
{
    public class CreateOpleidingCommand : EditOpleidingBase
    {
        public Opleiding ToOpleiding()
        {
            return new Opleiding()
            {
                Naam = Naam,
                Beschrijving = Beschrijving,
                CategorieId = GekozenCategoryId.Value,
                IsDeleted = false,
                AantalUren = AantalUren,
                Niveau = Niveau,
                Taal = Taal
             
            };
        }


    }
}
