using static CARDAPIO_POO.Pedido;

namespace CARDAPIO_POO;
public partial class Form1 : Form
{

    decimal total = 0;
    string nomeDoCliente = "";
    List<ItemPedido> produtos1 = new List<ItemPedido>();


    public Form1()
    {
        InitializeComponent();
    }


    private void Form1_Load(object sender, EventArgs e)
    {
        comboBoxFormaPagamento.Items.AddRange(new string[] { "Dinheiro", "Cartão de Débito", "Cartão de Crédito", "Pix", "Vale Alimentação" });
        comboBoxFormaPagamento.SelectedIndex = 3;

        var produtos = new List<Produto>
    {
        new Produto { Codigo = 1, Quantidade = 20, Descricao = "Pão de queijo ", Preco = 6, Custo = 4.00m },
        new Produto { Codigo = 2, Quantidade = 30, Descricao = "Coxinha - ", Preco = 5, Custo = 2.5m },
        new Produto { Codigo = 3, Quantidade = 30, Descricao = "Risole - ", Preco = 4, Custo = 2.5m },
        new Produto { Codigo = 4, Quantidade = 30, Descricao = "Esfiha de calabresa - ", Preco = 4.00m, Custo = 2.5m },
        new Produto { Codigo = 5, Quantidade = 2, Descricao = "Suco natural (300ml) - ", Preco = 4.00m, Custo = 2.00m },
        new Produto { Codigo = 6, Quantidade = 5, Descricao = "Refrigerante Lata - ", Preco = 4.50m, Custo = 3.00m },
        new Produto { Codigo = 7, Quantidade = 5, Descricao = "Àgua mineral(500ml) - ", Preco = 3.00m, Custo = 1.00m },
        new Produto { Codigo = 8, Quantidade = 25, Descricao = "Pastel de carne - ", Preco = 6.00m, Custo = 4.00m },
        new Produto { Codigo = 9, Quantidade = 35, Descricao = "Patel de queijo - ", Preco = 6.50m, Custo = 4.50m },
        new Produto { Codigo = 10, Quantidade = 10, Descricao = "Hambúrguer simples", Preco = 8.00m, Custo = 5.00m },
        new Produto { Codigo = 11, Quantidade = 12, Descricao = "Hambúrguer com queijo  ", Preco = 9.00m, Custo = 6.00m },
        new Produto { Codigo = 12, Quantidade = 23, Descricao = "X - Tudo - ", Preco = 12.00m, Custo = 7.00m }};

        foreach (Produto p in produtos)
        {
            ListViewItem item = new ListViewItem(p.Codigo.ToString());
            item.SubItems.Add(p.Descricao.TrimEnd(' ', '-'));
            item.SubItems.Add(p.Quantidade.ToString());
            item.SubItems.Add(p.Preco.ToString("F2"));
            item.Tag = p;
            listViewCardapio.Items.Add(item);
        }
    }

