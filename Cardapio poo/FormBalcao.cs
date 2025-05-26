using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CARDAPIO_POO;

namespace CARDAPIO_POO
{
    public partial class FormBalcao : Form
    {
        public FormBalcao()
        {
            InitializeComponent();
            foreach (Pedido produto in Repositorio.listaPedidos)
            {
                listBox1.Items.Add(produto);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
