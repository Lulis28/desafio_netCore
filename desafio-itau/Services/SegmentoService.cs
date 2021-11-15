using AutoMapper;
using desafio_itau.DTOs.Segmento;
using desafio_itau.Entities;
using desafio_itau.Repository.Interfaces;
using desafio_itau.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Services
{
    public class SegmentoService : ISegmentoService
    {
        private readonly ISegmentoRepository _segmentoRepository;
        private readonly IMapper _mapper;

        public SegmentoService(ISegmentoRepository segmentoRepository, IMapper mapper)
        {
            _segmentoRepository = segmentoRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetSegmentoDTO>>> Listar()
        {
            var serviceResponse = new ServiceResponse<List<GetSegmentoDTO>>();

            try
            {
                var segmentos = await _segmentoRepository.Listar();

                serviceResponse.Dados = _mapper.Map<List<GetSegmentoDTO>>(segmentos);
            }
            catch (Exception ex)
            {
                serviceResponse.Sucesso = false;
                serviceResponse.Mensagem = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetSegmentoDTO>> ObterPorId(Guid id)
        {
            var serviceResponse = new ServiceResponse<GetSegmentoDTO>();

            try
            {
                var segmento = await _segmentoRepository.ObterPorId(id);

                serviceResponse.Dados = _mapper.Map<GetSegmentoDTO>(segmento);
            }
            catch (Exception ex)
            {
                serviceResponse.Sucesso = false;
                serviceResponse.Mensagem = ex.Message;
            }


            return serviceResponse;
        }

        public async Task<ServiceResponse<GetSegmentoDTO>> Atualizar(AtualizarSegmentoDTO atualizarSegmentoDTO)
        {
            var serviceResponse = new ServiceResponse<GetSegmentoDTO>();

            try
            {
                var segmento = _mapper.Map<Segmento>(atualizarSegmentoDTO);
                await _segmentoRepository.Atualizar(segmento);
                serviceResponse.Dados = _mapper.Map<GetSegmentoDTO>(atualizarSegmentoDTO);
            }
            catch (Exception ex)
            {
                serviceResponse.Sucesso = false;
                serviceResponse.Mensagem = ex.Message;
            }

            return serviceResponse;
        }
    }
}
