using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.DTOs.Segmento
{
    public class GetSegmentoDTO
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double ValorTaxa { get; set; }
    }
}
