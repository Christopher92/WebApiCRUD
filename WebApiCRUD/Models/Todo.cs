using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCRUD.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

    }
}
