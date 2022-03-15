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

        static public string produtos;

        public Bebidas produtosBanco;

        public JanelaCompraVM()
        {
            produtosBanco = new Bebidas();
            IniciaComando();
        }

        public void IniciaComando()
        {
            Preco = new RelayCommand((object _) =>
            {
                if(produtos!=null)
                produtosBanco.AdicionaProduto(IndiceSenha, IndiceVenda, produtos, MainWindowsVM.conexaoTeste);
                produtos = null;
                
                
        
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
