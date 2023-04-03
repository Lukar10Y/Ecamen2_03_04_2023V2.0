using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDockUp
{
    public partial class FormVender : Form
    {
        List<Software> list = new List<Software>();
        //List<DatosBase> _compras = new List<DatosBase>();
        List<Productos> _compras = new List<Productos>();
        Usuario _vendedor = new Usuario();
        FormFactura Factura = new FormFactura();
        string _pathFacturas = "";
        public FormVender()
        {
            InitializeComponent();
        }

        private void FormVender_Load(object sender, EventArgs e)
        {
            cbCategoria.SelectedIndex = 0;
            Factura.Vendedor = _vendedor;
            Random NumeroRandom= new Random();

            if (list.Count == 0)
            {
                Funcion.LlenarValores(NumeroRandom, list, 10);
                dgvProductos.Rows.Add(9);
            }
            for (int i = 0; i<dgvProductos.Rows.Count; i++)
            {
                for(int j = 0; j<dgvProductos.Columns.Count; j++)
                {
                    if(j==0) dgvProductos[j,i].Value = list[i].Nombre;
                    else if(j==1) dgvProductos[j, i].Value = list[i].Marca;
                    else if(j==2) dgvProductos[j, i].Value = list[i].Precio;
                }
            }
        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Factura.Compras = _compras;
            Factura.Path = _pathFacturas;
            Factura.ShowDialog();
        }
        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = list[e.RowIndex].MostrarInfo();
        }
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(list[dgvProductos.CurrentRow.Index].NombreYMarca());
            //_compras.Add(list[dgvProductos.CurrentRow.Index]);
        }
        //public List<DatosBase> Compras { get { return _compras; } set { _compras = value; } }
        public Usuario Vendedor { get { return _vendedor; } set { _vendedor = value; } }
        public string PathFacturas { get { return _pathFacturas; } set { _pathFacturas = value; } }
    }
}
