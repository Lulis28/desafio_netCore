using desafio_itau.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Repository.Interfaces
{
    public interface ISegmentoRepository
    {
        Task<List<Segmento>> Listar();
        Task<Segmento> ObterPorId(Guid id);
        Task Atualizar(Segmento segmento);
    }
}
