using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDockUp
{
    public partial class FormFactura : Form
    {
        private string _path = "";
        private Usuario _vendedor = new Usuario();
        //private List<DatosBase> _compras = new List<DatosBase>();
        private List<Productos> _compras = new List<Productos>();
        private List<Factura> _facturas = new List<Factura>();
        public FormFactura()
        {
            InitializeComponent();
        }
        public Usuario Vendedor { get { return _vendedor; } set { _vendedor = value; } }
        //public List<DatosBase> Compras { get { return _compras; } set { _compras = value; } }
        public List<Productos> Compras { get { return _compras; } set { _compras = value; } }
        public string Path { get { return _path;} set { _path = value; } }
        private void FormFactura_Load(object sender, EventArgs e)
        {
            try { _facturas = JsonConvert.DeserializeObject<List<Factura>>(_path); }
            catch { }
            dgvProductos.Rows.Clear();
            lblNumeroFactura.Text = $"Numero de Factura  {((_facturas.Count+1).ToString()).PadLeft(5,'0')}";
            lblFecha.Text = $"Fecha de Emision:  {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
            lblNombreVendedor.Text = $"Vendedor: {_vendedor.Nombre}";
            dgvProductos.Rows.Add(_compras.Count);
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                for (int j = 0; j < dgvProductos.Columns.Count; j++)
                {
                    if (j == 0) dgvProductos[j, i].Value = _compras[i]._codigo;
                    else if (j == 1) dgvProductos[j, i].Value = $"{_compras[i]._nombre}";
                    else if (j == 2) dgvProductos[j, i].Value = _compras[i]._precio;
                    else if(j == 3) dgvProductos[j, i].Value = _compras[i]._precio*2;
                }
            }
            dgvTotalImpuestos();
        }
        private void dgvTotalImpuestos()
        {
            if (dgvImpuestos.Rows.Count == 0)
            {
                dgvImpuestos.Rows.Add(3);
                dgvImpuestos.Rows[0].Cells[0].Value = "SubTotal";
                dgvImpuestos.Rows[1].Cells[0].Value = "Iva 16%";
                dgvImpuestos.Rows[2].Cells[0].Value = "Monto Total";
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _facturas.Add(new Factura());
            string json = JsonConvert.SerializeObject(_facturas.ToArray(),Formatting.Indented);
            File.WriteAllText(_path, json);
            this.Close();
        }
    }
}
