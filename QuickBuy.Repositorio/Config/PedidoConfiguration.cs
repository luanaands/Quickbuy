using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(e => e.Id);

                  
            builder.Property(e => e.DataPedido)
                  .IsRequired();

            builder.Property(e => e.DataPedido)
                .IsRequired();


            builder.Property(e => e.DataPrevistaEntrega)
                 .IsRequired();


            builder.Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Estado)
             .IsRequired()
             .HasMaxLength(50);

            builder.Property(e => e.EnderecoCompleto)
             .IsRequired()
             .HasMaxLength(50);


        }
    }
}
