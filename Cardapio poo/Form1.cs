namespace CARDAPIO_POO
{
    public partial class Form1 : Form
    {
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione o item para adicionar");
            }
            else
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                Produto produto = (Produto)listBox1.SelectedItem;
                total += produto.Preco;
                totalTxt.Text = "Seu total é " + total.ToString("F2");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Preco";
            listBox2.DisplayMember = "Nome";
            listBox2.ValueMember = "Preco";

            listBox1.Items.Add(new Produto { Nome = "Coxinha - R$ 5,00", Preco = 5 });
            listBox1.Items.Add(new Produto { Nome = "Pastel - R$ 6,00 ", Preco = 6 });
            listBox1.Items.Add(new Produto { Nome = "Refrigerante - R$ 4,50 ", Preco = 4.5 });
            listBox1.Items.Add(new Produto { Nome = "Suco - R$ 3,00", Preco = 3 });
            listBox1.Items.Add(new Produto { Nome = "Brigadeiro - R$ 2,00 ", Preco = 2 });
        }

        private void removerBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione o item para remover");
            }
            else
            {
                Produto produto = (Produto)listBox2.SelectedItem;
                total -= produto.Preco;
                totalTxt.Text = "Seu total é " + total.ToString("F2");
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        public class Produto
        {
            public string Nome { get; set; }
            public double Preco { get; set; }
        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O total do seu pedido foi: " + total.ToString("F2"));
            total = 0;
            listBox2.Items.Clear();
        }
    }
}