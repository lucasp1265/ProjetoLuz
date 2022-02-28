using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLuz
{
    //Todas as 4 classes tem o mesmo corpo, podendo ser modificado o valor do desconto, produtos de cada uma
    // e seu preço separadamente
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

       

        // Soma a variável PrecoCarrinho com a quantidade recebida vezes o preço do produto
        public override void CalculaPreco(int quantidade, int indice)
        {

            PrecoCarrinho += (int)(precos[indice] * quantidade * 0.9);

        }
    }
   public class Comidas : Produtos
    {
        public string[] comidas = { "Nenhum Item", "Hamburguer", "Rosquinha", "Bolacha" };
        public int[] precos = {0, 22, 7, 5 };

        public Comidas()
        {
        }
        
        public override void CalculaPreco(int quantidade, int indice)
        {
            
            PrecoCarrinho += (int)(precos[indice] * quantidade * 0.95);

        }
    }
    public class Limpeza : Produtos
    {
        public string[] limpezas = { "Nenhum Item", "Desinfetante", "Água Sanitária", "Esponjas" };
        public int[] precos = { 15, 25, 6 };

        public Limpeza()
        {
        }
       
        public override void CalculaPreco(int quantidade, int indice)
        {
            
            PrecoCarrinho += (int)(precos[indice] * quantidade * 0.8);

        }
    }
    public class Frutas : Produtos
    {
        public string[] frutas = { "Nenhum Item", "Abacaxi", "Maçã", "Melancia" };
        public int[] precos = {0, 22, 7, 5 };

        public Frutas()
        {
            
        }
        public override void CalculaPreco(int quantidade, int indice)
        {
          
            PrecoCarrinho = PrecoCarrinho + (precos[indice] * quantidade);

        }
    }
}
