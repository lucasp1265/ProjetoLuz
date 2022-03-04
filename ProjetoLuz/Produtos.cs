using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLuz
{
    //Classe abstrata para ser "especializada" nos outros produtos
     public abstract class Produtos
    {
       

        public int PrecoCarrinho;

        public Produtos()
        {
           
           
        }
        public void AdicionaProduto(int indiceCompra, int indiceVenda, string produto)
        {
            ClienteFuncionario.Cliente[indiceCompra].listaProdutos.Add(produto);
            ClienteFuncionario.Funcionario[indiceVenda].listaProdutos.Add(produto);
        }
        abstract public string CalculaPreco(int indice, int quantidade);


    }
}
