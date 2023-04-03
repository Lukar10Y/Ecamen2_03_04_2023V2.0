using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDockUp
{
    public class Factura
    {
        private int _numero;
        private string _empresa;
        private string _fecha;
        private string _rif;
        private string _direccion;
        private string _correo;
        private double _total;
        private double _impuesto;
        private List<DatosBase> _compras = new List<DatosBase>();
        private Cliente _cliente;
        public Factura()
        {
            _empresa = "Desconocida";
            _fecha = "0/0/0";
            _rif = "null";
            _direccion = "Desconocida";
            _correo = "null";
            _total = -1;
            _impuesto = -1;
            _numero = -1;
        }
        public Factura(string Fecha, string Nombre, string Correo, string rif, string Direccion, int NumeroFactura, List<DatosBase> Compras, Cliente Cliente, double total, double Impuesto)
        {
            _empresa = Nombre;
            _fecha = Fecha;
            _rif = "J"+rif;
            _direccion = Direccion;
            _correo = Correo;
            _total = total;
            _impuesto = Impuesto;
            _compras = Compras;
            _cliente = Cliente;
        }
        public int Numero { get { return _numero; } set { _numero = value; } }
        public string Empresa { get { return _empresa; } set { _empresa = value; } }
        public string Fecha { get { return _fecha; } set { _fecha = value; } }
        public string Rif { get { return _rif; } set { _rif = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public string Correo { get { return _correo; } set { _correo = value; } }
        public List<DatosBase> Compras { get { return _compras; } set { _compras = value; } }
        public Cliente Cliente { get { return _cliente; } set { _cliente = value; } }
        public double Total { get { return _total; } set { _total = value; } }
        public double Impuesto { get { return _impuesto; } set { _impuesto = value; } }
    }
}
