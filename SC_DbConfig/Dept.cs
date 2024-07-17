namespace SC_DbConfig
{
    internal class Dept
    {
        public long Id { get; set; }
        public string DeptName { get; set; }
        public long DeptHeadId { get; set; }
        public long OrgId { get; set; }


    }

    internal class DeptConfig : IEntityTypeConfiguration<Dept>
    {
        public void Configure(EntityTypeBuilder<Dept> builder)
        {
            builder.ToTable("T_Depts");

            builder.Property(t => t.DeptName).HasMaxLength(50).IsRequired();
            builder.Property(t => t.DeptHeadId).IsRequired();
            builder.Property(t => t.OrgId).IsRequired();
        }
    }
}
