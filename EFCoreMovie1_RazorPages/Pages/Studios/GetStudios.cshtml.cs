﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EFCoreMovie1_RazorPages.Models;

namespace EFCoreMovie1_RazorPages.Pages.Studios
{
    public class GetStudiosModel : PageModel
    {
        public string FilterCriteria { get; set; }
       
        
        // Please Uncomment the code below

       private MovieDB2Context context;
        public GetStudiosModel(MovieDB2Context service)
        {
            context = service;
        }
        public IEnumerable<Studio> Studios { get; set; } = new List<Studio>();
        public void OnGet()
        {
            Studios = context.Studios;
        }

    }
}