using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARDAPIO_POO
{
    
    public class Pedido
    {

        public string nome {  get; set; }
        public List<ItemCarrinho> carrinho { get; set; }
        public DateTime date { get; set; }
        public double total { get; set; } 
        public statusPedido status { get; set; }
        public enum statusPedido
        {
            Criado,
            Preparando,
            Finalizado,
            Cancelado
        }
        public override string ToString()
        {
            return $"{nome} - {date} status: {status}";
        }
        

    }
    public class Repositorio
    {
        public static List<Pedido> listaPedidos = new List<Pedido>();
    }
    
    
}
