namespace SC_DbConfig
{
    internal class Dept
    {
        public long Id { get; set; }
        public string DeptName { get; set; }
        public long DeptHeadId { get; set; }
        public Org OrgId { get; set; } = null!;


    }

    internal class DeptConfig : IEntityTypeConfiguration<Dept>
    {
        public void Configure(EntityTypeBuilder<Dept> builder)
        {
            builder.ToTable("T_Depts");
            builder.Property(d => d.DeptName).HasMaxLength(50).IsRequired();
            builder.Property(d => d.DeptHeadId).IsRequired();


            //FK
            //builder.HasOne<Org>(d => d.OrgId).WithMany(o => o.Departments).IsRequired();

            //builder.HasOne(d => d.Organization)
            //    .WithMany(o => o.Departments)
            //    .HasForeignKey(d => d.OrgId);

            //builder.HasOne(e => e.Organization)
            //.WithMany(e => e.Departments)
            //.HasForeignKey(e => e.OrgId)
            //.IsRequired();
        }
    }
}
