using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Cyberpunk_RED_GM_Assistant
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
            List<Weapon> allWeapons = new List<Weapon>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Weapon";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //while()
                        while (reader.Read())// keep reading stuff from database
                        {
                            int ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            if (ID < 200)
                            {
                                RangedWeapon weapon = new RangedWeapon
                                {
                                    weaponID = ID,
                                    name = reader.GetString(reader.GetOrdinal("Name")),
                                    damage = reader.GetInt32(reader.GetOrdinal("Damage")),
                                    ROF = reader.GetInt32(reader.GetOrdinal("ROF")),
                                    range = reader.GetInt32(reader.GetOrdinal("Range")),
                                    cost = reader.GetInt32(reader.GetOrdinal("Cost")),
                                    maxAmmoCount = reader.GetInt32(reader.GetOrdinal("MaxAmmoCount")),
                                    currentAmmoCount = reader.GetInt32(reader.GetOrdinal("MaxAmmoCount")),
                                    type = (RangedWeaponType)reader.GetInt32(reader.GetOrdinal("RangedWeaponType")),
                                    handsRequired = reader.GetInt32(reader.GetOrdinal("HandsRequired")),
                                };
                                //return weapon;
                                allWeapons.Add(weapon);
                            }
                            else
                            {
                                MeleeWeapon weapon = new MeleeWeapon
                                {
                                    weaponID = ID,
                                    name = reader.GetString(reader.GetOrdinal("Name")),
                                    damage = reader.GetInt32(reader.GetOrdinal("Damage")),
                                    ROF = reader.GetInt32(reader.GetOrdinal("ROF")),
                                    range = reader.GetInt32(reader.GetOrdinal("Range")),
                                    cost = reader.GetInt32(reader.GetOrdinal("Cost")),
                                    type = (MeleeWeaponType)reader.GetInt32(reader.GetOrdinal("MeleeWeaponType")),
                                    handsRequired = reader.GetInt32(reader.GetOrdinal("HandsRequired")),
                                    canConceal = reader.GetBoolean(reader.GetOrdinal("CanConceal"))
                                };
                                allWeapons.Add(weapon);
                            }
                        }// end of: while(reader.read())

                        if (!reader.Read())
                        {
                            Console.WriteLine("Reached the end of weapon database");
                        }

                    }// end of: using reader
                }// end of: using command

                connection.Close();

            }// end of: using connection

            return allWeapons; 
        }// end of: GetAllWeapons()

        public /*void*/ Weapon GetWeaponByID(string weaponID)
        {
            // Code copied from characterDB
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Weapon WHERE ID = @WeaponID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@WeaponID", weaponID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Weapon ID conventions:
                            // ID Starts with 1: RangedWeapon
                            // ID Starts with 2: MeleeWeapon
                            int ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            if (ID < 200)
                            {
                                RangedWeapon weapon = new RangedWeapon
                                {
                                    weaponID = ID,
                                    name = reader.GetString(reader.GetOrdinal("Name")),
                                    damage = reader.GetInt32(reader.GetOrdinal("Damage")),
                                    ROF = reader.GetInt32(reader.GetOrdinal("ROF")),
                                    range = reader.GetInt32(reader.GetOrdinal("Range")),
                                    cost = reader.GetInt32(reader.GetOrdinal("Cost")),
                                    maxAmmoCount = reader.GetInt32(reader.GetOrdinal("MaxAmmoCount")),
                                    currentAmmoCount = reader.GetInt32(reader.GetOrdinal("MaxAmmoCount")),
                                    type = (RangedWeaponType)reader.GetInt32(reader.GetOrdinal("RangedWeaponType")),
                                    handsRequired = reader.GetInt32(reader.GetOrdinal("HandsRequired")),
                                };
                                return weapon;
                            }
                            else
                            {
                                MeleeWeapon weapon = new MeleeWeapon
                                {
                                    weaponID = ID,
                                    name = reader.GetString(reader.GetOrdinal("Name")),
                                    damage = reader.GetInt32(reader.GetOrdinal("Damage")),
                                    ROF = reader.GetInt32(reader.GetOrdinal("ROF")),
                                    range = reader.GetInt32(reader.GetOrdinal("Range")),
                                    cost = reader.GetInt32(reader.GetOrdinal("Cost")),
                                    type = (MeleeWeaponType)reader.GetInt32(reader.GetOrdinal("MeleeWeaponType")),
                                    handsRequired = reader.GetInt32(reader.GetOrdinal("HandsRequired")),
                                    canConceal = reader.GetBoolean(reader.GetOrdinal("CanConceal"))

                                };
                                return weapon;
                            }
                            
                        }// end of: reader.read() 
                    }// end of: using reader
                }// end of: using command

                connection.Close();

            }// end of: using connection

            return null; // Weapon not found
        }// end of: GetWeaponByID()

        public void InsertWeapon(RangedWeapon weapon)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Weapon (ID, Name, Damage, ROF, HandsRequired, Range, Cost, RangedWeaponType, MaxAmmoCount) " +
                "VALUES (@weaponID, @name, @damage, @ROF, @handsRequired, @range, @cost, @type, @maxAmmoCount)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", weapon.weaponID);
                    command.Parameters.AddWithValue("@Name", weapon.name);
                    command.Parameters.AddWithValue("@Damage", weapon.damage);
                    command.Parameters.AddWithValue("@ROF", weapon.ROF);
                    command.Parameters.AddWithValue("@HandsRequired", weapon.handsRequired);
                    command.Parameters.AddWithValue("@Range", weapon.range);
                    command.Parameters.AddWithValue("@Cost", weapon.cost);
                    command.Parameters.AddWithValue("@RangedWeaponType", (int)weapon.type);
                    command.Parameters.AddWithValue("@MaxAmmoCount", weapon.maxAmmoCount);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void InsertWeapon(MeleeWeapon weapon)// Overload for MeleeWeapon
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Weapon (ID, Name, Damage, ROF, HandsRequired, Range, Cost, MeleeWeaponType, CanConceal) " +
                "VALUES (@weaponID, @name, @damage, @ROF, @handsRequired, @range, @cost, @type, @canConceal)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", weapon.weaponID);
                    command.Parameters.AddWithValue("@Name", weapon.name);
                    command.Parameters.AddWithValue("@Damage", weapon.damage);
                    command.Parameters.AddWithValue("@ROF", weapon.ROF);
                    command.Parameters.AddWithValue("@HandsRequired", weapon.handsRequired);
                    command.Parameters.AddWithValue("@Range", weapon.range);
                    command.Parameters.AddWithValue("@Cost", weapon.cost);
                    command.Parameters.AddWithValue("@MeleeWeaponType", (int)weapon.type);
                    command.Parameters.AddWithValue("@CanConceal", weapon.canConceal);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

    }
}
