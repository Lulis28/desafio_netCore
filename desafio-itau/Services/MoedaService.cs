using AutoMapper;
using desafio_itau.DTOs.Moeda;
using desafio_itau.Entities;
using desafio_itau.Repository.Interfaces;
using desafio_itau.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace desafio_itau.Services
{
    public class MoedaService : IMoedaService
    {
        private readonly IMoedaRepository _moedaRepository;
        private readonly IMapper _mapper;
        public MoedaService(IMoedaRepository moedaRepository, IMapper mapper)
        {
            _moedaRepository = moedaRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetMoedaDTO>>> Listar()
        {
            var serviceResponse = new ServiceResponse<List<GetMoedaDTO>>();

            try
            {
                var moedas = await _moedaRepository.Listar();

                serviceResponse.Dados = _mapper.Map<List<GetMoedaDTO>>(moedas);
            }
            catch (Exception ex)
            {
                serviceResponse.Sucesso = false;
                serviceResponse.Mensagem = ex.Message;                
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetMoedaDTO>> ObterPorId(Guid id)
        {
            var serviceResponse = new ServiceResponse<GetMoedaDTO>();

            try
            {
                var moeda = await _moedaRepository.ObterPorId(id);

                serviceResponse.Dados = _mapper.Map<GetMoedaDTO>(moeda);
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
