using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace TitleCase.Pages
{
    public class TitleCaseModel : PageModel
    {

        //a letter taken as input
        [BindProperty]
        public string? input { get; set; }

        [BindProperty]
        public string? output { get; set; }


        //a post method will invoke when the form is submitted
        public void OnPost(string input)
        {
            TestMe testme = new();
            string title = testme.makeTitle(input);
            output = title;
        }

    }
    public class TestMe
    {
        public string makeTitle(string input)
        {
            //Code to convert a text into title case, eg ...input -> hello world, output ->Hello World  
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string output = textInfo.ToTitleCase(input);
            Console.WriteLine(output);
            return output;
        }
    }
}