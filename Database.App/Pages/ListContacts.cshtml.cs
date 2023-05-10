using Database.Domain.Contacts;
using Database.Infrastucture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Database.App.Pages
{
    public class ListContactsModel : PageModel
    {
        private readonly DataContext _dataContext;
        public List<ContactView> Contacts { get; set; }

        public ListContactsModel(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void OnGet()
        {
            Contacts = _dataContext.Set<Contact>()
                .Select(x => new ContactView
                {
                    Subject = x.Subject,
                    Email = x.Email,
                    Message = x.Message
                }).ToList();
        }

        public class ContactView
        {
            public string Email { get; set; } = default!;
            public string Subject { get; set; } = default!;
            public string Message { get; set; } = default!;
        }
    }
}
