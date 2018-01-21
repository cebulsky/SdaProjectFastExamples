using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewsWebUI.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }
    }
}