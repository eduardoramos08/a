namespace CARDAPIO_POO;
using CARDAPIO_POO;


public partial class Form1 : Form
{
    double total = 0;
    string nomeDoCliente = "";
    public Form1()
    {
        InitializeComponent();
    }


    private void adicionarBtn_Click(object sender, EventArgs e)
    {
        // if (listBox1.SelectedItem == null)
        if (listViewCardapio.SelectedItems.Count == 0) // Alterado
        {
            MessageBox.Show("Selecione o item do cardápio para adicionar.");
            return;
        }

        // Produto produtoSelecionadoDoCardapio = (Produto)listBox1.SelectedItem;
        ListViewItem itemSelecionadoCardapio = listViewCardapio.SelectedItems[0]; // Alterado
        Produto produtoSelecionadoDoCardapio = (Produto)itemSelecionadoCardapio.Tag; // Alterado

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

        // Lógica de aviso de estoque baixo (pode manter ou refinar)
        if (produtoSelecionadoDoCardapio.Quantidade <= 5 && (produtoSelecionadoDoCardapio.Quantidade - quantidadeDesejada) < 5 && quantidadeDesejada > 0)
        {
            MessageBox.Show($"Aviso: Estoque de {produtoSelecionadoDoCardapio.Descricao.TrimEnd(' ', '-')} está baixo!");
        }

        // ItemCarrinho itemExistenteNoCarrinho = null;
        ListViewItem lviCarrinhoExistente = null; // Para encontrar o ListViewItem no carrinho
        ItemCarrinho itemExistenteNoCarrinho = null;

        // foreach (var itemObj in listBox2.Items)
        foreach (ListViewItem lvi in listViewCarrinho.Items) // Alterado
        {
            // if (itemObj is ItemCarrinho ic)
            if (lvi.Tag is ItemCarrinho ic) // Alterado
            {
                if (ic.ProdutoAdicionado.Codigo == produtoSelecionadoDoCardapio.Codigo)
                {
                    itemExistenteNoCarrinho = ic;
                    lviCarrinhoExistente = lvi; // Guarda o ListViewItem
                    break;
                }
            }
        }

        if (itemExistenteNoCarrinho != null && lviCarrinhoExistente != null)
        {
            itemExistenteNoCarrinho.QuantidadeNoCarrinho += quantidadeDesejada;
            // Atualizar o ListViewItem existente no carrinho
            lviCarrinhoExistente.SubItems[1].Text = itemExistenteNoCarrinho.QuantidadeNoCarrinho.ToString(); // Qtd.
            lviCarrinhoExistente.SubItems[3].Text = (itemExistenteNoCarrinho.ProdutoAdicionado.Preco * itemExistenteNoCarrinho.QuantidadeNoCarrinho).ToString("F2"); // Subtotal
        }
        else
        {
            ItemCarrinho novoItemCarrinho = new ItemCarrinho
            {
                ProdutoAdicionado = produtoSelecionadoDoCardapio,
                QuantidadeNoCarrinho = quantidadeDesejada
            };

            ListViewItem lviNovoCarrinho = new ListViewItem(novoItemCarrinho.ProdutoAdicionado.Descricao.TrimEnd(' ', '-')); // Coluna 1: Produto
            lviNovoCarrinho.SubItems.Add(novoItemCarrinho.QuantidadeNoCarrinho.ToString()); // Coluna 2: Qtd.
            lviNovoCarrinho.SubItems.Add(novoItemCarrinho.ProdutoAdicionado.Preco.ToString("F2")); // Coluna 3: Preço Unit.
            lviNovoCarrinho.SubItems.Add((novoItemCarrinho.ProdutoAdicionado.Preco * novoItemCarrinho.QuantidadeNoCarrinho).ToString("F2")); // Coluna 4: Subtotal
            lviNovoCarrinho.Tag = novoItemCarrinho; // Armazena o objeto ItemCarrinho

            listViewCarrinho.Items.Add(lviNovoCarrinho); // Alterado
        }

        total += produtoSelecionadoDoCardapio.Preco * quantidadeDesejada;
        totalTxt.Text = "Seu total é R$ " + total.ToString("F2");

        produtoSelecionadoDoCardapio.Quantidade -= quantidadeDesejada;

        // Atualizar o item no listViewCardapio (estoque)
        // As colunas são base 0. Se "Estoque" é a 3ª coluna, o índice é 2.
        // Verifique a ordem das colunas que você definiu no Designer:
        // Código (0), Descrição (1), Estoque (2), Preço (3) ...
        itemSelecionadoCardapio.SubItems[2].Text = produtoSelecionadoDoCardapio.Quantidade.ToString(); // Atualiza o estoque

        // AtualizarListBox(listBox1); // Removido ou comentado
        quantidadeTxt.Clear();
    }


    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
     
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Limpar itens antigos (caso o Load seja chamado mais de uma vez, improvável aqui)
        listViewCardapio.Items.Clear();

