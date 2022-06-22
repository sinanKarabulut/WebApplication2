using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenemeController : ControllerBase
    {
        private readonly DenemeDataContext _context;

        public DenemeController(DenemeDataContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public void DenemeList() {
            Deneme dene = new Deneme();
            dene.Adi = "asdas";

            _context.denemes.Add(dene)
;
            _context.SaveChanges();

            String data = "";
        }

    }
}
