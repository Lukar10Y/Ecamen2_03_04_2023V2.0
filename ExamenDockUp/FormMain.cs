using borrador;
using DatosEmpresa;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vender;

namespace ExamenDockUp
{
    public partial class FormMain : Form
    {
        private List<Usuario> Usuarios = new List<Usuario>();
        private List<Productos> Productos = new List<Productos>();
        private List<string> DatosEmpresa = new List<string>();
        private List<Cliente> Clientes = new List<Cliente>();
        private FormGestionDatosEmpresa Empresa = new FormGestionDatosEmpresa();
        private FormLogin Login = new FormLogin();
        //FormVender Vender = new FormVender();
        private FormVenderS Vender = new FormVenderS();
        private FormGestionDeProductos GestionDeProductos = new FormGestionDeProductos();
        private FormCambiarDatosUsuario Configuracion = new FormCambiarDatosUsuario();
        private FormGestionDatosClientes GestionClientes = new FormGestionDatosClientes();
        private string pathUsers = @"C:\Users\Fran\Documents\VISUAL STUDIO\COMUNNITY\ExamenDockUp\UsersEXAMEN2.json";
        private string pathFacturas = @"C:\Users\Fran\Documents\VISUAL STUDIO\COMUNNITY\ExamenDockUp\FacturasEXAMEN2.json";
        private string pathClientes = @"C:\Users\Fran\Documents\VISUAL STUDIO\COMUNNITY\ExamenDockUp\ClientesEXAMEN2.json";
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Login.Path = pathUsers;
            Configuracion.Path = pathUsers;
            Vender.PathFacturas = pathFacturas;
            if (Login.ShowDialog()!=DialogResult.OK){
                Application.Exit();
            }
            else
            {
                Usuarios = Login.ListaUsuarios; //En esta linea hago "copia de la lista" para simplificar codigo
                lblNombre.Text = Usuarios[Login.Posicion].Nombre;
                lblCargo.Text = Usuarios[Login.Posicion].Cargo;
                Configuracion.Usuarios = Usuarios;
                Configuracion.Posicion = Login.Posicion;
                Vender.Vendedor = Usuarios[Login.Posicion];
                if (Usuarios.Count < 2)
                {
                    Usuarios.Add(new Usuario("Vendedor1","Vendedor1","No Asignada", false));
                    MessageBox.Show("Ademas se ha creado un usuario No Administrador de prueba\n\nUsuario: Vendedor1\nClave: Vendedor1");
                }
                string Json = JsonConvert.SerializeObject(Usuarios.ToArray(), Formatting.Indented);
                File.WriteAllText(Login.Path, Json);
                try
                {
                    Clientes = JsonConvert.DeserializeObject<List<Cliente>>(File.ReadAllText(pathClientes));
                }
                catch { MessageBox.Show("La Lista de Clientes Esta Vacia"); }
                if (Usuarios[Login.Posicion].Cargo!="Administrador")
                {
                    gBoxAdmin.Visible = false;
                }
            }
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            Vender.Productos = GestionDeProductos.ListaProductos;
            Vender.ShowDialog();
        }
        private void rtbConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion.ShowDialog();
        }
        private void pbConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion.ShowDialog();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            GestionDeProductos.ShowDialog();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Empresa.Empleados = Usuarios;
            Empresa.PathEmpleados = pathUsers;
            Empresa.ShowDialog();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            GestionClientes.ListaClientes = Clientes;
            GestionClientes.PathClientes = pathClientes;
            GestionClientes.ShowDialog();
        }
    }
}
