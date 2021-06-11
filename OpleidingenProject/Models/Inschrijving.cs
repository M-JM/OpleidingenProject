using OpleidingenProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Models
{
    public class Inschrijving
    {

        #region Properties

        public int Id { get; set; }

        public int SessieId { get; set; }

        public Sessie Sessie { get; set; }

        public string CustomUserId { get; set; }

        public CustomUser CustomUser { get; set; }

        public bool IsDeleted { get; set; }

        #endregion

        #region Constructor

        #endregion


        #region Methods

        #endregion

    }
}
