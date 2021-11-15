using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.DTOs.Moeda
{
    public class GetMoedaDTO
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string WebHook { get; set; }
        public string WebHookParameter { get; set; }
    }
}
