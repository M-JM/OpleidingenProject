using Microsoft.AspNetCore.Identity;
using OpleidingenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Data
{
    public class CustomUser : IdentityUser
    {

        public string Voornaam { get; set; }

        public string Achternaam { get; set; }
       
        public DateTime GeboorteDatum { get; set; }


        public ICollection<Inschrijving> Inschrijvingen { get; set; }

    }



}
