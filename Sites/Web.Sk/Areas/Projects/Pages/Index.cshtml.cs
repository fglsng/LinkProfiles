using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Sk.Areas.Projects.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            ViewData["background-reference"] = "main-area-soren";

        }
    }
}
