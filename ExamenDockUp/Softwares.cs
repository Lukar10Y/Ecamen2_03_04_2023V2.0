﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDockUp
{
    /*Atibutos:  Los heredados de DatosBase(Precio,Marca,Nombre,Descripcion,Cantidad)
                     En adicion a la version, peso (en GB) y una instancia de la clase Suscripcion
                     Considerada debido a que es muy famoso el pago de productos por mensualidad o anualidad*/

    /*Metodos: funciones para verificar si hay alguna suscripcion y en caso de ser cierto
               de cuanto es el cargo y la duracion de la misma. Ademas de la sobreescritura de MostraInfo*/

    /*No he visto softwares que al comprarse se obtenga una licencia de por vida,
            Por lo cual voy a ignorar la posibilidad de un constructor en donde se cobre una cierta
            cantidad para comprar el software y que luego no requiera ninguna suscripcion*/
    public class Software : DatosBase
    {
        Suscripcion _suscripcion = new Suscripcion();
        private double _version;
        private double _peso; //GB de peso

        //Constructor por Default
        public Software()
        {
            _version = 0;
            _peso = 0;
        }

        //Constructor Parametrico (Gratuito y sin Suscripcion)
        public Software(string Marca, string Nombre, double Version, double PesoGB, int Cantidad, string Descripcion) : base(Marca, Nombre, Cantidad, Descripcion)
        {
            _suscripcion.Duracion = -1;
            _suscripcion.Precio = 0;
            _version = Version;
            _peso = PesoGB;
        }

        //Constructor Parametrico (Gratuito y con Suscripcion Mensual)
        public Software(string Marca, string Nombre, double Version, double PesoGB, int Duracion, double PrecioSuscripcion, int Cantidad, string Descripcion) : base(Marca, Nombre, 0, Cantidad, Descripcion)
        {
            _suscripcion.Duracion = Duracion;
            _suscripcion.Precio = PrecioSuscripcion;
            _version = Version;
            _peso = PesoGB;
        }

        //Constructor Parametrico (Gratuito y con Suscripcion Anual)
        public Software(string Marca, string Nombre, double Version, double PesoGB, int Duracion, double PrecioSuscripcion, int Cantidad, string Descripcion, bool Anualidad) : base(Marca, Nombre, 0, Cantidad, Descripcion)
        {
            _suscripcion.Duracion = Duracion;
            _suscripcion.Precio = PrecioSuscripcion;
            _suscripcion.Periocidad = Anualidad;
            _version = Version;
            _peso = PesoGB;
        }

        //Constructor Parametrico (Pago y con Suscripcion Mensual)
        public Software(string Marca, string Nombre, double Version, double PesoGB, int Duracion, double PrecioSuscripcion, double PrecioSoftware, int Cantidad, string Descripcion) : base(Marca, Nombre, PrecioSoftware, Cantidad, Descripcion)
        {
            _suscripcion.Duracion = Duracion;
            _suscripcion.Precio = PrecioSuscripcion;
            _version = Version;
            _peso = PesoGB;
        }

        //Constructor Parametrico (Pago y con Suscripcion Anual)
        public Software(string Marca, string Nombre, double Version, double PesoGB, int Duracion, double PrecioSuscripcion, double PrecioSoftware, int Cantidad, string Descripcion, bool Anualidad) : base(Marca, Nombre, PrecioSoftware, Cantidad, Descripcion)
        {
            _suscripcion.Duracion = Duracion;
            _suscripcion.Precio = PrecioSuscripcion;
            _suscripcion.Periocidad = Anualidad;
            _version = Version;
            _peso = PesoGB;
        }
        protected string VerDuracion(double PrecioSoftware) //Duracion de la Suscripcion
        {
            if (PrecioSoftware == 0)
            {
                if (_suscripcion.Duracion == -1) return "Periodo de Uso inicial: Ilimitado";
                else if (_suscripcion.Duracion > 1 || _suscripcion.Duracion == 0) return $"Periodo de Uso inicial: {_suscripcion.Duracion} Meses";
                else if (_suscripcion.Duracion == 1) return $"Periodo de Uso inicial: 1 Mes";
                else return "Error";
            }
            else if (PrecioSoftware > 0)
            {
                if (_suscripcion.Duracion == -1) return "Periodo de Uso inicial Gratuito: Ilimitado";
                else if (_suscripcion.Duracion > 1 || _suscripcion.Duracion == 0) return $"Periodo de Uso inicial Gratuito: {_suscripcion.Duracion} Meses";
                else if (_suscripcion.Duracion == 1) return $"Periodo de Uso inicial Gratuito: 1 Mes";
                else return "Error";
            }
            else return "Error";
        }
        protected string VerSuscripcion() //Precio de la Suscripcion
        {
            if (_suscripcion.Precio == 0) return "No requiere Suscripcion";
            else if (_suscripcion.Periocidad == false) return $"{_suscripcion.Precio}$ (Mensual)";
            else if (_suscripcion.Periocidad == true) return $"{_suscripcion.Precio}$ (Anual)";
            else return "Error";
        }
        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()}\n\n Version: {_version}\n Peso: {_peso}GB\n {VerDuracion(Precio)}\n Suscripcion: {VerSuscripcion()}\n\n {VerCantidad()} \n {Descripcion}\n";
        }
        public double Version { set { _version = value; } get { return _version; } }
        public double Peso { set { _peso = value; } get { return _peso; } }
    }
    #region Clase Suscripcion (Complemento de Software)

    //CLASE EXTRA PARA COMPLEMENTAR LA CLASE SOFTWARE

    //Atributos: Precio,Duracion y Periocidad (para saber si es anual o mensual

    //Metodos: Los suficientes como para acceder y modificar los atributos mencionados
    public class Suscripcion
    {
        private double _precio; // Precio de la suscripcion
        private int _duracion; // Periodo de uso desde su compra, si es que hay un limite, en caso contrario no habra limite
        private bool _periocidad;

        //Contructor por Default
        public Suscripcion()
        {
            _precio = -1;
            _duracion = -1;
            _periocidad = false;
        }

        //Constructor Parametrico mensual
        public Suscripcion(double Precio, int Duracion)
        {
            _precio = Precio;
            _duracion = Duracion;
            _periocidad = false;
        }

        //Constructor Parametrico Anual
        public Suscripcion(double Precio, int Duracion, bool Periocidad)
        {
            _precio = Precio;
            _duracion = Duracion;
            _periocidad = Periocidad;
        }
        public double Precio { set { _precio = value; } get { return _precio; } }
        public int Duracion { set { _duracion = value; } get { return _duracion; } }
        public bool Periocidad { set { _periocidad = value; } get { return _periocidad; } }
    }

    #endregion
}
