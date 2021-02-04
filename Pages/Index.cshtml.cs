using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace conf21_razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public int days { get; set; }
        public int hours { get; set; }
        public int minutes { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            DateTime eventDay = new DateTime(2021, 1, 30, 11, 0, 0, DateTimeKind.Utc);
            days = (eventDay - DateTime.Now).Days;
            hours = (eventDay - DateTime.Now).Hours;
            minutes = (eventDay - DateTime.Now).Minutes;
        }

        public void OnGet()
        {

        }
    }
}
