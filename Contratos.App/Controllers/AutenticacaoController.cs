using AutoMapper;
using Contratos.App.ViewModels;
using Contratos.Services.Dtos;
using Contratos.Services.Interfaces;
using System.Web.Mvc;

namespace Contratos.App.Controllers
{
    public class AutenticacaoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioService _usuarioSerivce;

        public AutenticacaoController(
            IMapper mapper, 
            IUsuarioService usuarioBusiness)
        {
            _mapper = mapper;
            _usuarioSerivce = usuarioBusiness;
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(UsuarioViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            _usuarioSerivce.Add(_mapper.Map<UsuarioDTO>(viewModel));

            TempData["Mensagem"] = "Cadastro realizado com sucesso. Efetue login.";
            return RedirectToAction("Index", "Home");
        }
    }
}