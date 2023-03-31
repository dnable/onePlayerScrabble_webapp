using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace OnePlayerScrabble.Pages
{
    public class NewGameModel : PageModel
    {
        public static char? PlayLetter0 { get; set; }
        public  static char? PlayLetter1 { get; set; }
        public static char? PlayLetter2 { get; set; }
        public static char? PlayLetter3 { get; set; }
        public static char? PlayLetter4 { get; set; }
        public static char? PlayLetter5 { get; set; }
        public static char? PlayLetter6 { get; set; }
        public static int CurrentPlayLetter { get; set; }

        public IDictionary<char, int> LetterPool = new Dictionary<char, int>()
                {
                    {'A', 9 }, {'B', 2 }, {'C', 2 }, {'D', 4 }, {'E', 12 }, {'F', 2 }, {'G', 3 },
                    {'H', 2 }, {'I', 9 }, {'J', 1 }, {'K', 1 }, {'L', 4 }, {'M', 2}, {'N', 6 },
                    {'O', 8 }, {'P', 2 }, {'Q', 1 }, {'R', 6 }, {'S', 4 }, {'T', 6 }, {'U', 4 },
                    {'V', 2 }, {'W', 2}, {'X', 1 }, {'Y', 2 }, {'Z', 1}

                };

        public static List<char> LetterBag { get; set; }

        public static List<char> LettersPlayable { get; set; }

        public void OnGet()
        {
            LetterBag = new List<char>();
            foreach (char a in LetterPool.Keys)
            {
                for (int i = 0; i < LetterPool[a]; i++)
                {
                    LetterBag.Add(a);
                };
            };

            LettersPlayable = new List<char>();
            Random random = new Random();
            for (int i = 0; i < 7; i++)
            {
                int num = random.Next(LetterBag.Count());
                LettersPlayable.Add(LetterBag[num]);
                LetterBag.Remove(LetterBag[num]);
            }

            CurrentPlayLetter = 0;
        }

        public void OnPostPlay(char letter)
        {
            switch (CurrentPlayLetter)
            {
                case 0:
                    PlayLetter0 = letter;
                    break;
                case 1:
                    PlayLetter1 = letter;
                    break;
                case 2:
                    PlayLetter2 = letter;
                    break;
                case 3:
                    PlayLetter3 = letter;
                    break;
                case 4:
                    PlayLetter4 = letter;
                    break;
                case 5:
                    PlayLetter5 = letter;
                    break;
                case 6:
                    PlayLetter6 = letter;
                    break;
            }
                        
            CurrentPlayLetter++;            
        }

        public void OnPostUnplay()
        {
            CurrentPlayLetter--;
            switch (CurrentPlayLetter)
            {
                case 0:
                    PlayLetter0 = ' ';
                    break;
                case 1:
                    PlayLetter1 = ' ';
                    break;
                case 2:
                    PlayLetter2 = ' ';
                    break;
                case 3:
                    PlayLetter3 = ' ';
                    break;
                case 4:
                    PlayLetter4 = ' ';
                    break;
                case 5:
                    PlayLetter5 = ' ';
                    break;
                case 6:
                    PlayLetter6 = ' ';
                    break;
            }
            
        }
    }
}
