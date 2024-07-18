using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_DbConfig
{
    internal class User
    {
        public long Id { get; set; }
        public string Acct { get; set; }
        public string Nick { get; set; }
        public string pwd { get; set; }

    }

    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("T_Users");
            builder.Property(t => t.Nick).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Acct).HasMaxLength(50).IsRequired();
            builder.Property(t => t.pwd).HasMaxLength(50).IsRequired();
        }
    }
}
