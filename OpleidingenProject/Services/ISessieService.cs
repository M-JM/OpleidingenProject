using OpleidingenProject.Models;
using OpleidingenProject.ViewModels.SessieViewModel;
using System.Collections.Generic;

namespace OpleidingenProject.Services
{
    public interface ISessieService
    {
        IEnumerable<Sessie> AlleSessies();
        IEnumerable<Sessie> AlleSessiesVanOpleiding(int id);
        int CreateSessie(CreateSessieCommand cmd);
        bool DeleteSessie(int id);
        UpdateSessieCommand GetSessieForUpdate(int id);
        Sessie SessieById(int id);
        void UpdateSessie(UpdateSessieCommand cmd);
    }
}