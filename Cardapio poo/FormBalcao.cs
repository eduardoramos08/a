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

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void FormBalcao_Load(object sender, EventArgs e)
        {
            foreach (var pedido in Repositorio.listaPedidos)
            {
                listBox1.Items.Add(pedido);
            }
        }

        private void btnMarcarConcluido_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um pedido para finalizar.");
                return;
            }

            Pedido pedidoSelecionado = (Pedido)listBox1.SelectedItem;
            pedidoSelecionado.status = Pedido.statusPedido.Finalizado;

            AtualizarListaPedidosFinalizados();
        }

        private void AtualizarListaPedidosFinalizados()
        {
            listBox2.Items.Clear();

            foreach (var pedido in Repositorio.listaPedidos)
            {
                if (pedido.status == Pedido.statusPedido.Finalizado)
                {
                    listBox2.Items.Add(pedido);
                }
            }
        }

        private void btnVerDetalhes_Click(object sender, EventArgs e) 
        { 

         if (listBox1.SelectedItem == null)
        {
        MessageBox.Show("Selecione um pedido para ver os detalhes.");
        return;
        }

        Pedido pedidoSelecionado = (Pedido)listBox1.SelectedItem;

        string detalhes = $"Cliente: {pedidoSelecionado.Nome}\n";
        detalhes += $"Data: {pedidoSelecionado.date.ToString("dd/MM/yyyy HH:mm")}\n";
        detalhes += $"Status: {pedidoSelecionado.status}\n";
        detalhes += $"Forma de Pagamento: {pedidoSelecionado.FormaPagamento}\n"; 
        detalhes += $"\nItens:\n";

        foreach (var item in pedidoSelecionado.carrinho)
        {
            detalhes += $" - {item.ProdutoAdicionado.Descricao.TrimEnd(' ', '-')} | Qtde: {item.QuantidadeNoCarrinho} | Subtotal: R$ {(item.ProdutoAdicionado.Preco * item.QuantidadeNoCarrinho):F2}\n";
        }

            detalhes += $"\nTotal: R$ {pedidoSelecionado.Total:F2}";

            MessageBox.Show(detalhes, "Detalhes do Pedido");
        }
    }
}
