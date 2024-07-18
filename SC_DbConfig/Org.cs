namespace SC_DbConfig
{
    internal class Org
    {
        public long Id { get; set; }
        public string OrgName { get; set; }
        public long OrgHeadId { get; set; }

        object A() { return null; }
    }

    internal class OrgConfig : IEntityTypeConfiguration<Org>
    {
        public void Configure(EntityTypeBuilder<Org> builder)
        {
            builder.ToTable("T_Orgs");

            builder.Property(t => t.OrgName).HasMaxLength(50).IsRequired();
            builder.Property(t => t.OrgHeadId).IsRequired();
            //索引 builder.HasIndex(t => t.OrgName);
            //复合索引 builder.HasIndex(t=>new {t.OrgName, t.OrgHeadId});
        }
    }
}
