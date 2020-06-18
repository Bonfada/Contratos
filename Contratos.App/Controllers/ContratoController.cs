using System.Web.Mvc;

namespace Contratos.App.Controllers
{
    public class ContratoController : Controller
    {
        // GET: Contrato
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}