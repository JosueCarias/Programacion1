using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2
{
    public class csEquipo
    {
        // Atributos de la clase
    private string nombre;
    private int marcador;

    // Constructor
    public csEquipo(string nombre, int marcador)
    {
        this.nombre = nombre;
        this.marcador = marcador;
    }

    // Propiedades para acceder a los atributos
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Marcador
    {
        get { return marcador; }
        set { marcador = value; }
    }

    // Método para calcular el resultado
    public static string CalcularMarcador(csEquipo equipo1, csEquipo equipo2)
    {
        if (equipo1.Marcador > equipo2.Marcador)
        {
            return $"{equipo1.Nombre} es el ganador. {equipo2.Nombre} es el perdedor.";
        }
        else if (equipo1.Marcador < equipo2.Marcador)
        {
            return $"{equipo2.Nombre} es el ganador. {equipo1.Nombre} es el perdedor.";
        }
        else
        {
            return "El partido terminó en empate.";
        }
        }
    }
}