namespace SC_DbConfig
{
    internal class SC_DbContext : DbContext
    {


        public DbSet<User> Users { get; set; }
        public DbSet<Org> Orgs { get; set; }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Emp> Emps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.;uid=zhangsan;pwd=123456;database=WinFormsCS;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ICollection -> “集合” 的意思
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
