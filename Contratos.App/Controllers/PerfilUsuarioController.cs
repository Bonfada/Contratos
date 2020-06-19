using Contratos.App.ViewModels;
using System.Web.Mvc;

namespace Contratos.App.Controllers
{
    public class PerfilUsuarioController : Controller
    {
        [Authorize]
        public ActionResult AlterarSenha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AlterarSenha(PerfilUsuarioViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            TempData["Mensagem"] = "Senha alterada com sucesso.";
            return RedirectToAction("Index", "Home");
        }
    }
}
