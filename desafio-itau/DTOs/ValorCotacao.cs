using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace desafio_itau.DTOs
{
    public class ValorCotacao
    {
        
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Bid { get; set; }
    }
}
