using System.ComponentModel.DataAnnotations;

namespace JournalApp.Client.Model
{
    public class JournalDisplay
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(8000)]
        public string Content { get; set; } = string.Empty;
    }
}
