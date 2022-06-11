using System.Net.Http.Json;
using JournalApp.Client.Model;
using JournalApp.Shared;

namespace JournalApp.Client.Services.JournalService
{
    public class JournalService : IJournalService
    {
        private readonly HttpClient _http;

        public JournalService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Journal>> GetAllJournals()
        {
            var result = await _http.GetFromJsonAsync<List<Journal>>("api/journal");
            return result;
        }

        public async Task<Journal> GetJournalById(int id)
        {
            var result = await _http.GetFromJsonAsync<Journal>($"api/journal/{id}");
            return result;
        }

        public async Task PostJournal(JournalDisplay posted)
        {
            var submitted = new Journal()
            {
                Title = posted.Title,
                Content = posted.Content
            };

            await _http.PostAsJsonAsync<Journal>($"api/journal", submitted);
        } 
    }
}
