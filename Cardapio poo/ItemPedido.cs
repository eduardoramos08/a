﻿namespace CARDAPIO_POO
{
    internal class ItemCarrinho
    {

        public Produto ProdutoAdicionado { get; set; }
        public int QuantidadeNoCarrinho { get; set; }


        public override string ToString()
        {

            string descricaoLimpa = ProdutoAdicionado.Descricao.TrimEnd(' ', '-');
            return $"{descricaoLimpa} - Quantidade: {QuantidadeNoCarrinho}";
        }
    }
}

