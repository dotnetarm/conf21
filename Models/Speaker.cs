using System;
using System.Collections.Generic;
using System.Text.Json;

namespace conf21_razor.Models
{
    public class Speaker
    {
        public string Name { get; set; }
        public string Possition { get; set; }
        public string Company { get; set; }
        public int Experience { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
    }
}