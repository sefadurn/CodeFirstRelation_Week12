using CodeFirstRelation_Week12.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation_Week12.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        //1
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext>options) : base(options)

        {
            
        }

        // Veritabanında oluşacak tablolar:
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
