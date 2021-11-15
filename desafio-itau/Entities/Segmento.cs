using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Entities
{
    public class Segmento
    {
        [Key]
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double ValorTaxa { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
