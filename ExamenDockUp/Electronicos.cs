using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDockUp
{
    public class Electronicos : PropiedadesFisicas
    {
        private string _modelo;
        private int _anio;

        //Constructor por default
        public Electronicos()
        {
            _modelo = "null";
            _anio = -1;
        }

        //Constructor Parametrico que no pide Tamano (Que a veces no es de interes)
        public Electronicos(string Marca, string Nombre, string Modelo, int Anio, string Color, double Precio, int Cantidad, string Descripcion) : base(Marca, Nombre, Color, 0, Precio, Cantidad, Descripcion)
        {
            _modelo = Modelo;
            _anio = Anio;
        }

        //Constructor Parametrico Normal
        public Electronicos(string Marca, string Nombre, string Modelo, int Anio, string Color, double Tamano, double Precio, int Cantidad, string Descripcion) : base(Marca, Nombre, Color, Tamano, Precio, Cantidad, Descripcion)
        {
            _modelo = Modelo;
            _anio = Anio;
        }
        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()} Modelo: {_modelo} {_anio}\n {VerCantidad()}\n\n {Descripcion}\n";
        }
    }
}
