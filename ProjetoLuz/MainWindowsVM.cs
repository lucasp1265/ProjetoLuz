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

        public MainWindowsVM()
        {

            
            IniciaComando();
            ClienteFuncionario.Inicia();


        }




        public void IniciaComando()
        {
            Comando = new RelayCommand((object _) =>
            {
                
                 JanelaCadastro newWindow = new JanelaCadastro();
                 newWindow.Show();

            });

            ComandoCompra = new RelayCommand((object _) =>
            {

                JanelaCompra newWindow2 = new JanelaCompra();
                newWindow2.Show();

            });
        }


        
    }
    

}
