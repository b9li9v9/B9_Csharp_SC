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
            optionsBuilder.UseSqlServer("server=DESKTOP-10B83JG\\SQLEXPRESS;uid=zhangsan;pwd=111111;database=SC_DB;Encrypt=False;");
            optionsBuilder.LogTo(msg => { if (!msg.Contains("CommandExecuting")) return;Console.WriteLine(msg); });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ICollection -> “集合” 的意思
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
