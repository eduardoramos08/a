namespace CARDAPIO_POO
{
    public class Produto
    {
        private int codigo;
        private string descricao;
        private int quantidade;
        private decimal preco;
        private decimal custo;
        private bool isChapa; 
            

        public Produto()
        {
            codigo = 0;
            descricao = string.Empty;
            quantidade = 0;
            preco = 0;
            custo = 0;
            isChapa = false;

        }

        public Produto(int codigo, string descricao, int quantidade, decimal preco, decimal custo, double total, bool isChapa)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.preco = preco;
            this.custo = custo;
            this.isChapa = isChapa;
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
        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public decimal Custo
        {
            get { return custo; }
            set { custo = value; }
        }
        public bool IsChapa
        {
            get { return isChapa; }
            set { isChapa = value; }
        }

        public override string ToString()
        {
            return $"{Codigo} - {Descricao} / {Quantidade} un. - Preço: {Preco:F2} | Custo: {Custo}";
        }
    }
}
