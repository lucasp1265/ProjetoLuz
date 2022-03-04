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
        static public ObservableCollection<Usuario> Cliente { get; private set; }
        static public ObservableCollection<Usuario> Funcionario { get; private set; }

        static public ObservableCollection<int> Salario;

        public static void Inicia()
        {
            if(Cliente == null || Funcionario == null)
            {
                //Inicializa as duas listas e aloca na memória
                Cliente = new ObservableCollection<Usuario>();
                Funcionario = new ObservableCollection<Usuario>();
                Salario = new ObservableCollection<int>();
            }

        }
        
        //As duas funções abaixo operam verificando se é funcionário ou cliente e remove ou adiciona nas suas 
        //respectivas listas
        static public void Deleta(Usuario User)
        {
            if(User.permissao == true)
                {
                    Funcionario.Remove(User);
                }
                else
                {
                    Cliente.Remove(User);
                }
        }
        
        static public void Adiciona(Usuario User)
        {
            
            
                if(User.permissao == true)
                {
                    Funcionario.Add(User);
                    Salario.Add(0);
                }
                else
                {
                    Cliente.Add(User);
                }
            
        }

        static public void AdicionaSalario(int indice, int venda)
        {
            
            Salario[indice] += (int)(venda * 0.2);
        }
    }
}
