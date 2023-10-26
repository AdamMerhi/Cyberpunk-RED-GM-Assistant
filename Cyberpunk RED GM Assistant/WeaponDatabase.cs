/*using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_RED_GM_Tool
{
    internal class WeaponDatabase : DbContext
    {

        public DbSet<Character> Students { get; set; }
        public DbSet<Weapon> Grades { get; set; }

        public List<Character> characters = new List<Character>();
        public List<Weapon> weapons = new List<Weapon>();

        public WeaponDatabase()
        {
            characters = new List<Character>();
            weapons = new List<Weapon>();
        }

        // Configure database access 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // extension method
            // Connection String = "Server=(localdb)\\mssqllocaldb; Database=SchoolDb; Trusted_Connection=True;"
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SchoolDb;Trusted_Connection=True;");
        }
    }
}*/
