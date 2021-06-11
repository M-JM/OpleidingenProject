using Microsoft.EntityFrameworkCore;
using OpleidingenProject.Data;
using OpleidingenProject.Models;
using OpleidingenProject.ViewModels.SessieViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Services
{
    public class SessieService : ISessieService
    {
        private readonly ApplicationDbContext _context;

        public SessieService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Sessie> AlleSessiesVanOpleiding(int id)
        {
            return _context.Sessies.Include(x => x.Opleiding).Where(x => x.OpleidingId == id).ToList();
        }

        public IEnumerable<Sessie> AlleSessies()
        {
            return _context.Sessies.Include(x => x.Opleiding).ToList();
        }

        public Sessie SessieById(int id)
        {
            return _context.Sessies.Include(x => x.Opleiding).Where(x => x.Id == id).FirstOrDefault();
        }

        public UpdateSessieCommand GetSessieForUpdate(int id)
        {
            Sessie sessie = _context.Sessies.Include(x => x.Opleiding).Where(x => x.Id == id).FirstOrDefault();
            if (sessie == null)
            {
                return null;
            }
            return new UpdateSessieCommand(sessie);
        }

        public void UpdateSessie(UpdateSessieCommand cmd)
        {
            {
                Sessie ToEdit = _context.Sessies.Find(cmd.Id);

                if (ToEdit != null)
                {
                    cmd.UpdateSessie(ToEdit);
                    _context.SaveChanges();

                }
            }




        }

        public int CreateSessie(CreateSessieCommand cmd)
        {
            Sessie sessie = cmd.ToSessie();
            _context.Sessies.Add(sessie);

            _context.SaveChanges();

            return sessie.Id;
        }

        public bool DeleteSessie(int id)
        {
            Sessie toDelete = _context.Sessies.Find(id);
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
