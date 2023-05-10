using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Database.Domain.Contacts;
using Database.Infrastucture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Database.App.Pages;

public class ContactModel : PageModel
{
    private readonly DataContext _dataContext;

    [BindProperty]
    public ContactView Contact { get; set; }

    public ContactModel(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        if (ModelState.IsValid)
        {
            _dataContext.Set<Contact>()
                .Add(new Contact
                {
                    Subject = Contact.Subject,
                    Email = Contact.Email,
                    Message = Contact.Message
                });

            _dataContext.SaveChanges();

            //var path = "contacts.json";
            //var contacts = new List<ContactView>();

            //if (System.IO.File.Exists(path))
            //{
            //    var json = System.IO.File.ReadAllText(path);
            //    contacts = JsonSerializer.Deserialize<List<ContactView>>(json);
            //}

            //contacts!.Add(Contact);

            //var newJson = JsonSerializer.Serialize(contacts);
            //System.IO.File.WriteAllText(path, newJson);
        }
    }
}

public class ContactView
{
    [EmailAddress(ErrorMessage = "Votre adresse email n'est pas valide")]
    [Required(ErrorMessage = "Votre email est obligatoire.")]
    [MaxLength(128, ErrorMessage = "Vous ne pouvez pas accèder les 128 caractères.")]
    public string Email { get; set; } = default!;
    
    [Required(ErrorMessage = "Le sujet est obligatoire.")]
    [MaxLength(128, ErrorMessage = "Vous ne pouvez pas accèder les 128 caractères.")]

    public string Subject { get; set; } = default!;

    [Required(ErrorMessage = "Le message est requis.")]
    [MaxLength(512, ErrorMessage = "Vous ne pouvez pas accèder les 512 caractères.")]
    public string Message { get; set; } = default!;
}

