﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {

        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }
        public string Cidade { get; set; }

        public string EnderecoComplementar { get; set; }

        public int NumeroEndereco{ get; set; }

        public int FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento { get; set; }


        //Pedido deve ter 1 ou varios pedidos
        public ICollection<ItemPedido> ItensPedidos{ get; set; }



    }
}
