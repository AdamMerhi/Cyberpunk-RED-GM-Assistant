using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Cyberpunk_RED_GM_Tool
{
    internal class WeaponDatabase
    {

        /*public DbSet<Character> Students { get; set; }
        public DbSet<Weapon> Grades { get; set; }*/

        //public List<Character> characters = new List<Character>();
        public List<Weapon> weapons = new List<Weapon>();

        private string ConnectionString;

        /*public CharacterDatabase(string connectionString)
        {
            ConnectionString = connectionString;
        }*/

        public WeaponDatabase()
        {
            //characters = new List<Character>();
            weapons = new List<Weapon>();
        }

        public WeaponDatabase(string connectionString)
        {
            weapons = new List<Weapon>();
            ConnectionString = connectionString;
        }

        public List<Weapon> GetAllWeapons()
        { 
            return weapons; 
        }

        public void /*Weapon*/ GetWeaponByID(string weaponID)
        {
            return;
        }

        public void InsertWeapon()
        {
            return;
        }

        // Configure database access 
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // extension method
            // Connection String = "Server=(localdb)\\mssqllocaldb; Database=SchoolDb; Trusted_Connection=True;"
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SchoolDb;Trusted_Connection=True;");
        }*/
    }
}
