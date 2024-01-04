using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LinkProfiles.Pages
{
    public class IndexModel : ProfileBasePageModel
    {
        [BindProperty]
        public bool Extended { get; set; }
        public void OnGet()
        {
            ViewData["background-reference"] = "main-area-soren";
            Name = "Søren Kamp Fuglsang";

            Extended = Request.Query.Any(x => x.Key.ToLower() == "extend" || x.Key.ToLower() == "e");
             
            LinkButtons.AddRange(
                [
                    new LinkButton("LinkedIn", "https://linkedin.com/in/srenfuglsang", "soren-generic", LinkButtonType.GenericLayer1) { IconReference = "linkedin-round-black" },
                    new LinkButton("GitHub", "https://github.com/fglsng", "soren-generic", LinkButtonType.GenericLayer1) { IconReference = "github-round-black" },
                    new LinkButton("Nuget", "https://nuget.org/profiles/fglsng", "soren-generic", LinkButtonType.GenericLayer1) { IconReference = "microsoft-block-color" },
                    //new LinkButton("MemZen (Beta)", "https://memzen.eu/", "soren-generic", LinkButtonType.GenericLayer2) { ToolTipText = "A site to help quizzing / learning. Currently in Beta. Has active users." },
                    //new LinkButton("Link Profiles", "https://sk.fglsng.dk/", "soren-generic", LinkButtonType.GenericLayer2) { ToolTipText = "A private site intended to easily forward the visitor to relevant sites (just redirects to this site)" },
                    new LinkButton("Projects", "/projects", "soren-generic", LinkButtonType.GenericLayer1),
                ]);
        }
    }
}
