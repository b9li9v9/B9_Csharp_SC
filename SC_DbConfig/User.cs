using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_DbConfig
{
    internal class User
    {
        public long UserId { get; set; }
        public string Acct { get; set; }
        public string Nick { get; set; }
        public string pwd { get; set; }

        //only 
        //many 员工身份档案
        public ICollection<Org> FKOrgs { get; } = new List<Org>();
        public ICollection<Dept> FKDepts { get; } = new List<Dept>();
        public ICollection<Emp> FKEmps { get; } = new List<Emp>();
    }

    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("T_Users");
            builder.Property(t => t.Acct).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Nick).HasMaxLength(50).IsRequired();
            builder.Property(t => t.pwd).HasMaxLength(50).IsRequired();
        }
    }
}
