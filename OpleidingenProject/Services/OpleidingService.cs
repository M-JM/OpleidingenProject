using Microsoft.EntityFrameworkCore;
using OpleidingenProject.Data;
using OpleidingenProject.Models;
using OpleidingenProject.ViewModels.OpleidingViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpleidingenProject.Services
{
    public class OpleidingService : IOpleidingService
    {
        private readonly ApplicationDbContext _context;


        public OpleidingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categorie> AllCategories()
        {
            return _context.Categorieen.ToList();
        }

        public IEnumerable<Opleiding> AllOpleidingen()
        {
            return _context.Opleidingen.Include(x => x.Categorie).ToList();
        }

        public Opleiding OpleidingById(int id)
        {
            return _context.Opleidingen.Include(x=>x.Categorie).Include(x=>x.Sessies).ThenInclude(x=>x.Inschrijvingen).Where(x => x.Id == id).FirstOrDefault();
        }

        public UpdateOpleidingCommand GetOpleidingForUpdate(int id)
        {
            Opleiding opleiding = _context.Opleidingen.Include(x => x.Categorie).Where(x => x.Id == id).FirstOrDefault();
            if (opleiding == null)
            {
                return null;
            }
            return new UpdateOpleidingCommand(opleiding);
        }

        public void updateOpleiding(UpdateOpleidingCommand cmd)
        {
            Opleiding ToEdit = _context.Opleidingen.Find(cmd.Id);

            if (ToEdit != null)
            {
                cmd.UpdateOpleiding(ToEdit);
                _context.SaveChanges();

            }
        }


        public int CreateOpleiding(CreateOpleidingCommand cmd)
        {
            Opleiding opleiding = cmd.ToOpleiding();
            _context.Opleidingen.Add(opleiding);

            _context.SaveChanges();

            return opleiding.Id;
        }

        public bool DeleteOpleiding(int id)
        {
            Opleiding toDelete = _context.Opleidingen.Find(id);
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
