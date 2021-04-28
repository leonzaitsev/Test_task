using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Synevo_test_project.Entites;

namespace Synevo_test_project.Data.Mappings
{
    public class PokemonOrderMapping : IEntityTypeConfiguration<PokemonOrder>
    {
        public void Configure(EntityTypeBuilder<PokemonOrder> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
