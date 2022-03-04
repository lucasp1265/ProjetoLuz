using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLuz
{
    public class Frutas : Produtos
    {
        public string[] frutas = { "Nenhum Item", "Abacaxi", "Maçã", "Melancia" };
        public int[] precos = { 0, 22, 7, 5 };

        public Frutas()
        {

        }
        public override string CalculaPreco(int quantidade, int indice)
        {

            PrecoCarrinho = PrecoCarrinho + (precos[indice] * quantidade);

            return frutas[indice];

        }
    }
}
