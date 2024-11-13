using MemoAPi.Models;
using Microsoft.EntityFrameworkCore;


namespace MemoAPi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Memo> Memos { get; set; }
    }
}