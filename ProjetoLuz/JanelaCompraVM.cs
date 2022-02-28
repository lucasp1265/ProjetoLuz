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

        public string PrecoTela { get; set; }

        public int PrecoTotal;

        public int IndiceSenha { get; set; }

        public JanelaCompraVM()
        {
            IniciaComando();
        }

        public void IniciaComando()
        {
            Preco = new RelayCommand((object _) =>
            {
                //Converte o valor da compra para string e notifica a mudança na variável
                PrecoTela = PrecoTotal.ToString();
                Notifica(nameof(PrecoTela));

            }, (object _) =>
            {
                //Verifica se a senha inserida é igual a do cadastro
                return ClienteFuncionario.Cliente[IndiceSenha].Password == Senha;

            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void Notifica(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Método para receber o valor total da classe JanelaCompra
        public void Recebe(int preco)
        {
            PrecoTotal = preco;
        }

    }
}
