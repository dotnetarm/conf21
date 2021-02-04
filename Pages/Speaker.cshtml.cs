using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using conf21_razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace conf21_razor.Pages
{
    public class SpeakerModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public Speaker Speaker;

        public SpeakerModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet(string name)
        {
            string[] JsonText = System.IO.File.ReadAllLines(@"Data\speakers.json");
            List<Speaker> speakers = JsonSerializer.Deserialize<List<Speaker>>(String.Join(' ', JsonText));
            Speaker = speakers.Where(s => s.Name == name).FirstOrDefault();
            return Page();
        }
    }
}
