using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace GUIControleMensagens
{
    public partial class FormLeituraMensagem : Form
    {
        public FormLeituraMensagem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsuarioBox.Text != null)
            {
                ControllerMensagem controllerMensagem = new ControllerMensagem();
                List<Mensagem> MensagemList = new List<Mensagem>();
                MensagemList = controllerMensagem.ListarMensagensRecebidasPorUsuario(UsuarioBox.Text);
                foreach (Mensagem mensagem in MensagemList)
                {
                    UsuarioDataGrid.Atualizar();
                }
            }
            else
            {
                MessageBox.Show("Voce não escreveu nada no campo de usuário.");
            }
        }
    }
}
