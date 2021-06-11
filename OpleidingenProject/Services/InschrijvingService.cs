using OpleidingenProject.Data;
using OpleidingenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Services
{
    public class InschrijvingService : IInschrijvingService
    {
        private readonly ApplicationDbContext _context;

        public InschrijvingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Inschrijving> AllInschrijvingen()
        {
            return _context.Inschrijvingen.ToList();
        }

        public IEnumerable<Inschrijving> InschrijvingByUserId(string userId)
        {
            return _context.Inschrijvingen.Where(x => x.CustomUserId == userId).ToList();
        }

        public IEnumerable<Inschrijving> InschrijvingBySessie(int sessieId)
        {
            return _context.Inschrijvingen.Where(x => x.SessieId == sessieId).ToList();
        }

        public void CreateInschrijving(Inschrijving inschrijving)
        {

            _context.Inschrijvingen.Add(inschrijving);

            _context.SaveChanges();

        }

        public bool DeleteInschrijving(int id)
        {
            Inschrijving toDelete = _context.Inschrijvingen.Find(id);
            if (toDelete == null)
            {
                return false;
            }

            toDelete.IsDeleted = true;

            _context.SaveChanges();

            return true;
        }

    }
}
