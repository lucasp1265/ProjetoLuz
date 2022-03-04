using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLuz
{
    
    public class Bebidas : Produtos
    {
        public string[] bebidasNomes = {"Nenhum Item", "Água", "Refrigerante", "Vodka" };
        public int[] precos = {0, 5, 10, 49 };

        public Bebidas()
        {
           
        }
        public string[] BebidasNomes
        {
            get { return bebidasNomes; }
            set { bebidasNomes = value; }
        }
        public int Desconto(int quantidadeBebidas)
        {
            if(quantidadeBebidas != 0)
            {
                return (int)(PrecoCarrinho * 0.9);
            }
            else
            {
                return PrecoCarrinho;
            }
        }

       

        // Soma a variável PrecoCarrinho com a quantidade recebida vezes o preço do produto e faz o desconto
        // caso comprar comida e bebida juntos
        public override void CalculaPreco(int quantidade, int indice)
        {

            PrecoCarrinho += (int)(precos[indice] * quantidade * 0.9);
            Desconto(quantidade);

        }
    }
   
   
    
}
