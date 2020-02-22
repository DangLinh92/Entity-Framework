using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CodeFirst
{
    //Step 1
    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePubished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    //Step 2
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

    }

    // Step 3: Create connection string in app.config
    // Step 4: Run enable-migrations
    // Step 5: To update when change then using add-migration 'message add'
    // Step 6: Run Update-Database
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
