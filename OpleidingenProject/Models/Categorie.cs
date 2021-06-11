using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Models
{
    public class Categorie
    {

        #region Properties

        public int Id { get; set; }

        public string Naam { get; set; }

        public bool IsDeleted { get; set; }

        #endregion


        #region Constructor

        public Categorie()
        {

        }

        public Categorie(int id, string naam, bool isDeleted)
        {
            Id = id;
            Naam = naam;
            IsDeleted = isDeleted;
        }
        #endregion


        #region Methods

        #endregion


    }
}
