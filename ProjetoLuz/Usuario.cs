using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLuz
{
    public class Usuario
    {
        public string nome;
        protected string user;
        protected string password;
        public bool permissao;


        public Usuario()
        {

        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string User{
            get { return user; }
            set { user = value; }
        }
        public string Password
        {
            get { return user; }
            set { user = value; }
        }

        public void setUser(string usuario)
        {
            User = usuario;
        }
        public void setPassword(string senha)
        {
            User = senha;
        }

        public Usuario(string nome, string user, string password, bool permissao)
        {
            if (nome != null || user != null || password != null)
            {
                this.nome = nome;
                this.user = user;
                this.password = password;
                this.permissao = permissao;
            }
        }

        
    }
}
