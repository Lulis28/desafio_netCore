using AutoMapper;
using desafio_itau.DTOs;
using desafio_itau.DTOs.Moeda;
using desafio_itau.DTOs.Segmento;
using desafio_itau.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_itau.Config
{
    public class ItauProfile : Profile
    {
        public ItauProfile()
        {
            this.CreateMap<Moeda, GetMoedaDTO>();
            this.CreateMap<Segmento, GetSegmentoDTO>();
            this.CreateMap<AtualizarSegmentoDTO, GetSegmentoDTO>();
            this.CreateMap<Segmento, AtualizarSegmentoDTO>().ReverseMap();
        }
    }
}
