using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace Controller
{
    public class ControllerMensagem
    {
        public bool GravarMensagem(Mensagem mensagem)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();

            if (mensagem.IDMensagem == 0)
            {
                comando.CommandText = "insert into tbl_mensagem (remetente, destinatario, assunto, mensagem) values(@remetente, @destinatario, @assunto, @mensagem)";
                comando.Parameters.AddWithValue("@remetente", mensagem.Remetente);
                comando.Parameters.AddWithValue("@destinatario", mensagem.Destinatario);
                comando.Parameters.AddWithValue("@assunto", mensagem.Assunto);
                comando.Parameters.AddWithValue("@mensagem", mensagem.CorpoMensagem);
            }
            else
            {
                comando.CommandText = "update tbl_mensagem set remetente=@remetente, destinatario=@destinatario, assunto=@assunto, mensagem=@mensagem where id_mensagem=@idmensagem";
                comando.Parameters.AddWithValue("@remetente", mensagem.Remetente);
                comando.Parameters.AddWithValue("@destinatario", mensagem.Destinatario);
                comando.Parameters.AddWithValue("@assunto", mensagem.Assunto);
                comando.Parameters.AddWithValue("@mensagem", mensagem.CorpoMensagem);
            }
            conexao.Open();
            int linhasModificadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;
        }

        public bool ExcluirMensagem(int idMensagem)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "delete from tbl_mensagem where id_mensagem=@idmensagem";
            comando.Parameters.AddWithValue("@idmensagem", idMensagem);
            conexao.Open();
            int linhasModificadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;
        }

        public List<Mensagem> ListarMensagensRecebidasPorUsuario(string destinatario)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tbl_mensagem where destinatario=@destinatario order by id_mensagem";
            comando.Parameters.AddWithValue("@destinatario", destinatario);
            conexao.Open();
            List<Mensagem> listaMensagens = new List<Mensagem>();
            Mensagem mensagem;
            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    mensagem = new Mensagem();
                    mensagem.Remetente.IDUsuario = reader.GetInt32(1);
                    mensagem.Destinatario.IDUsuario = reader.GetInt32(2);
                    mensagem.Assunto = reader.GetString(3);
                    mensagem.CorpoMensagem = reader.GetString(4);
                    listaMensagens.Add(mensagem);
                }
                conexao.Close();
                return listaMensagens;
            }
        }
    }
}
