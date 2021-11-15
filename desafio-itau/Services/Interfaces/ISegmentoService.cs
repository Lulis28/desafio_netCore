using desafio_itau.DTOs.Segmento;
using desafio_itau.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Services.Interfaces
{
    public interface ISegmentoService
    {
        Task<ServiceResponse<List<GetSegmentoDTO>>> Listar();
        Task<ServiceResponse<GetSegmentoDTO>> ObterPorId(Guid id);
        Task<ServiceResponse<GetSegmentoDTO>> Atualizar(AtualizarSegmentoDTO atualizarSegmentoDTO);
    }
}
