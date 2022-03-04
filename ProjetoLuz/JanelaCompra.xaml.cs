using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetoLuz
{
    /// <summary>
    /// Lógica interna para NewWindow2.xaml
    /// </summary>
    public partial class JanelaCompra : Window
    {
        public JanelaCompraVM janelacompra;
        public JanelaCompra()
        {
            janelacompra = new JanelaCompraVM();
            DataContext = janelacompra;
            InitializeComponent();
        }


        //Somas os valores dos preços e envia eles para a classe JanelaCompraVM
        public void Recebeprecos(int precos1, int precos2, int precos3, int precos4)
        {
            janelacompra.Recebe(precos1 + precos2 + precos3 + precos4);
        }
    }
}