        // Criar uma lista de produtos (mesma de antes)
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
        new Produto { Codigo = 11, Quantidade = 12, Descricao = "Hambúrguer com queijo - ", Preco = 9, Custo = 6 },
        new Produto { Codigo = 12, Quantidade = 23, Descricao = "X - Tudo - ", Preco = 12, Custo = 7 }
    };

        foreach (Produto p in produtos)
        {
            ListViewItem item = new ListViewItem(p.Codigo.ToString()); // Coluna 1: Código
            item.SubItems.Add(p.Descricao.TrimEnd(' ', '-'));        // Coluna 2: Descrição
            item.SubItems.Add(p.Quantidade.ToString());             // Coluna 3: Estoque
            item.SubItems.Add(p.Preco.ToString("F2"));              // Coluna 4: Preço
                                                                    // Se você adicionou a coluna Custo no Designer:
                                                                    // item.SubItems.Add(p.Custo.ToString("F2"));           // Coluna 5: Custo

            item.Tag = p; // IMPORTANTE: Armazenar o objeto Produto completo na Tag do item
            listViewCardapio.Items.Add(item);
        }
    }

    private void removerBtn_Click(object sender, EventArgs e)
    {
        // if (listBox2.SelectedItem == null)
        if (listViewCarrinho.SelectedItems.Count == 0) // Alterado
        {
            MessageBox.Show("Selecione o item do carrinho para remover.");
            return;
        }

        // ItemCarrinho itemCarrinhoSelecionado = (ItemCarrinho)listBox2.SelectedItem;
        ListViewItem itemSelecionadoCarrinhoLVI = listViewCarrinho.SelectedItems[0]; // Alterado
        ItemCarrinho itemCarrinhoSelecionado = (ItemCarrinho)itemSelecionadoCarrinhoLVI.Tag; // Alterado

        total -= itemCarrinhoSelecionado.ProdutoAdicionado.Preco * itemCarrinhoSelecionado.QuantidadeNoCarrinho;
        totalTxt.Text = "Seu total é R$ " + total.ToString("F2");

        itemCarrinhoSelecionado.ProdutoAdicionado.Quantidade += itemCarrinhoSelecionado.QuantidadeNoCarrinho;

        // listBox2.Items.Remove(itemCarrinhoSelecionado);
        listViewCarrinho.Items.Remove(itemSelecionadoCarrinhoLVI); // Alterado

        // Atualizar o estoque no listViewCardapio
        foreach (ListViewItem lviCardapio in listViewCardapio.Items)
        {
            Produto pCardapio = (Produto)lviCardapio.Tag;
            if (pCardapio.Codigo == itemCarrinhoSelecionado.ProdutoAdicionado.Codigo)
            {
                // Mesma lógica de índice da coluna de estoque que no adicionarBtn_Click
                lviCardapio.SubItems[2].Text = pCardapio.Quantidade.ToString(); // Atualiza Estoque
                break; // Encontrou o produto, pode sair do loop
            }
        }
        // AtualizarListBox(listBox1); // Removido ou comentado
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

        // if (listBox2.Items.Count == 0)
        if (listViewCarrinho.Items.Count == 0) // Alterado
        {
            MessageBox.Show("O carrinho está vazio. Adicione itens para finalizar a compra.");
            return;
        }

        double valorRecebido;
        if (!double.TryParse(dinheiroRecebidoTxt.Text, out valorRecebido) || valorRecebido < 0)
        {
            MessageBox.Show("O valor recebido é inválido.");
            dinheiroRecebidoTxt.Focus();
            return;
        }
        if (valorRecebido < total)
        {
            MessageBox.Show("O valor recebido é insuficiente.");
            dinheiroRecebidoTxt.Focus();
            return;
        }

        double troco = valorRecebido - total;

        string itensCompradosStr = "Itens Comprados:\n";
        // foreach (ItemCarrinho item in listBox2.Items)
        foreach (ListViewItem lvi in listViewCarrinho.Items) // Alterado
        {
            ItemCarrinho item = (ItemCarrinho)lvi.Tag; // Alterado
            itensCompradosStr += $"{item.ProdutoAdicionado.Descricao.TrimEnd(' ', '-')} - Qtd: {item.QuantidadeNoCarrinho} - Subtotal: R$ {(item.ProdutoAdicionado.Preco * item.QuantidadeNoCarrinho):F2}\n";
        }

        MessageBox.Show(
            $"Compra finalizada!\n" +
            $"\nCliente: {nomeDoCliente}\n" +
            $"\nData e Hora: {dataHora}\n" +
            $"\n{itensCompradosStr}" +
            $"\nTotal: R$ {total:F2}" +
            $"\nValor Recebido: R$ {valorRecebido:F2}" +
            $"\nTroco: R$ {troco:F2}",
            "Recibo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        total = 0;
        totalTxt.Text = "Seu total é R$ 0,00";
        // listBox2.Items.Clear();
        listViewCarrinho.Items.Clear(); // Alterado
        dinheiroRecebidoTxt.Clear();
        Troco.Text = "R$ 0,00";
        nomeTxt.Clear();
        nomeDoCliente = "";
        quantidadeTxt.Clear();
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

    private void AtualizarListBox(ListBox listBox)
    {

        object[] items = new object[listBox.Items.Count];
        listBox.Items.CopyTo(items, 0);
        listBox.Items.Clear();
        listBox.Items.AddRange(items);

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

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }
    private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

}

