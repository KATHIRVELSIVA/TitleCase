using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace TitleCase.Pages
{
    public class TitleCaseModel : PageModel
    {
        public void OnGet()
        {
        }


        //a letter taken as input
        [BindProperty]
        public string? input { get; set; }

        [BindProperty]
        public string? output { get; set; }


        //a post method will invoke when the form is submitted
        public void OnPost()
        {
            input = input;
            TestMe testme = new TestMe();
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