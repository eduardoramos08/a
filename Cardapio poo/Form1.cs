namespace CARDAPIO_POO;
public partial class Form1 : Form
{
    double total = 0;
    string nomeDoCliente = "";

    public Form1()
    {
        InitializeComponent();
    }


    private void Form1_Load(object sender, EventArgs e)
    {
        comboBoxFormaPagamento.Items.AddRange(new string[] { "Dinheiro", "Cartão de Débito", "Cartão de Crédito", "Pix", "Vale Alimentação" });

        var produtos = new List<Produto>
    {
        new Produto { Codigo = 1, Quantidade = 20, Descricao = "Pão de queijo ", Preco = 6, Custo = 4 },
        new Produto { Codigo = 2, Quantidade = 30, Descricao = "Coxinha - ", Preco = 5, Custo = 2.5 },
        new Produto { Codigo = 3, Quantidade = 30, Descricao = "Risole - ", Preco = 4, Custo = 2.5 },
        new Produto { Codigo = 4, Quantidade = 30, Descricao = "Esfiha de calabresa - ", Preco = 4, Custo = 2.5 },
        new Produto { Codigo = 5, Quantidade = 2, Descricao = "Suco natural (300ml) - ", Preco = 4, Custo = 2 },
        new Produto { Codigo = 6, Quantidade = 5, Descricao = "Refrigerante Lata - ", Preco = 4.50, Custo = 3 },
        new Produto { Codigo = 7, Quantidade = 5, Descricao = "Àgua mineral(500ml) - ", Preco = 2.50, Custo = 0.75 },
        new Produto { Codigo = 8, Quantidade = 25, Descricao = "Pastel de carne - ", Preco = 6, Custo = 4 },
        new Produto { Codigo = 9, Quantidade = 35, Descricao = "Patel de queijo - ", Preco = 5.5, Custo = 3.5 },
        new Produto { Codigo = 10, Quantidade = 10, Descricao = "Hambúrguer simples", Preco = 8, Custo = 5 },
        new Produto { Codigo = 11, Quantidade = 12, Descricao = "Hambúrguer com queijo  ", Preco = 9, Custo = 6 },
        new Produto { Codigo = 12, Quantidade = 23, Descricao = "X - Tudo - ", Preco = 12, Custo = 7 }};

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
        ItemCarrinho itemExistenteNoCarrinho = null;
        foreach (ListViewItem lvi in listViewCarrinho.Items)
        {

            if (lvi.Tag is ItemCarrinho ic)
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
            ItemCarrinho novoItemCarrinho = new ItemCarrinho
            {
                ProdutoAdicionado = produtoSelecionadoDoCardapio,
                QuantidadeNoCarrinho = quantidadeDesejada
            };

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
        ItemCarrinho itemCarrinhoSelecionado = (ItemCarrinho)itemSelecionadoCarrinhoLVI.Tag;

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

        switch (formaPagamento)
        {
            case "Dinheiro":
                double valorRecebido;
                if (!double.TryParse(dinheiroRecebidoTxt.Text, out valorRecebido) || valorRecebido < total)
                {
                    MessageBox.Show("Valor recebido inválido ou insuficiente.");
                    dinheiroRecebidoTxt.Focus();
                    return;
                }
                break;

            case "Cartão de Débito":
            case "Cartão de Crédito":
            case "Pix":
            case "Vale Alimentação":
                dinheiroRecebidoTxt.Enabled = false;
                break;
        }

        double troco = 0;
        if (formaPagamento == "Dinheiro")
        {
            double valorRecebidoFinal = double.Parse(dinheiroRecebidoTxt.Text);
            troco = valorRecebidoFinal - total;
        }

        string itensCompradosStr = "Itens Comprados:\n";
        foreach (ListViewItem lvi in listViewCarrinho.Items)
        {
            ItemCarrinho item = (ItemCarrinho)lvi.Tag;
            itensCompradosStr += $"{item.ProdutoAdicionado.Descricao.TrimEnd(' ', '-')} - Qtd: {item.QuantidadeNoCarrinho} - Subtotal: R$ {(item.ProdutoAdicionado.Preco * item.QuantidadeNoCarrinho):F2}\n";
        }

        MessageBox.Show(
            $"Compra finalizada!\n\n" +
            $"Cliente: {nomeDoCliente}\n" +
            $"Data e Hora: {dataHora}\n" +
            $"Forma de Pagamento: {formaPagamento}\n" +
            $"\n{itensCompradosStr}\n" +
            $"Total: R$ {total:F2}\n" +
            (formaPagamento == "Dinheiro" ? $"Valor Recebido: R$ {double.Parse(dinheiroRecebidoTxt.Text):F2}\nTroco: R$ {troco:F2}" : ""),
            "Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        dinheiroRecebidoTxt.Enabled = true;
    }



    private void dinheiroRecebido_TextChanged(object sender, EventArgs e)
    {
        AtualizarTroco();
    }

    private void AtualizarTroco()
    {
        double valorRecebido;

        if (!double.TryParse(dinheiroRecebidoTxt.Text, out valorRecebido) || valorRecebido < 0)
        {
            Troco.Text = "R$ 0,00";
            return;
        }

        if (valorRecebido < total)
        {
            Troco.Text = "Valor insuficiente.";
            return;
        }

        double trocoCalculado = valorRecebido - total;
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
        }
        else
        {
            dinheiroRecebidoTxt.Enabled = false;
            dinheiroRecebidoTxt.Visible = false;
            Troco.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
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
}
