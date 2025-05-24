using Microsoft.EntityFrameworkCore;
using Hiring_and_Selection_Process_Platform.Models;
using System.Diagnostics;


namespace Hiring_and_Selection_Process_Platform.Data
{
    public class MyAppContext : DbContext
    {

        public MyAppContext()
        {
        }

        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        {
        }



        public DbSet<Job> Jobs { get; set; }
        public DbSet<Candidates> Candidates { get; set; }

    }
}
