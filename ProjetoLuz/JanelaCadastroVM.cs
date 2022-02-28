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

        public bool HabilitaBotao { get; set; }

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
                
                users.Add(new Usuario(Name, User, Password, Permissions));
                ClienteFuncionario.Adiciona(users.Last());

            });
        }


        public void IniciaRemove()
        {
            ComandoRemove = new RelayCommand((object _) => 
            {
                    users.RemoveAt(Remove);
            
            },(object _) =>
            {
                
                return users.Count!=0;
            }
            
            
            
            
            );
        }

        public ObservableCollection<Usuario> Users
        {
            get { return users; }
        }
        public void Inicia()
        {
            if ( users == null)
            {
       
                users = new ObservableCollection<Usuario>();
            }
        }

    }
}