using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewsWebUI.Models
{
    public class Actor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}