using AutoMapper;
using Contratos.App.ViewModels;
using Contratos.Services.Dtos;
using Contratos.Services.Util;
using Contratos.Services.Interfaces;
using System;
using System.Linq;
using System.Security.Claims;
using System.Web;
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
            return RedirectToAction("Login");
        }

        public ActionResult Login(string ReturnUrl)
        {
            var viewModelLogin = new LoginViewModel
            {
                UrlRetorno = ReturnUrl
            };

            return View(viewModelLogin);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var usuario = _usuarioSerivce.List().FirstOrDefault(u => u.Login == viewModel.Login);

            if (usuario == null)
            {
                ModelState.AddModelError("Login", "Login Incorreto");
                return View(viewModel);
            }

            if (usuario.Login != viewModel.Login)
            {
                ModelState.AddModelError("Login", "Login Incorreto");
                return View(viewModel);
            }

            if (usuario.Senha != Hash.GerarHash(viewModel.Senha))
            {
                ModelState.AddModelError("Senha", "Senha incorreta");
                return View(viewModel);
            }

            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name,usuario.Nome),
                new Claim("Login", usuario.Login)
            }, "ApplicationCookie");

            Request.GetOwinContext().Authentication.SignIn(identity);

            if (!String.IsNullOrWhiteSpace(viewModel.UrlRetorno) || Url.IsLocalUrl(viewModel.UrlRetorno))
                return Redirect(viewModel.UrlRetorno);
            else
                return RedirectToAction("Index", "Home");

        }
    }
}