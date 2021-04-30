using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAPI.Models
{
    public class TodoItem
    {
        public long id { get; set; }
        public string Name { get; set; }

        public bool IsComplet { get; set; }
    }
}
