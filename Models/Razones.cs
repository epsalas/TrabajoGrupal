using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabajoGrupal.Models
{
    
    public class Razones{

       
        public int ID { get; set; }

        public double acorriente1 {get;set;}
        public double pcorriente1 {get;set;}
        public double Mensaje1 {get;set;}



        public double acorriente2 {get;set;}
        public double pcorriente2 {get;set;}
        public double Mensaje2 {get;set;}



        public double acorriente3 {get;set;}
        public double pcorriente3 {get;set;}
        public double Mensaje3 {get;set;}



        public double acorriente4 {get;set;}
        public double pcorriente4 {get;set;}
        public double inventario4 {get;set;}
        public double Mensaje4 {get;set;}



        public double acorriente5 {get;set;}
        public double pcorriente5 {get;set;}
        public double inventario5 {get;set;}
        public double Mensaje5 {get;set;}



        public double acorriente6 {get;set;}
        public double pcorriente6 {get;set;}
        public double inventario6 {get;set;}
        public double Mensaje6 {get;set;}


    }


}