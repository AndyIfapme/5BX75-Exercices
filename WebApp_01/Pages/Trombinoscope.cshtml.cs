using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_01.Pages
{
    public class TrombinoscopeModel : PageModel
    {
        public Student Student { get; set; }

        public void OnGet()
        {
            Student = new Student()
            {
                Firstname = "Andy",
                Lastname = "Bianco",
                Description = "Formateur"
            };
        }
    }

    public class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Description { get; set; }
    }
}
