using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fablab.Models.Entitys 
{
    public class Usuario : IdentityUser
    {
        [Column("Fecha_creacion_cuenta")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}