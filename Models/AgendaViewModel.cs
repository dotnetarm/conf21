using System.Collections.Generic;

namespace conf21_razor.Models
{
    public class AgendaViewModel
    {
        public string startTime { get; set; }
        public string topic { get; set; }
        public string Record { get; set; }
        public string Presentation { get; set; }
        public List<string> speakers { get; set; }
    }
}