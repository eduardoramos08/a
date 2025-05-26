namespace CARDAPIO_POO
{
    public class Produto
    {
        private int codigo;
        private string descricao;
        private int quantidade;
        private double preco;
        private double custo;


        public Produto()
        {
            codigo = 0;
            descricao = string.Empty;
            quantidade = 0;
            preco = 0;
            custo = 0;

        }

        public Produto(int codigo, string descricao, int quantidade, double preco, double custo, double total)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.preco = preco;
            this.custo = custo;

        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public double Custo
        {
            get { return custo; }
            set { custo = value; }
        }


        public override string ToString()
        {
            return $"{Codigo} - {Descricao} / {Quantidade} un. - Preço: {Preco:F2} | Custo: {Custo}";
        }
    }
}
