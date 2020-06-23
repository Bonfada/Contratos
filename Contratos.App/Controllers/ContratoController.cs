using AutoMapper;
using Contratos.App.ViewModels;
using Contratos.Services.Dtos;
using Contratos.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Contratos.App.Controllers
{
    public class ContratoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IContratoService _contratoSerivce;
        private readonly IClienteService _clienteSerivce;

        public ContratoController(
            IMapper mapper,
            IContratoService contratoSerivce,
            IClienteService clienteSerivce)
        {
            _mapper = mapper;
            _contratoSerivce = contratoSerivce;
            _clienteSerivce = clienteSerivce;
        }

        [Authorize]
        public ActionResult Index()
        {

            var contratoViewModel = _mapper.Map<IEnumerable<ContratoViewModel>>(_contratoSerivce.List());
            return View(contratoViewModel);
        }

        [Authorize]
        public ActionResult Cadastrar()
        {
            ViewBag.TipoContrato = new SelectList(Enum.GetValues(typeof(Util.Enum.TipoContratoEnum)));
            ViewBag.ClienteId = new SelectList(_clienteSerivce.List(), "Id", "Nome");
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Cadastrar(ContratoViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            _contratoSerivce.Add(_mapper.Map<ContratoDTO>(viewModel));

            return RedirectToAction("Index", "Contrato");
        }

        [Authorize]
        public ActionResult Editar(int id)
        {
            ViewBag.TipoContrato = new SelectList(Enum.GetValues(typeof(Util.Enum.TipoContratoEnum)));
            ViewBag.ClienteId = new SelectList(_clienteSerivce.List(), "Id", "Nome");
            var contratoViewModel = _mapper.Map<ContratoViewModel>(_contratoSerivce.GetById(id));
            return View(contratoViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Editar(ContratoViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            _contratoSerivce.Edit(_mapper.Map<ContratoDTO>(viewModel));

            return RedirectToAction("Index", "Contrato");
        }

        [Authorize]
        public ActionResult Excluir(int id)
        {
            var contratoViewModel = _mapper.Map<ContratoViewModel>(_contratoSerivce.GetById(id));
            return View(contratoViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Excluir(ContratoViewModel viewModel)
        {
            _contratoSerivce.Delete(_mapper.Map<ContratoDTO>(viewModel));
            return RedirectToAction("Index", "Contrato");
        }

    }
}