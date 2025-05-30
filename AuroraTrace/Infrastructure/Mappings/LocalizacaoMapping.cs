﻿namespace AuroraTrace.Infrastructure.Mappings
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using AuroraTrace.Domain.Entity;

    public class LocalizacaoMapping : IEntityTypeConfiguration<Localizacao>
    {
        public void Configure(EntityTypeBuilder<Localizacao> builder)
        {
            builder.ToTable("Localizacoes");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Latitude)
                   .IsRequired()
                   .HasColumnName("latitude");

            builder.Property(l => l.Longitude)
                   .IsRequired()
                   .HasColumnName("longitude");

            builder.Property(l => l.RegistradaEm)
                   .IsRequired()
                   .HasColumnName("registrada_em");
        }
    }
}
