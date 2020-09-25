using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
                  .IsRequired()
                  .HasMaxLength(50);

            builder.Property(e => e.Senha)
                  .IsRequired()
                  .HasMaxLength(400);

            builder.Property(e => e.Sobrename)
                 .IsRequired()
                 .HasMaxLength(50);

            builder.Property(e => e.Email)
                 .IsRequired()
                 .HasMaxLength(50);

            builder.HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
