using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_01.Pages
{
    public class TrombinoscopeModel : PageModel
    {
        public List<Student> Students { get; set; }

        public void OnGet()
        {
            Students = new List<Student>
            {
                new Student
                {
                    Firstname = "Andy",
                    Lastname = "Bianco",
                    Description = "Formateur"
                },
                new Student
                {
                    Firstname = "Sebastien",
                    Lastname = "Darge",
                    Description = "Etudiant"
                },
                new Student
                {
                    Firstname = "Leo",
                    Lastname = "Clarival",
                    Description = "Etudiant"
                },
                new Student
                {
                    Firstname = "Christophe",
                    Lastname = "Lacroix",
                    Description = "Etudiant"
                }
            };
        }
    }

    public class Student
    {
        public string Firstname { get; set; } = default!;
        public string Lastname { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
