using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDockUp
{

    /* Atributos: Los heredados de DatosBase(Precio,Marca,Nombre,Descripcion,Cantidad)
                    y Propiedades Fisicas(Tamano, Color)         

    /*Metodos: La sobreescritura de MostrarInfo*/
    public class Hardware : PropiedadesFisicas
    {
        private RGB _rgb = new RGB();
        private Inalambrico _inalambrico = new Inalambrico();
        private bool ManipuladorInfo = false; //Es un booleano que dice cuando mostrar caracteristicas extras

        //Constructor por Default
        public Hardware() { }

        //Constructor Parametrico Normal
        public Hardware(string Marca, string Nombre, string Color, double Tamano, double Precio, int Cantidad, string Descripcion) : base(Marca, Nombre, Color, Tamano, Precio, Cantidad, Descripcion)
        {

        }

        //Constructor Parametrico Con caracteristicas Extras
        public Hardware(string Marca, string Nombre, string Color, double Tamano, double Precio, int Cantidad, string Descripcion, bool Inalambrico, bool RGB) : base(Marca, Nombre, Color, Tamano, Precio, Cantidad, Descripcion)
        {
            _rgb.Bool = RGB;
            _inalambrico.Bool = Inalambrico;
            ManipuladorInfo = true;
        }
        public override string MostrarInfo()
        {
            if (ManipuladorInfo == true) return $"{base.MostrarInfo()} {_inalambrico.Comprobar()} {_rgb.Comprobar()} {VerCantidad()}\n\n {Descripcion}\n";
            else return $"{base.MostrarInfo()} {VerCantidad()}\n\n {Descripcion}\n";
        }
    }

    #region Clases Inalambrico y RGB (Complemento para la clase Hardware)
    //CLASES EXTRAS que trabajan con valores booleanos para indicar otra caracteristica distintiva

    //Clase para Describir Luces LED mayormente en Hardwares
    public class RGB
    {
        private bool _luces;

        public RGB()
        {
            _luces = false;
        }
        public RGB(bool Luces)
        {
            _luces = Luces;
        }

        public bool Bool { get { return _luces; } set { _luces = value; } }
        public string Comprobar()
        {
            if (Bool == true) return "Luces LED RGB: Si\n";
            else return "Luces LED RGB: No\n";
        }
    }

    //Clase para Describir productos posiblemente inalambricos; mayormente en Hardwares
    public class Inalambrico
    {
        private bool _inalambrico;

        public Inalambrico()
        {
            _inalambrico = false;
        }
        public Inalambrico(bool Inalambrico)
        {
            _inalambrico = Inalambrico;
        }

        public bool Bool { get { return _inalambrico; } set { _inalambrico = value; } }
        public string Comprobar()
        {
            if (Bool == true) return "Inalambrico\n";
            else return "Alambrico\n";
        }
    }
    #endregion
}