    private void adicionarBtn_Click(object sender, EventArgs e)
    {
        if (listViewCardapio.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selecione o item do cardápio para adicionar.");
            return;
        }

        ListViewItem itemSelecionadoCardapio = listViewCardapio.SelectedItems[0];
        Produto produtoSelecionadoDoCardapio = (Produto)itemSelecionadoCardapio.Tag;

        int quantidadeDesejada;
        if (!int.TryParse(quantidadeTxt.Text, out quantidadeDesejada) || quantidadeDesejada <= 0)
        {
            MessageBox.Show("Digite uma quantidade válida.");
            quantidadeTxt.Focus();
            return;
        }

        if (produtoSelecionadoDoCardapio.Quantidade < quantidadeDesejada)
        {
            MessageBox.Show("Quantidade insuficiente no estoque. Estoque disponível: " + produtoSelecionadoDoCardapio.Quantidade);
            return;
        }

        if (produtoSelecionadoDoCardapio.Quantidade <= 5 && (produtoSelecionadoDoCardapio.Quantidade - quantidadeDesejada) < 5 && quantidadeDesejada > 0)
        {
            MessageBox.Show($"Aviso: Estoque de {produtoSelecionadoDoCardapio.Descricao.TrimEnd(' ', '-')} está acabando");
        }

        ListViewItem lviCarrinhoExistente = null;
        ItemPedido itemExistenteNoCarrinho = null;
        foreach (ListViewItem lvi in listViewCarrinho.Items)
        {

            if (lvi.Tag is ItemPedido ic)
            {
                if (ic.ProdutoAdicionado.Codigo == produtoSelecionadoDoCardapio.Codigo)
                {
                    itemExistenteNoCarrinho = ic;
                    lviCarrinhoExistente = lvi;
                    break;
                }
            }
        }

        if (itemExistenteNoCarrinho != null && lviCarrinhoExistente != null)
        {
            itemExistenteNoCarrinho.QuantidadeNoCarrinho += quantidadeDesejada;
            lviCarrinhoExistente.SubItems[1].Text = itemExistenteNoCarrinho.QuantidadeNoCarrinho.ToString();
            lviCarrinhoExistente.SubItems[3].Text = (itemExistenteNoCarrinho.ProdutoAdicionado.Preco * itemExistenteNoCarrinho.QuantidadeNoCarrinho).ToString("F2");
        }
        else
        {

            ItemPedido novoItemCarrinho = new ItemPedido
            {

                ProdutoAdicionado = produtoSelecionadoDoCardapio,
                QuantidadeNoCarrinho = quantidadeDesejada
            };
            produtos1.Add(novoItemCarrinho);

            ListViewItem lviNovoCarrinho = new ListViewItem(novoItemCarrinho.ProdutoAdicionado.Descricao.TrimEnd(' ', '-'));
            lviNovoCarrinho.SubItems.Add(novoItemCarrinho.QuantidadeNoCarrinho.ToString());
            lviNovoCarrinho.SubItems.Add(novoItemCarrinho.ProdutoAdicionado.Preco.ToString("F2"));
            lviNovoCarrinho.SubItems.Add((novoItemCarrinho.ProdutoAdicionado.Preco * novoItemCarrinho.QuantidadeNoCarrinho).ToString("F2"));
            lviNovoCarrinho.Tag = novoItemCarrinho;

            listViewCarrinho.Items.Add(lviNovoCarrinho);
        }

        total += produtoSelecionadoDoCardapio.Preco * quantidadeDesejada;
        totalTxt.Text = "Seu total é R$ " + total.ToString("F2");

        produtoSelecionadoDoCardapio.Quantidade -= quantidadeDesejada;
        itemSelecionadoCardapio.SubItems[2].Text = produtoSelecionadoDoCardapio.Quantidade.ToString();

        quantidadeTxt.Clear();
    }
    private void removerBtn_Click(object sender, EventArgs e)
    {
        if (listViewCarrinho.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selecione o item do carrinho para remover.");
            return;
        }


        ListViewItem itemSelecionadoCarrinhoLVI = listViewCarrinho.SelectedItems[0];
        ItemPedido itemCarrinhoSelecionado = (ItemPedido)itemSelecionadoCarrinhoLVI.Tag;

        total -= itemCarrinhoSelecionado.ProdutoAdicionado.Preco * itemCarrinhoSelecionado.QuantidadeNoCarrinho;
        totalTxt.Text = "Seu total é R$ " + total.ToString("F2");

        itemCarrinhoSelecionado.ProdutoAdicionado.Quantidade += itemCarrinhoSelecionado.QuantidadeNoCarrinho;

        listViewCarrinho.Items.Remove(itemSelecionadoCarrinhoLVI);

        foreach (ListViewItem lviCardapio in listViewCardapio.Items)
        {
            Produto pCardapio = (Produto)lviCardapio.Tag;
            if (pCardapio.Codigo == itemCarrinhoSelecionado.ProdutoAdicionado.Codigo)
            {
                lviCardapio.SubItems[2].Text = pCardapio.Quantidade.ToString();
                break;
            }
        }

        AtualizarTroco();
    }

