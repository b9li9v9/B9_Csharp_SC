namespace SC_DbConfig
{
    internal class Org
    {
        public long Id { get; set; }
        public string OrgName { get; set; }
        public long OrgHeadId { get; set; }

        public ICollection<Dept> Departments { get;} = new List<Dept>();
        //public ICollection<Post> Posts { get; } = new List<Post>();
    }

    internal class OrgConfig : IEntityTypeConfiguration<Org>
    {
        public void Configure(EntityTypeBuilder<Org> builder)
        {

            builder.ToTable("T_Orgs");
            builder.Property(o => o.OrgName).HasMaxLength(50).IsRequired();
            builder.Property(o => o.OrgHeadId).IsRequired();
            //索引 builder.HasIndex(t => t.OrgName);
            //复合索引 builder.HasIndex(t=>new {t.OrgName, t.OrgHeadId});

            //FK 外键设置
            //builder.HasMany(o => o.Departments)
            //  .WithOne(d => d.Organization)
            //.HasForeignKey(d => d.OrgId);

            //builder.HasMany<Dept>(o => o.Departments).WithOne(d => d.Organization).HasForeignKey(d => d.OrgId).IsRequired();

            builder.HasMany<Dept>(o => o.Departments).WithOne(d => d.OrgId).IsRequired();

        }
    }
}
