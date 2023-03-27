using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnePlayerScrabble.Pages
{
    public class NewGameModel : PageModel
    {
        public string? PlayLetter1 { get; set; }
        public string? PlayLetter2 { get; set; }

        public void OnGet()
        {
            PlayLetter1 = string.Empty;
            PlayLetter2 = string.Empty;
        }        
    }
}
