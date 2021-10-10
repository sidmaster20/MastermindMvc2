using System.Web.Mvc;
using BootstrapSite1.ViewModels;
using Newtonsoft.Json;
using DataLayer;
using DataLayer.DataModels;

namespace BootstrapSite1.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public int SaveContact(string Contact)
        {
            try
            {
                ContactsViewModel _contact = JsonConvert.DeserializeObject<ContactsViewModel>(Contact);
                ContactDataModel _dmContact = new ContactDataModel
                {
                    CompanyName = _contact.CompanyName,
                    Email = _contact.Email,
                    FirstName = _contact.FirstName,
                    LastName = _contact.LastName,
                    Message = _contact.Message,
                    Phone = _contact.Phone
                };
                LeadsDataLayer objLd = new LeadsDataLayer();
                objLd.SaveContact(_dmContact);
                return 1;
            }
            catch(System.Exception ex)
            {
                return 0;
            }
        }
	}
}