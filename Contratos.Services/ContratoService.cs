using AutoMapper;
using Contratos.Domain.Entities;
using Contratos.Repositories.Interfaces;
using Contratos.Services.Dtos;
using Contratos.Services.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace Contratos.Services
{
    public class ContratoService : IContratoService
    {
        private readonly IMapper _mapper;
        private readonly IContratoRepository _contratoRepository;

        public ContratoService(
            IMapper mapper,
            IContratoRepository contratoRepository)
        {
            _mapper = mapper;
            _contratoRepository = contratoRepository;
        }

        public void Add(ContratoDTO contrato)
        {
            AtualizarConteudoArquivo(contrato);

            _contratoRepository.Add(_mapper.Map<Contrato>(contrato));
            _contratoRepository.Save();
        }

        public IEnumerable<ContratoDTO> List()
        {
            return _mapper.Map<IEnumerable<ContratoDTO>>(_contratoRepository.Buscar());
        }

        public void Delete(ContratoDTO contrato)
        {
            var obj = _contratoRepository.GetById(contrato.Id);
            _contratoRepository.Delete(obj);
            _contratoRepository.Save();
        }

        public void Edit(ContratoDTO contrato)
        {
            var _contrato = _contratoRepository.GetById(contrato.Id);
            if (!string.IsNullOrEmpty(contrato.NomeArquivo) && contrato.NomeArquivo != _contrato.NomeArquivo)
                AtualizarConteudoArquivo(contrato);

            _contratoRepository.Update(_mapper.Map<Contrato>(contrato));
            _contratoRepository.Save();
        }

        public ContratoDTO GetById(int id)
        {
            return _mapper.Map<ContratoDTO>(_contratoRepository.GetById(id));
        }


        private void AtualizarConteudoArquivo(ContratoDTO contrato)
        {
            string path = HttpContext.Current.Server.MapPath($"~/App_Data/Contratos/{contrato.NomeArquivo}");

            var caminho = @"c:\temp\contratos";
            string arquivo = $@"{caminho}\{contrato.NomeArquivo}";
            byte[] fileConvert = File.ReadAllBytes(arquivo);
            contrato.Arquivo = fileConvert;


        }
    }
}
