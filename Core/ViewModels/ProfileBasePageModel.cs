using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Core.ViewModels
{
    public abstract class ProfileBasePageModel : PageModel
    {
        public string? Name { get; set; }
        public string? DescriptionLine1 { get; set; }
        public string? DescriptionLine2 { get; set; }

        [BindProperty]
        public List<LinkButton> LinkButtons { get; set; } = new List<LinkButton>();
    }
}
