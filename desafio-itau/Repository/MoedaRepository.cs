using desafio_itau.Entities;
using desafio_itau.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Repository
{
    public class MoedaRepository : IMoedaRepository
    {
        private readonly DataContext _context;

        public MoedaRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Moeda>> Listar()
        {
            return await _context.Moeda.ToListAsync();
        }

        public async Task<Moeda> ObterPorId(Guid id)
        {
            return await _context.Moeda.Where(m => m.Id == id).FirstOrDefaultAsync();
        }


    }
}
