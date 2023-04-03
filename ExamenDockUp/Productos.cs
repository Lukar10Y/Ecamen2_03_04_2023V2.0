using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDockUp
{
    public class Productos
    {
        public string _codigo { get; set; }
        public string _nombre { get; set; }
        public double _precio { get; set; }

        public Productos(string codigo, string nombre, double precio)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
        }
    }
}
