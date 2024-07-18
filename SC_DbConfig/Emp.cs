using System;
using System.Collections.Generic;
namespace SC_DbConfig
{
    internal class Emp
    {
        public long Id { get; set; }
        public string EmpName { get; set; }
        public long UserId { get; set; }
        public long DeptId {  get; set; }
    }

    internal class EmpConfig : IEntityTypeConfiguration<Emp>
    {
        public void Configure(EntityTypeBuilder<Emp> builder)
        {
            builder.ToTable("T_Emps");
            builder.Property(t => t.EmpName).HasMaxLength(50).IsRequired();
            builder.Property(t => t.UserId).IsRequired();
            builder.Property(t => t.DeptId).IsRequired();

        }
    }
}
