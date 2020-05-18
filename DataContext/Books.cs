using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13.DataContext
{
    public class Books
    {
        public int Id { get; set; }

        public int PublishedYear { get; set; }

       
        public string Name { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedOn {get; set;}

        public DateTime? UpdatedOn { get; set; }
    }
}
