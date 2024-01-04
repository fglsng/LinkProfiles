using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Sk.Areas.Details.Pages
{
    public class CVModel : PageModel
    {
        public List<CvEntry> CvEntries { get; set; } = new List<CvEntry>();

        public void OnGet()
        {
            ViewData["background-reference"] = "main-area-soren";
        }
    }
}
