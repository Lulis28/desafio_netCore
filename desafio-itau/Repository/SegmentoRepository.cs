using desafio_itau.Entities;
using desafio_itau.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Repository
{
    public class SegmentoRepository : ISegmentoRepository
    {
        private readonly DataContext _context;

        public SegmentoRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Segmento>> Listar()
        {
            return await _context.Segmento.ToListAsync();
        }

        public async Task<Segmento> ObterPorId(Guid id)
        {
            return await _context.Segmento.Where(m => m.Id == id).FirstOrDefaultAsync();
        }

        public async Task Atualizar(Segmento segmento)
        {
            var segmentoExits = await _context.Segmento.FirstAsync(x => x.Id == segmento.Id);
            segmentoExits.ValorTaxa = segmento.ValorTaxa;
            await _context.SaveChangesAsync();
        }

    }
}
