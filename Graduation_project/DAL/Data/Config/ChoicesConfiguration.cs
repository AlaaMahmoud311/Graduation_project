using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Talabat.DAL.Data.Config
{
    public class ChoicesConfiguration : IEntityTypeConfiguration<Choices>

    {
        public void Configure(EntityTypeBuilder<Choices> builder)
        {
            builder.HasKey(C => C.id);
            //builder.HasOne(q=> q.Question).WithMany().HasForeignKey(C => C.Question_id);






        }
    }
}
