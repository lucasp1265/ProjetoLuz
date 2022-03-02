using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjetoLuz
{
    internal class JanelaCadastroVM
    {
        public ICommand ComandoCadastro { get; private set; }
        public ICommand ComandoRemove { get; private set; }
        public int Remove { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool Permissions { get; set; }

        private ObservableCollection<Usuario> users;


        public JanelaCadastroVM()

        {


            
            IniciaComando();
            Inicia();
            IniciaRemove();
            
            
        }
       
        public void IniciaComando()
        {
            ComandoCadastro = new RelayCommand((object _) =>
            {
                //Adiciona o usuário ao ObservableCollection e na classe ClienteFuncionario para fazer a separação
                users.Add(new Usuario(Name, User, Password, Permissions));
                ClienteFuncionario.Adiciona(users.Last());

            });
        }


        public void IniciaRemove()
        {
            ComandoRemove = new RelayCommand((object _) => 
            {
                //Deleta o usuário selecionado das duas listas
                //Remove recebe o índice do nome que vai ser removido da primeira lista
                ClienteFuncionario.Deleta(users[Remove]);    
                    users.RemoveAt(Remove);
            
            },(object _) =>
            {
                //Se não existir nenhum usuário cadastrado o botão é desabilitado
                return users.Count!=0;
            });
        }

        // Retorna a lista de Usuários
        public ObservableCollection<Usuario> Users
        {
            get { return users; }
        }
        
        //Inicializa e aloca a lista
        public void Inicia()
        {
            if ( users == null)
            {
       
                users = new ObservableCollection<Usuario>();
            }
        }

    }
}
