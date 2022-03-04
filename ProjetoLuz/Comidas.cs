using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLuz
{
    public class Comidas : Produtos
    {
        public string[] comidas = { "Nenhum Item", "Hamburguer", "Rosquinha", "Bolacha" };
        public int[] precos = { 0, 22, 7, 5 };

        public Comidas()
        {
        }


        public override void CalculaPreco(int quantidade, int indice)
        {

            PrecoCarrinho += (int)(precos[indice] * quantidade * 0.95);

        }
    }
}
