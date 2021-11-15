using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.DTOs.Cotacao
{
    public class GetCotacaoDTO
    {
        public decimal Quantidade { get; set; }
        public string ValorMoeda { get; set; }
        public double TaxaSegmento { get; set; }
        public string TotalEmReais { get; set; }
    }
}
