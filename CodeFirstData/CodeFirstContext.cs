using System.Data.Entity;
using CodeFirstEntities;
namespace CodeFirstData
{
    public class CodeFirstContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
