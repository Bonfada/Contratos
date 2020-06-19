using AutoMapper;
using Contratos.App.ViewModels;
using Contratos.Services.Dtos;
using Contratos.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contratos.App.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IClienteService _clienteSerivce;

        public ClienteController(
            IMapper mapper, 
            IClienteService clienteSerivce)
        {
            _mapper = mapper;
            _clienteSerivce = clienteSerivce;
        }

        [Authorize]
        public ActionResult Index()
        {
            var clienteViewModel = _mapper.Map<IEnumerable<ClienteViewModel>>(_clienteSerivce.List());
            return View(clienteViewModel);
        }

        [Authorize]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Cadastrar(ClienteViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            _clienteSerivce.Add(_mapper.Map<ClienteDTO>(viewModel));

            //TempData["Mensagem"] = "Cadastro realizado com sucesso.";0
            return RedirectToAction("Index", "Cliente");
        }
    }
}
