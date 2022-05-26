using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class Cliente : IdentityUser
    {
        [Key]
        public int nitCliente { get; set; }
        public string nombresCliente { get; set; }
        public string apellidosCliente { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string direccionEntrega { get; set; }
        public string noTarjeta { get; set; }
        public int nacionalidad { get; set; }
        public string password { get; set; }
    }
}