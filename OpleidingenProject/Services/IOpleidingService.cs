using OpleidingenProject.Models;
using OpleidingenProject.ViewModels.OpleidingViewModel;
using System.Collections.Generic;

namespace OpleidingenProject.Services
{
    public interface IOpleidingService
    {
        IEnumerable<Categorie> AllCategories();
        IEnumerable<Opleiding> AllOpleidingen();
        int CreateOpleiding(CreateOpleidingCommand cmd);
        bool DeleteOpleiding(int id);
        UpdateOpleidingCommand GetOpleidingForUpdate(int id);
        Opleiding OpleidingById(int id);
        void updateOpleiding(UpdateOpleidingCommand cmd);
    }
}