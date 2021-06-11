using OpleidingenProject.Models;
using System.Collections.Generic;

namespace OpleidingenProject.Services
{
    public interface IInschrijvingService
    {
        IEnumerable<Inschrijving> AllInschrijvingen();
        void CreateInschrijving(Inschrijving inschrijving);
        bool DeleteInschrijving(int id);
        IEnumerable<Inschrijving> InschrijvingBySessie(int sessieId);
        IEnumerable<Inschrijving> InschrijvingByUserId(string userId);
    }
}