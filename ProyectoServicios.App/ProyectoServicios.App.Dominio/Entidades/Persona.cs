using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoServicios.App.Dominio.Entidades
{
    public class Persona
    {

        public int Id {get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NumeroTelefono {get; set; }
        public Genero Genero {get; set;}
    }
}