using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLuz
{
    static class ClienteFuncionario 
    { 
        static public string CompraDesconto;
        static public int Compras;
        static public ObservableCollection<Usuario> Cliente { get; set; }
        static public ObservableCollection<Usuario> Funcionario { get; set; }

        public static void Inicia()
        {
            if(Cliente == null || Funcionario == null)
            {
                Cliente = new ObservableCollection<Usuario>();
                Funcionario = new ObservableCollection<Usuario>();
            }

        }
        
        
        static public void Adiciona(Usuario User)
        {
            
            
                if(User.permissao == true)
                {
                    Funcionario.Add(User);
                }
                else
                {
                    Cliente.Add(User);
                }
            
        }
    }
}
