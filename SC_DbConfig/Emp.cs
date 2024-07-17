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
        }
    }
}
