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

        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Cadastrar(ClienteViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            _clienteSerivce.Add(_mapper.Map<ClienteDTO>(viewModel));

            TempData["Mensagem"] = "Cadastro realizado com sucesso.";
            return RedirectToAction("Mensagens", "Home");
        }
    }
}
