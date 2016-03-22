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
            autocomplete();
            InitializeComponent();

            ControleUsuário = new ControllerUsuario();
            ControleMensagem = new ControllerMensagem();

        }


        private void buttonEnviarMensagem_Click(object sender, EventArgs e)
        {
            Mensagem mensagem = new Mensagem();
            mensagem.Remetente.IDUsuario = Convert.ToInt32(idremetente);
            mensagem.Destinatario.IDUsuario = Convert.ToInt32(idremetente);
            mensagem.Assunto = textBoxAssunto.Text;
            mensagem.CorpoMensagem = richTextBoxMensagem.Text;

        }
        private void autocomplete()
        {

            textBoxRemetente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxRemetente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            listaUsuário = ControleUsuário.ListarUsuarios();
            foreach (Usuario usuario in listaUsuário)
            {
                idremetente.Text = usuario.IDUsuario.ToString();

            }
        }



        private void buttonNovaMensagem_Click(object sender, EventArgs e)
        {
            novo();
        }
        private void novo()//Limpa os controles do formulário
        {
            textBoxRemetente.Text = "";
            textBoxDestinatario.Text = "";
            textBoxAssunto.Text = "";
            richTextBoxMensagem.Text = "";

        }

    }
}
