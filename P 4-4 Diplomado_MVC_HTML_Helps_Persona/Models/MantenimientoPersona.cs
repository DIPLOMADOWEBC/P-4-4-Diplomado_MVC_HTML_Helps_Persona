using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_4_4_Diplomado_MVC_HTML_Helps_Persona.Models
{
    public class MantenimientoPersona
    {
        List<Persona> ListaPersonas = new List<Persona>()
        {
            new Persona()
            {
                Codigo = 1,
                Nombre = "Juan Esteban Gonzalez",
                Peso = 60.7f,
                Trabaja = true,
                FechaNacimiento = new DateTime(1993,8,16)
            },
            new Persona()
            {
                Codigo = 2,
                Nombre = "Yeni Rosario Pinales",
                Peso = 52.9f,
                Trabaja = true,
                FechaNacimiento = new DateTime(1992,2,27)
            },
            new Persona()
            {
                Codigo = 3,
                Nombre = "Pedro Julio Metivier",
                Peso = 71.1f,
                Trabaja = false,
                FechaNacimiento = new DateTime(1993,11,2)
            }
        };

        public Persona Retornar(int cod)
        {
            foreach (var per in ListaPersonas)
                if (per.Codigo == cod)
                    return per;
            return null;
        }
    }
}