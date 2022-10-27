using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EFCoreMovie1_RazorPages.Models;

namespace EFCoreMovie1_RazorPages
{
    public class GetMoviesModel : PageModel
    {
        public string FilterCriteria { get; set; }

        private MovieDB2Context context;
        public GetMoviesModel(MovieDB2Context service)
        {
            context = service;
        }
        public IEnumerable<Movie> Movies { get; set; } = new List<Movie>();
        public void OnGet()
        {
            Movies = context.Movies;
        }
    }
}