using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjetoLuz
{
    public class JanelaCompraVM
    {
        public ICommand Preco { get; private set; }

        public string Senha { get; set; }

        public int IndiceVenda { get; set; }

        public int PrecoTotal;

        public int IndiceSenha { get; set; }

        public JanelaCompraVM()
        {
            IniciaComando();
        }

        public void IniciaComando()
        {
            Preco = new RelayCommand((object _) =>
            {
               //Chama a função de salario para o funcionario selecionado
                ClienteFuncionario.AdicionaSalario(IndiceVenda, PrecoTotal);
                
        
            }, (object _) =>
            {
                //Verifica se a senha inserida é igual a do cadastro
                return ClienteFuncionario.Cliente[IndiceSenha].Password == Senha;

            });
        }

        //Método para receber o valor total da classe JanelaCompra
        public void Recebe(int preco)
        {
            PrecoTotal = preco;
        }

    }
}
