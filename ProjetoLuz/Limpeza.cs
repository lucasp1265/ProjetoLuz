using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLuz
{
    public class Limpeza : Produtos
    {
        public string[] limpezas = { "Nenhum Item", "Desinfetante", "Água Sanitária", "Esponjas" };
        public int[] precos = { 15, 25, 6 };

        public Limpeza()
        {
        }

        public int Desconto(int quantidade)
        {
            if (quantidade >= 3)
            {
                return (int)(PrecoCarrinho * 0.8);
            }
            else
            {
                return PrecoCarrinho;
            }
        }

        public override void CalculaPreco(int quantidade, int indice)
        {

            PrecoCarrinho += (int)(precos[indice] * quantidade * 0.8);
            PrecoCarrinho = Desconto(quantidade);

        }
    }
}
