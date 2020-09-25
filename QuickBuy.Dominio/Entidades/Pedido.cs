using QuickBuy.Dominio.ObjetosDeApoio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataPrevistaEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemPedido> ItemPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (!ItemPedidos.Any())
                AdicionarCritical("Critical: - Pedido não pode ficar sem item de pedido");

            if(string.IsNullOrEmpty(CEP))
                AdicionarCritical("Critical: - CEP não pode ser nulo ou vazio");
        }
    }
}
