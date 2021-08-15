using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorComponentsComparison.Pages.Shared
{
    public class _PartialPureJsModel : PageModel
    {
     
        public string Data { get; set; }
        public string style { get; set; }
        public void OnGet()
        {
        }        
    }
}
