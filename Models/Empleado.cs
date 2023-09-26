using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica.Models
{
    public class Empleado
    {
        public int Id {get; set;}
        public int Codigo {get; set;}
        public string? Nombre {get; set;}
        public string? Apellidos {get; set;}
        public DateTime DNI {get; set;}
        public int Mantenimiento {get; set;}
        
    }
}