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
        public struct PrecoEItem
        {
            public int[] Preco = new int[4];
            public string[] Item = new string[4];

            public PrecoEItem(string[] produtos, int[] preco)
            {
                Item[0] = "Nenhum Item";
                Preco[0] = 0;
                for(int i = 1; i < 4; i++)
                {
                    Item[i] = produtos[i];
                    Preco[i] = preco[i];
                }
            }

        public int PrecoCarrinho;

        public Produtos()
        {
           
           
        }
        abstract public void CalculaPreco(int indice, int quantidade);

        public void CalculaPreco(int quantidade, string item)
        {
            int count = 0;
            while (item != Itens.Item[count])
            {
                count++;
            }
            preco += (Itens.Preco[count]*quantidade);
        }

    }
}
