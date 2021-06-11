using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Models
{
    public class Opleiding
    {
      

        #region Properties

        public int Id { get; set; }

        public string Naam { get; set; }

        public string Beschrijving { get; set; }

        public NiveauOpleiding Niveau { get; set; }

        public Talen Taal { get; set; }

        public int AantalUren { get; set; }

        public bool IsDeleted { get; set; }

        public int CategorieId { get; set; }

        public Categorie Categorie { get; set; }

        public ICollection<Sessie> Sessies { get; set; }


        #endregion

        #region Constructor

        public Opleiding()
        {

        }

        public Opleiding(int id, string naam, string beschrijving, NiveauOpleiding niveau, Talen taal, int aantalUren, bool isDeleted, int categorieId)
        {
            Id = id;
            Naam = naam;
            Beschrijving = beschrijving;
            Niveau = niveau;
            Taal = taal;
            AantalUren = aantalUren;
            IsDeleted = isDeleted;
            CategorieId = categorieId;
        
        }

        #endregion


        #region Methods

        #endregion

    }

    public enum NiveauOpleiding
    {
        Beginner,
        Intermediair,
        Gevorderd
    }

    public enum Talen
    {
        Engels,
        Nederlands,
        Frans
    }

}
