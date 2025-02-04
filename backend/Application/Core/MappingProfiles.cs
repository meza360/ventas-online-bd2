using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using AutoMapper;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Producto,Producto>();
            CreateMap<Proveedor,Proveedor>();
            CreateMap<Pais,Pais>();
            CreateMap<Lote,Lote>();
            CreateMap<Cliente,Cliente>();
            CreateMap<Empleado,Empleado>();
            CreateMap<Proveedor,Proveedor>();
            CreateMap<Representante,Representante>();
            CreateMap<Tarjeta,Tarjeta>();
        }
    }
}