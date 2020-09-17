using QuickBuy.Dominio.Enuns;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace QuickBuy.Dominio.ObjetosDeApoio
{
    public class FormaPagamento
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
  

        public bool EhBoleto
        {
            get { return Id == (int)EnumFormaPagamento.Boleto; }
        }

        public bool EhCartaoDeCredito
        {
            get { return Id == (int)EnumFormaPagamento.CartaoCredito; }
        }

        public bool EhDeposito
        {
            get { return Id == (int)EnumFormaPagamento.Deposito; }
        }


        public bool NaoFoiDefinido
        {
            get { return Id == (int)EnumFormaPagamento.NaoDefenido; }
        }

    }
}
