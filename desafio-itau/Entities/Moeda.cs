using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Entities
{
    public class Moeda
    {
        [Key]
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string WebHook { get; set; }
        public string WebHookParameter { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
