using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Models
{
    public class Sessie
    {
      

        #region Properties

        public int Id { get; set; }

        public int AantalPlaatsen { get; set; }

        public LeerVorm TypeLeerVorm { get; set; }

        public int Prijs { get; set; }

        public DateTime StartDatum { get; set; }

        public DateTime EindDatum { get; set; }

        public bool IsDeleted { get; set; }

        public int OpleidingId { get; set; }

        public Opleiding Opleiding { get; set; }

        public ICollection<Inschrijving> Inschrijvingen { get; set; }

        #endregion

        #region Constructor

        public Sessie()
        {
        }

        public Sessie(int id, int aantalPlaatsen, LeerVorm typeLeerVorm, int prijs, DateTime startDatum, DateTime eindDatum, bool isDeleted, int opleidingId)
        {
            Id = id;
            AantalPlaatsen = aantalPlaatsen;
            TypeLeerVorm = typeLeerVorm;
            Prijs = prijs;
            StartDatum = startDatum;
            EindDatum = eindDatum;
            IsDeleted = isDeleted;
            OpleidingId = opleidingId;
        }


        #endregion


        #region Methods

        public bool Beschikbaar()
        {
           int aantalInschrijving = 0;
            if(Inschrijvingen != null)
            {
                foreach (Inschrijving item in Inschrijvingen)
                {
                    aantalInschrijving += 1;
                }
            }
           
            return aantalInschrijving < AantalPlaatsen;
        }

        public int NogBeschikbarePlaatsen()
        {
            int aantalInschrijving = AantalPlaatsen;
            if (Inschrijvingen != null)
            {
                foreach (Inschrijving item in Inschrijvingen)
                {
                    aantalInschrijving -= 1;
                }
            }

            return aantalInschrijving;
        }

        #endregion



    }

    public enum LeerVorm
    {
        Klassikaal,
        [Display(Name = "Afstand Onderwijs")]
        Afstandsonderwijs,
        Online,
        [Display(Name = "Blended Learning")]
        BlendedLearning
    }

}
