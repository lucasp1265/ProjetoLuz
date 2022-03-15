using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetoLuz
{
    public class ConexaoPostgres : IConexao
    {
        private NpgsqlConnection conexao;
        private NpgsqlCommand cmd;

        public string stringConexao;
        public ConexaoPostgres()
        {
           
            cmd = new NpgsqlCommand();
            conexao = new NpgsqlConnection();
            stringConexao = "Server = localhost; Port = 5555; DataBase = lucas; User id = lucas;Password = lucas";
            conexao.ConnectionString = stringConexao;
            cmd.Connection = conexao;
      
        }

        public bool Insere(string nomes,string logins,string senhas, bool funcionarios)
        {
            
            string comando = $"INSERT INTO usuario (nome, login, senha, funcionario) VALUES('{nomes}','{logins}','{senhas}',{funcionarios})";
            cmd.CommandText = comando;
            try
            {
                conexao.Open();
                int res = cmd.ExecuteNonQuery();
                if (res != -1)
                { 
                    MessageBox.Show("Usuario inserido com sucesso");
                }
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return true;
        }
        public bool InsereProdutos(string produto, string login1, string login2)
        {
            cmd.CommandText = $"UPDATE usuario SET produtos = CONCAT(produtos, ' {produto}') WHERE login = '{login1}';" +
                              $"UPDATE usuario SET produtos = CONCAT(produtos, ' {produto}') WHERE login = '{login2}'";

            try
            {
                conexao.Open();
                int res = cmd.ExecuteNonQuery();

                if (res != -1)
                {
                    MessageBox.Show("Produtos adicionados com sucesso");
                }
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }


            return true;
        }
        public bool Remove(string login)
        {


            string comando = $"DELETE FROM usuario WHERE login = '{login}'";
            cmd.CommandText = comando;

            try
            {
                conexao.Open();
                int res = cmd.ExecuteNonQuery();

                if (res != -1)
                {
                    MessageBox.Show("Usuario Removido com sucesso");
                }
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return true;
            
        }
        public bool Atualiza(string nome, string senha, string login, bool funcionario, Usuario user)
        {
            

            string comando = " UPDATE usuario SET ";
            string key = user.User;

            if (nome != user.nome)
            {
                comando += $" nome = '{nome}' ";
                user.nome = nome;
            }

            if (login != user.User)
            {
                comando += $", login = '{login}' ";
                user.User = login;
            }

            if (senha != user.Password)
            {
                comando += $", senha = '{senha}' ";
                user.Password = senha;
            }

            if (funcionario != user.permissao)
            {
                comando += $", funcionario = '{funcionario}' ";
                user.permissao = funcionario;
            }
            comando += $" WHERE login = '{key}' ";
            cmd.CommandText = comando;


            try
            {
                conexao.Open();
                int res = cmd.ExecuteNonQuery();
                if (res != -1)
                {
                    MessageBox.Show("Usuario atualizado com sucesso");
                }
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            
            return true;
            
        }

        public void Popula(ObservableCollection<Usuario> lista)
        {
            NpgsqlDataReader rdr;

            cmd.CommandText = "SELECT * FROM usuario";
            try
            {
                conexao.Open();
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    lista.Add(new Usuario(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetBoolean(3)));
                }
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }

}
