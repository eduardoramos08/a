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
        Produto produto = null;

        if (listBox1.SelectedItem != null)
        {
            produto = (Produto)listBox1.SelectedItem;
        }

        if (produto == null)
        {
            MessageBox.Show("Selecione o item para adicionar");
            return;
        }

        int quantidadeDesejada;
        if (!int.TryParse(quantidadeTxt.Text, out quantidadeDesejada) || quantidadeDesejada <= 0)
        {
            MessageBox.Show("Digite uma quantidade válida.");
            return;
        }

        if (produto.Quantidade < quantidadeDesejada)
        {
            MessageBox.Show("Quantidade insuficiente no estoque, Estoque disponível: " + produto.Quantidade);
            return;
        }

        if (produto.Quantidade <= 5)
        {
            MessageBox.Show("Aviso\n Produto acabando!");
        }

        for (int i = 0; i < quantidadeDesejada; i++)
        {
            listBox2.Items.Add(produto);
        }

        total += produto.Preco * quantidadeDesejada;
        totalTxt.Text = "Seu total é R$ " + total.ToString("F2");
        produto.Quantidade -= quantidadeDesejada;

        AtualizarListBox(listBox1);
    }


    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        listBox1.Items.Add(new Produto { Codigo = 1, Quantidade = 20, Descricao = "Pão de queijo ", Preco = 6, Custo = 4 });
        listBox1.Items.Add(new Produto { Codigo = 2, Quantidade = 30, Descricao = "Coxinha - ", Preco = 5, Custo = 2.5 });
        listBox1.Items.Add(new Produto { Codigo = 3, Quantidade = 30, Descricao = "Risole - ", Preco = 4, Custo = 2.5 });
        listBox1.Items.Add(new Produto { Codigo = 4, Quantidade = 30, Descricao = "Esfiha de calabresa - ", Preco = 4, Custo = 2.5 });
        listBox1.Items.Add(new Produto { Codigo = 5, Quantidade = 2, Descricao = "Suco natural (300ml) - ", Preco = 4, Custo = 2 });
        listBox1.Items.Add(new Produto { Codigo = 6, Quantidade = 5, Descricao = "Refrigerante Lata - ", Preco = 4.50, Custo = 3 });
        listBox1.Items.Add(new Produto { Codigo = 7, Quantidade = 5, Descricao = "Àgua mineral(500ml) - ", Preco = 2.50, Custo = 0.75 });
        listBox1.Items.Add(new Produto { Codigo = 8, Quantidade = 25, Descricao = "Pastel de carne - ", Preco = 6, Custo = 4 });
        listBox1.Items.Add(new Produto { Codigo = 9, Quantidade = 35, Descricao = "Patel de queijo - ", Preco = 5.5, Custo = 3.5 });
        listBox1.Items.Add(new Produto { Codigo = 10, Quantidade = 10, Descricao = "Hambúrguer simples", Preco = 8, Custo = 5 });
        listBox1.Items.Add(new Produto { Codigo = 11, Quantidade = 12, Descricao = "Hambúrguer com queijo - ", Preco = 9, Custo = 6 });
        listBox1.Items.Add(new Produto { Codigo = 12, Quantidade = 23, Descricao = "X - Tudo - ", Preco = 12, Custo = 7 });

    }

    private void removerBtn_Click(object sender, EventArgs e)
    {
        if (listBox2.SelectedItem == null)
        {
            MessageBox.Show("Selecione o item do carrinho para remover");
            return;
        }

        Produto produto = (Produto)listBox2.SelectedItem;
        total -= produto.Preco;
        totalTxt.Text = "Seu total é R$ " + total.ToString("F2");

        produto.Quantidade++;

        listBox2.Items.Remove(produto);

        AtualizarListBox(listBox1);
    }

    private void finalizarBtn_Click(object sender, EventArgs e)
    {
        string dataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        if (string.IsNullOrWhiteSpace(nomeDoCliente))
        {
            MessageBox.Show("Por favor, insira o nome do cliente.");
            return;
        }

        double valorRecebido;
        if (!double.TryParse(dinheiroRecebidoTxt.Text, out valorRecebido) || valorRecebido < total)
        {
            MessageBox.Show("O valor recebido é inválido ou insuficiente.");
            return;
        }

        double troco = valorRecebido - total;


        MessageBox.Show(
            $"Compra finalizada\n" +
            $"Cliente: {nomeDoCliente}\n" +
            $"\nData e Hora: {dataHora}" +
            $"\nTotal: R$ {total:F2}" +
            $"\nValor Recebido: R$ {valorRecebido:F2}" +
            $"\nTroco: R$ {troco:F2}");


        total = 0;
        totalTxt.Text = "Seu total é R$ 0,00";
        listBox2.Items.Clear();
        dinheiroRecebidoTxt.Clear();
        Troco.Text = "R$ 0,00";
        nomeTxt.Clear();
        nomeDoCliente = ""; 
        quantidadeTxt.Clear();
    }

    private void quantidadeTxt_TextChanged(object sender, EventArgs e)

    {

        int quantidade;
        if (!int.TryParse(quantidadeTxt.Text, out quantidade))
        {
            MessageBox.Show("Digite um número válido.");
            quantidadeTxt.Focus();
            return;
        }

    }
    private void AtualizarListBox(ListBox listBox)
    {
        for (int i = 0; i < listBox.Items.Count; i++)
        {
            listBox.Items[i] = listBox.Items[i];
        }
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }

    private void dinheiroRecebido_TextChanged(object sender, EventArgs e)
    {
        double valorRecebido;

        if (!double.TryParse(dinheiroRecebidoTxt.Text, out valorRecebido))
        {
            Troco.Text = "R$ 0,00";
            return;
        }

        if (valorRecebido < total)
        {
            Troco.Text = "Valor insuficiente.";
            return;
        }

        double troco = valorRecebido - total;
        Troco.Text = "R$" + troco.ToString("F2");
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
    
}
