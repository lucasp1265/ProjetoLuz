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
        abstract public void CalculaPreco(int indice, int quantidade);


    }
}
