using JournalApp.Client.Model;
using JournalApp.Shared;

namespace JournalApp.Client.Services.JournalService
{
    public interface IJournalService
    {
        Task<List<Journal>> GetAllJournals();
        Task<Journal> GetJournalById(int id);

        Task PostJournal(JournalDisplay submitted);
    }
}