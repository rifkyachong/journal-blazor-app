using Microsoft.AspNetCore.Mvc;
using JournalApp.Shared;

namespace JournalApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalController : ControllerBase
    {
        public static List<Journal> journals = new List<Journal>
        {
            new Journal {Id = 1, Title= "Title 1", Content="Content 1"},
            new Journal {Id = 2, Title= "Title 2", Content="Content 2"},
            new Journal {Id = 3, Title= "Title 3", Content="Content 3"}
        };

        [HttpGet]
        public async Task<ActionResult<List<Journal>>> GetAllJournals()
        {
            return Ok(journals);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Journal>> GetJournal(int id)
        {
            var selected = journals.FirstOrDefault(journals => journals.Id == id);
            if (selected == null)
            {
                return NotFound($"No hero with an id:{id}");
            }
            return Ok(selected);
        }

        [HttpPost]
        public async Task<ActionResult<Journal>> PostJournal(Journal submitted)
        {
            journals.Add(submitted);
            return Ok(submitted);
        }
    }
}
