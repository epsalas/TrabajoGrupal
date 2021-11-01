using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabajoGrupal.Models
{
    [Table("cuentas")]
    public class Cuentas{

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Column("problema")]
        public string Problema { get; set; }

        [Column("descripcion")]
        public string Descripcion {get;set;}

        [Column("año1")]
        public double Año1 {get;set;}

        [Column("año2")]
        public double Año2 {get;set;}

        [Column("año3")]
        public double Año3 {get;set;}

        [Column("mensaje")]
        public string Mensaje {get;set;}

        [Column("tipocuenta")]
        public string tipocuenta {get;set;}
    }

}