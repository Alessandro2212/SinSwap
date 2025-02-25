﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nop.Data.Mapping.Faq
{
    public partial class FaqMap : NopEntityTypeConfiguration<Core.Domain.Faq.Faq>
    {
        #region Methods
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Core.Domain.Faq.Faq> builder)
        {
            builder.ToTable(nameof(Faq));
            builder.HasKey(record => record.Id);
        }
        #endregion
    }
}
