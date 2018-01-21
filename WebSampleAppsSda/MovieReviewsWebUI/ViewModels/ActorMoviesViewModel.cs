using MovieReviewsWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieReviewsWebUI.ViewModels
{
    public class ActorMoviesViewModel
    {
        public Actor Actor { get; set; }

        public Movie[] Movies { get; set; }

        public int[] SelectedMovies { get; set; }
        public MultiSelectList MoviesToSelect { get; set; }
    }
}