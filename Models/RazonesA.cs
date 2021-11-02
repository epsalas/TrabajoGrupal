using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabajoGrupal.Models
{
    
    public class RazonesA{

       
        public int ID { get; set; }

    //Rotación de cuentas por cobrar (RCC)
    //Ctas por cobrar promedio
        public double ccinicial1 {get;set;}
        public double ccfinal1 {get;set;}
        public double ccp1 {get;set;}
        public double Mensaje1 {get;set;}

        public double ccinicial2 {get;set;}
        public double ccfinal2 {get;set;}
        public double ccp2 {get;set;}
        public double Mensaje2 {get;set;}

        public double ccinicial3 {get;set;}
        public double ccfinal3 {get;set;}
        public double ccp3 {get;set;}
        public double Mensaje3 {get;set;}

    //Rotacion de cuentas por cobrar
        public double vnetas {get;set;}
        public double rcc1 {get;set;}
        public double Mensaje4 {get;set;}

        public double vnetas2 {get;set;}
        public double rcc2 {get;set;}
        public double Mensaje5 {get;set;}

        public double vnetas3 {get;set;}
        public double rcc3 {get;set;}
        public double Mensaje6 {get;set;}

    //Días de ctas x cobrar
        public double ccd1 {get;set;}
        public double Mensaje7 {get;set;}
        

        public double ccd2 {get;set;}
        public double Mensaje8 {get;set;}

        public double ccd3 {get;set;}
        public double Mensaje9 {get;set;}







        
    }
}
