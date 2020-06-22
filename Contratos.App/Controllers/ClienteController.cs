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

            return RedirectToAction("Index", "Cliente");
        }

        [Authorize]
        public ActionResult Editar(int id)
        {
            var clienteViewModel = _mapper.Map<ClienteViewModel>(_clienteSerivce.GetById(id));
            return View(clienteViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Editar(ClienteViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            _clienteSerivce.Edit(_mapper.Map<ClienteDTO>(viewModel));

            return RedirectToAction("Index", "Cliente");
        }

        [Authorize]
        public ActionResult Excluir(int id)
        {
            var clienteViewModel = _mapper.Map<ClienteViewModel>(_clienteSerivce.GetById(id));
            return View(clienteViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Excluir(ClienteViewModel viewModel)
        {
            _clienteSerivce.Delete(_mapper.Map<ClienteDTO>(viewModel));
            return RedirectToAction("Index", "Cliente");
        }
    }
}
