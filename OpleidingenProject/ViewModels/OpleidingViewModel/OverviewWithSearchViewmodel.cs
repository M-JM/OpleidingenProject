using Microsoft.AspNetCore.Mvc.Rendering;
using OpleidingenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.ViewModels.OpleidingViewModel
{
    public class OverviewWithSearchViewmodel
    {
        public IEnumerable<Opleiding> Opleidingen { get; set; }
       
        public IEnumerable<Categorie> Categorieen { get; set; }

        public int? GekozenCategoryId { get; set; }

        public string SearchString { get; set; }

        public int? GekozenTaal { get; set; }

        public int? GekozenNiveau { get; set; }



    }
}
