using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CARDAPIO_POO
{
    
    public class Pedido
    {
        public string FormaPagamento { get; set; }
        public string Nome {  get; set; }
        public List<ItemPedido> carrinho { get; set; }
        public DateTime date { get; set; }
        public decimal Total { get; set; } 
        public statusPedido status { get; set; }
        public enum statusPedido
        {
            Viagem,
            Preparando,
            Finalizado,
            Cancelado
        }
        public override string ToString()
        {
            return $"Cliente: {Nome} | Data: {date.ToString("dd/MM/yyyy HH:mm")} | Status: {status} | Total: R$ {Total:F2}";
        }
      

    }
    public class Repositorio
    {
        public static List<Pedido> listaPedidos = new List<Pedido>();
    }
    
    
}
