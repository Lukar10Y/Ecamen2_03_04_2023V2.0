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
    public partial class FormCambiarDatosUsuario : Form
    {
        private string _path = "";
        private List<Usuario> _usuarios = new List<Usuario>();
        private int _posicion = -1;
        public FormCambiarDatosUsuario()
        {
            InitializeComponent();
        }
        public string Path { set { _path = value; } get { return _path; } }
        public List<Usuario> Usuarios { set { _usuarios = value; } get { return _usuarios; } }
        public int Posicion { set { _posicion = value;} get { return _posicion; } }
        private bool DatoRepetido(string Usuario)
        {
            bool Repetido = false;
            for(int i=0; i<Usuarios.Count; i++)
            {
                if (Usuarios[i].NombreUsuario == tbUsuario.Text) Repetido = true;
            }
            return Repetido;
        }
        private void FormCambiarDatosUsuario_Load(object sender, EventArgs e)
        {
            tbUsuario.Text = _usuarios[_posicion].NombreUsuario;
            tbClaveAntigua.Text = "";
            tbClaveNueva.Text = "";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            #region Condiciones para Cuando Quiere cambiar la Clave
            if (!string.IsNullOrEmpty(tbClaveAntigua.Text) && !string.IsNullOrEmpty(tbClaveNueva.Text))
            {
                if (_usuarios[_posicion].Clave != tbClaveAntigua.Text)
                {
                    MessageBox.Show("Las Claves Indicadas no Coinciden");
                }
                else if (_usuarios[_posicion].Clave == tbClaveAntigua.Text && _usuarios[_posicion].NombreUsuario == tbUsuario.Text)
                {
                    DialogResult Decision = MessageBox.Show("Su Clave sera cambiada.\n\nEsta de Acuerdo?", "Confirmar", MessageBoxButtons.OKCancel);
                    if (Decision == DialogResult.OK)
                    {
                        _usuarios[_posicion].Clave = tbClaveNueva.Text;
                        MessageBox.Show("Cambio realizado Exitosamente!");
                        this.Close();
                    }
                }
                else if (_usuarios[_posicion].Clave == tbClaveAntigua.Text && _usuarios[_posicion].NombreUsuario != tbUsuario.Text && !DatoRepetido(tbUsuario.Text))
                {
                    DialogResult Decision = MessageBox.Show("Su Usuario y Clave seran cambiadas.\n\nEsta de Acuerdo?", "Confirmar", MessageBoxButtons.OKCancel);
                    if (Decision == DialogResult.OK)
                    {
                        _usuarios[_posicion].Clave = tbClaveNueva.Text;
                        _usuarios[_posicion].NombreUsuario = tbUsuario.Text;
                        MessageBox.Show("Cambio realizado Exitosamente!");
                        this.Close();
                    }
                }
                else if (DatoRepetido(tbUsuario.Text)) MessageBox.Show("El Nombre de Usuario Introducido Ya existe");
                string Json = JsonConvert.SerializeObject(_usuarios.ToArray(), Formatting.Indented);
                File.WriteAllText(_path, Json);
            }
            #endregion
            #region Condicion para Cuando Solo Quiere Cambiar el Usuario
            else if (tbUsuario.Text != _usuarios[_posicion].NombreUsuario && !DatoRepetido(tbUsuario.Text))
            {
                DialogResult Decision = MessageBox.Show("Su Usuario sera cambiado.\n\nEsta de Acuerdo?", "Confirmar", MessageBoxButtons.OKCancel);
                if (Decision == DialogResult.OK)
                {
                    _usuarios[_posicion].NombreUsuario = tbUsuario.Text;
                    MessageBox.Show("Cambio realizado Exitosamente!");
                    this.Close();
                }
                string Json = JsonConvert.SerializeObject(_usuarios.ToArray(), Formatting.Indented);
                File.WriteAllText(_path, Json);
            }
            else if (DatoRepetido(tbUsuario.Text)) MessageBox.Show("El Nombre de Usuario Introducido Ya existe");
            #endregion
            else this.Close();
        }
    }
}
