using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fablab.Models.Entitys
{
    public class Solicitud
    {
        [Key]
        public int Id { get; set; }

        [Column("nombre_coordinador")]
        public string NombreCoordinador { get; set; }

        [Column("email_coordinador")]
        public string EmailCoordinador { get; set; }

        public string Departamento { get; set; }

        [Column("evento_nombre")]
        public string EventoNombre { get; set; } // Nombre del evento académico}}

        [Column("evento_organizador")]
        public string EventoOrganizador { get; set; } // Organizador del evento

        [Column("evento_lugar")]
        public string EventoLugar { get; set; } // Lugar del evento

        [Column("evento_fecha_inicio")]
        public DateTime EventoFechaInicio { get; set; } // Fecha de inicio del evento

        [Column("evento_fecha_fin")]
        public DateTime EventoFechaFin { get; set; } // Fecha de fin del evento

        [Column("objetivos_esperados")]
        public string PbjetivosEsperados { get; set; } // Beneficios esperados de la participación

        [Column("fecha_solicitud")]
        public DateTime FechaSolicitud { get; set; }  = DateTime.Now;

        [Column("estado_solicitud")]
        public string Estado { get; set; }


        //apartado para documentos 
        [Column("documento_justificacion")]
        public byte[] DocumentoJustificacion { get; set; }  

        [Column("documento_requerimientos")]     
        public byte[] DocumentoRquerimientos { get; set; }
        
        [Column("documento_convocatoria")]
        public byte[] DocumentoComvocatoria { get; set; } 
      
    }
}