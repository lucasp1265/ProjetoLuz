using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetoLuz
{
    //Classe abstrata para ser "especializada" nos outros produtos
     public abstract class Produtos
    {
       

        public int PrecoCarrinho;

        public Produtos()
        {
           
           
        }
        public void AdicionaProduto(int indiceCompra, int indiceVenda, string produto, IConexao conexao)
        {

            try
            {
                conexao.InsereProdutos(produto, ClienteFuncionario.Cliente[indiceCompra].User, ClienteFuncionario.Funcionario[indiceVenda].User);
            }
            catch
            {
                MessageBox.Show("Erro inserir produtos");
            }
        }
        abstract public void CalculaPreco(int indice, int quantidade);


    }
}
