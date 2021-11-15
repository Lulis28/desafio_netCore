using desafio_itau.DTOs.Moeda;
using desafio_itau.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Services.Interfaces
{
    public interface IMoedaService
    {
        Task<ServiceResponse<List<GetMoedaDTO>>> Listar();
        Task<ServiceResponse<GetMoedaDTO>> ObterPorId(Guid id);
    }
}
