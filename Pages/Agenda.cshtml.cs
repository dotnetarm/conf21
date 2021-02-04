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
    public class AgendaModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<AgendaViewModel> agenda;

        public AgendaModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            string[] JsonText = System.IO.File.ReadAllLines(@"Data\confs.json");
            agenda = JsonSerializer.Deserialize<List<AgendaViewModel>>(String.Join(' ', JsonText));
        }

        public void OnGet()
        {

        }
    }
}
