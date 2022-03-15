using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLuz
{
    public interface IConexao
    {

        bool Insere(string nomes, string logins, string senhas, bool funcionarios);
        bool Atualiza(string nome, string senha, string login, bool funcionario, Usuario user);
        bool Remove(string login);
        bool InsereProdutos(string produto, string login1, string login2);
        void Popula(ObservableCollection<Usuario> lista);

    }
}
