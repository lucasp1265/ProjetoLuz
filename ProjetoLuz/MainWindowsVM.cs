using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjetoLuz
{
    public class MainWindowsVM { 
        
        public ICommand Comando {get; private set;}
        public ICommand ComandoCompra { get; private set; }
        public ICommand ComandoCarrinho { get; private set; }

        public int QuantidadeBebida { get; set; }
        public int QuantidadeLimpeza { get; set; }
        public int QuantidadeComida { get; set; }
        public int QuantidadeFruta { get; set; }


        public int bebida { get; set; }
        public int comida { get; set; }
        public int fruta { get; set; }
        public int limpeza { get; set; }

        public Bebidas bebidasobj { get; set; }
        public Comidas comidasobj { get; set; }
        public Frutas frutasobj { get; set; }
        public Limpeza limpezasobj { get; set; }

        public MainWindowsVM()
        {

            
            IniciaComando();
            ClienteFuncionario.Inicia();
            IniciaCarrinho();


        }

        //Inicializa os objetos dos produtos 
        public void IniciaCarrinho()
        {
            bebidasobj = new Bebidas();
            comidasobj = new Comidas();
            limpezasobj = new Limpeza();
            frutasobj = new Frutas();
        }

        public void IniciaComando()
        {
            //Comando que cria uma nova Janela para o cadastro
            Comando = new RelayCommand((object _) =>
            {
                
                 JanelaCadastro newWindow = new JanelaCadastro();
                 newWindow.Show();

            });

            //Comando que cria uma nova janela para finalizar a compra
            ComandoCompra = new RelayCommand((object _) =>
            {

                JanelaCompra newWindow2 = new JanelaCompra();
                newWindow2.Show();
                newWindow2.Recebeprecos(bebidasobj.PrecoCarrinho,comidasobj.PrecoCarrinho,frutasobj.PrecoCarrinho,limpezasobj.PrecoCarrinho);

            }, (object _) =>
            {

                return (ClienteFuncionario.Funcionario.Count != 0) && (ClienteFuncionario.Cliente.Count != 0);

            });

            //Comando que Recebe as quantidades e os produtos selecionados e retorna o valor de cada categoria
            ComandoCarrinho = new RelayCommand((object _) =>
            {

                bebidasobj.CalculaPreco(QuantidadeBebida, bebida);
                comidasobj.CalculaPreco(QuantidadeComida, comida);
                frutasobj.CalculaPreco(QuantidadeFruta, fruta);
                limpezasobj.CalculaPreco(QuantidadeLimpeza,limpeza);

            }, (object _) =>
            {

                return (ClienteFuncionario.Funcionario.Count != 0)&&(ClienteFuncionario.Cliente.Count!=0);

            });
        }


        
    }
    

}