    private void finalizarBtn_Click(object sender, EventArgs e)
    {
        string dataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        if (string.IsNullOrWhiteSpace(nomeDoCliente))
        {
            MessageBox.Show("Por favor, insira o nome do cliente.");
            nomeTxt.Focus();
            return;
        }

        if (listViewCarrinho.Items.Count == 0)
        {
            MessageBox.Show("O carrinho está vazio. Adicione itens para finalizar a compra.");
            return;
        }

        string formaPagamento = comboBoxFormaPagamento.SelectedItem.ToString();
        decimal valorRecebido = 0m;
        decimal troco = 0m;

        switch (formaPagamento)
        {
            case "Dinheiro":
                if (!decimal.TryParse(dinheiroRecebidoTxt.Text, out valorRecebido) || valorRecebido < total)
                {
                    MessageBox.Show("Valor recebido inválido ou insuficiente.");
                    dinheiroRecebidoTxt.Focus();
                    return;
                }
                troco = valorRecebido - total;
                break;

            case "Cartão de Débito":
            case "Cartão de Crédito":
            case "Pix":
            case "Vale Alimentação":
                dinheiroRecebidoTxt.Enabled = false;
                valorRecebido = total;
                break;
        }

        string itensCompradosStr = "Itens Comprados:\n";
        foreach (ListViewItem lvi in listViewCarrinho.Items)
        {
            ItemPedido item = (ItemPedido)lvi.Tag;
            itensCompradosStr += $"{item.ProdutoAdicionado.Descricao.TrimEnd(' ', '-')} - Qtd: {item.QuantidadeNoCarrinho} - Subtotal: R$ {(item.ProdutoAdicionado.Preco * item.QuantidadeNoCarrinho):F2}\n";
        }

        MessageBox.Show(
            $"Compra finalizada!\n\n" +
            $"Cliente: {nomeDoCliente}\n" +
            $"Data e Hora: {dataHora}\n" +
            $"Forma de Pagamento: {formaPagamento}\n" +
            $"\n{itensCompradosStr}\n" +
            $"Total: R$ {total:F2}\n" +
            (formaPagamento == "Dinheiro" ? $"Valor Recebido: R$ {valorRecebido:F2}\nTroco: R$ {troco:F2}" : ""),
            "Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information);



        Pedido pedido = new Pedido
        {
            Nome = nomeTxt.Text,
            carrinho = produtos1,
            date = DateTime.Now,
            Total = total,
            status = btnViagem.Checked ?
         (statusPedido)Enum.Parse(typeof(statusPedido), "Viagem") :
         (statusPedido)Enum.Parse(typeof(statusPedido), "Preparando"),
            FormaPagamento = comboBoxFormaPagamento.SelectedItem.ToString()
        };

        Repositorio.listaPedidos.Add(pedido);
        produtos1 = new List<ItemPedido>();
        LimparCampos();
    }

    private void quantidadeTxt_TextChanged(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(quantidadeTxt.Text))
        {
            if (!int.TryParse(quantidadeTxt.Text, out int quantidade) || quantidade < 0)
            {

            }
        }
    }

    private void LimparCampos()
    {
        total = 0;
        totalTxt.Text = "Seu total é R$ 0,00";
        listViewCarrinho.Items.Clear();
        dinheiroRecebidoTxt.Clear();
        Troco.Text = "R$ 0,00";
        nomeTxt.Clear();
        nomeDoCliente = "";
        quantidadeTxt.Clear();
        comboBoxFormaPagamento.SelectedIndex = 3;
    }



    private void dinheiroRecebido_TextChanged(object sender, EventArgs e)
    {
        AtualizarTroco();
    }

    private void AtualizarTroco()
    {
        decimal valorRecebido;

        if (string.IsNullOrWhiteSpace(dinheiroRecebidoTxt.Text))
        {
            Troco.Text = "R$ 0,00";
            return;
        }

        if (!decimal.TryParse(dinheiroRecebidoTxt.Text, out valorRecebido) || valorRecebido < 0)
        {
            Troco.Text = "Valor inválido";
            return;
        }

        if (valorRecebido < total)
        {
            Troco.Text = "Valor insuficiente.";
            return;
        }

        decimal trocoCalculado = valorRecebido - total;
        Troco.Text = "R$" + trocoCalculado.ToString("F2");
    }


    private void TrocoTxt_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void nomeTxt_TextChanged(object sender, EventArgs e)
    {
        nomeDoCliente = nomeTxt.Text.Trim();
    }
    private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

    private void comboBoxFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxFormaPagamento.SelectedItem == null) return;

        string formaPagamento = comboBoxFormaPagamento.SelectedItem.ToString();

        if (formaPagamento == "Dinheiro")
        {
            dinheiroRecebidoTxt.Enabled = true;
            dinheiroRecebidoTxt.Visible = true;
            Troco.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            AtualizarTroco();
        }
        else
        {
            dinheiroRecebidoTxt.Enabled = false;
            dinheiroRecebidoTxt.Visible = false;
            Troco.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            dinheiroRecebidoTxt.Clear();
            Troco.Text = "R$ 0,00";
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void cardapioTxt_Click(object sender, EventArgs e)
    {

    }

    private void Troco_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        FormBalcao formBalcao = new FormBalcao();
        formBalcao.Show();
    }

    private void btnViagem_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {

    }
}
