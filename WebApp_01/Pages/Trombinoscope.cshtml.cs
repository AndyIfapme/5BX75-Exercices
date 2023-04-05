using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_01.Pages
{
    public class TrombinoscopeModel : PageModel
    {
        public List<Student> Students { get; set; }

        public void OnGet()
        {
            Students = new List<Student>()
            {
                new Student()
                {
                    Firstname = "MEDHI",
                    Lastname = "BAUWENS",
                    Description = "Apprenant"
                },
                new Student()
                {
                    Firstname = "GWENDOLINE",
                    Lastname = "BLOTIAU",
                    Description = "Apprenant"
                },
                new Student()
                {
                    Firstname = "ERWAN",
                    Lastname = "BOUGARD",
                    Description = "Apprenant"
                },
                new Student()
                {
                    Firstname = "LÉO",
                    Lastname = "CLARINVAL",
                    Description = "Apprenant"
                }
            };
        }
    }

    public class Student
    {
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }

        public required string Description { get; set; }
    }
}
