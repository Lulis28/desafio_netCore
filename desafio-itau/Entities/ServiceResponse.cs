﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Entities
{
    public class ServiceResponse<T>
    {
        public T Dados { get; set; }
        public bool Sucesso { get; set; } = true;
        public string Mensagem { get; set; } = null;
    }
}
