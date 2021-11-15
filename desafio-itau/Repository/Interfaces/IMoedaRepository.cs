using desafio_itau.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Repository.Interfaces
{
    public interface IMoedaRepository
    {
        Task<List<Moeda>> Listar();
        Task<Moeda> ObterPorId(Guid id);
    }
}
