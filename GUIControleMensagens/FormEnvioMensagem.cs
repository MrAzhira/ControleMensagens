using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIControleMensagens;
using System.Data.SqlClient;
using Controller;
using Model;
namespace GUIControleMensagens
{
    public partial class FormEnvioMensagem : Form
    {
        private ControllerUsuario ControleUsuário;
        private List<Usuario> listaUsuário;
        public FormEnvioMensagem()
        {
            InitializeComponent();

            ControleUsuário = new ControllerUsuario();
            ControleMensagem = new ControllerMensagem();

        }
       

        private void buttonEnviarMensagem_Click(object sender, EventArgs e)
        {

        }

        private void buttonNovaMensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
