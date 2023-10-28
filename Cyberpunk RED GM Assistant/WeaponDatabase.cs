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
        public List<Weapon> weaponsList = new List<Weapon>();

        private string ConnectionString;

        /*public CharacterDatabase(string connectionString)
        {
            ConnectionString = connectionString;
        }*/

        public WeaponDatabase()
        {
            //characters = new List<Character>();
            weaponsList = new List<Weapon>();
        }

        public WeaponDatabase(string connectionString)
        {
            weaponsList = new List<Weapon>();
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
                            //reader.
                            //int ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            if (reader.GetInt32(reader.GetOrdinal("RangedWeaponType")) != null)
                            //if (ID < 200)
                            {
                                RangedWeapon weapon = new RangedWeapon
                                {
                                    weaponID = reader.GetInt32(reader.GetOrdinal("ID")),
                                    name = reader.GetString(reader.GetOrdinal("Name")),
                                    damageDiceAmount = reader.GetInt32(reader.GetOrdinal("DamageDiceAmount")),
                                    damageDiceType = reader.GetInt32(reader.GetOrdinal("DamageDiceType")),
                                    ROF = reader.GetInt32(reader.GetOrdinal("ROF")),
                                    //range = reader.GetInt32(reader.GetOrdinal("Range")),
                                    //cost = reader.GetInt32(reader.GetOrdinal("Cost")),
                                    maxAmmoCount = reader.GetInt32(reader.GetOrdinal("MaxAmmoCount")),
                                    //currentAmmoCount = reader.GetInt32(reader.GetOrdinal("MaxAmmoCount")),
                                    type = (RangedWeaponType)reader.GetInt32(reader.GetOrdinal("RangedWeaponType")),
                                    //handsRequired = reader.GetInt32(reader.GetOrdinal("HandsRequired")),
                                };
                                //return weapon;
                                allWeapons.Add(weapon);
                            }
                            else
                            {
                                MeleeWeapon weapon = new MeleeWeapon
                                {
                                    weaponID = reader.GetInt32(reader.GetOrdinal("ID")),
                                    name = reader.GetString(reader.GetOrdinal("Name")),
                                    damageDiceAmount = reader.GetInt32(reader.GetOrdinal("DamageDiceAmount")),
                                    damageDiceType = reader.GetInt32(reader.GetOrdinal("DamageDiceType")),
                                    ROF = reader.GetInt32(reader.GetOrdinal("ROF")),
                                    //range = reader.GetInt32(reader.GetOrdinal("Range")),
                                    //cost = reader.GetInt32(reader.GetOrdinal("Cost")),
                                    type = (MeleeWeaponType)reader.GetInt32(reader.GetOrdinal("MeleeWeaponType")),
                                    //handsRequired = reader.GetInt32(reader.GetOrdinal("HandsRequired")),
                                    //canConceal = reader.GetBoolean(reader.GetOrdinal("CanConceal"))
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

                                    damageDiceAmount = reader.GetInt32(reader.GetOrdinal("DamageDiceAmount")),
                                    damageDiceType = reader.GetInt32(reader.GetOrdinal("DamageDiceType")),

                                    //damage = reader.GetInt32(reader.GetOrdinal("Damage")),
                                    ROF = reader.GetInt32(reader.GetOrdinal("ROF")),
                                    //range = reader.GetInt32(reader.GetOrdinal("Range")),
                                    //cost = reader.GetInt32(reader.GetOrdinal("Cost")),
                                    maxAmmoCount = reader.GetInt32(reader.GetOrdinal("MaxAmmoCount")),
                                    //currentAmmoCount = reader.GetInt32(reader.GetOrdinal("MaxAmmoCount")),
                                    type = (RangedWeaponType)reader.GetInt32(reader.GetOrdinal("RangedWeaponType")),
                                    //handsRequired = reader.GetInt32(reader.GetOrdinal("HandsRequired")),
                                };
                                return weapon;
                            }
                            else
                            {
                                MeleeWeapon weapon = new MeleeWeapon
                                {
                                    weaponID = ID,
                                    name = reader.GetString(reader.GetOrdinal("Name")),
                                    damageDiceAmount = reader.GetInt32(reader.GetOrdinal("DamageDiceAmount")),
                                    damageDiceType = reader.GetInt32(reader.GetOrdinal("DamageDiceType")),
                                    ROF = reader.GetInt32(reader.GetOrdinal("ROF")),
                                    //range = reader.GetInt32(reader.GetOrdinal("Range")),
                                    //cost = reader.GetInt32(reader.GetOrdinal("Cost")),
                                    type = (MeleeWeaponType)reader.GetInt32(reader.GetOrdinal("MeleeWeaponType")),
                                    //handsRequired = reader.GetInt32(reader.GetOrdinal("HandsRequired")),
                                    //canConceal = reader.GetBoolean(reader.GetOrdinal("CanConceal"))

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

                /*string insertQuery = "INSERT INTO Weapon (ID, Name, Damage, ROF, HandsRequired, Range, Cost, RangedWeaponType, MaxAmmoCount) " +
                "VALUES (@ID, @Name, @Damage, @ROF, @HandsRequired, @Range, @Cost, @RangedWeaponType, @MaxAmmoCount)";*/
                /*string insertQuery = "INSERT INTO Weapon (ID, Name, Damage, ROF, Range, Cost, RangedWeaponType, MaxAmmoCount) " +
                "VALUES (@ID, @Name, @Damage, @ROF, @Range, @Cost, @RangedWeaponType, @MaxAmmoCount)";*/
                /*string insertQuery = "INSERT INTO Weapon (Name, Damage, ROF, Range, Cost, RangedWeaponType, MaxAmmoCount) " +
                "VALUES (@Name, @Damage, @ROF, @Range, @Cost, @RangedWeaponType, @MaxAmmoCount)";*/
                /*string insertQuery = "INSERT INTO Weapon (weaponID, Name, Damage, ROF, Range, Cost, RangedWeaponType, MaxAmmoCount) " +
                "VALUES (@weaponID, @Name, @Damage, @ROF, @Range, @Cost, @RangedWeaponType, @MaxAmmoCount)";*/

                string insertQuery = "INSERT INTO Weapon (Name, ROF, RangedWeaponType, MaxAmmoCount, MagazineAmmoCount, DamageDiceAmount, DamageDiceType) " +
                "VALUES (@Name, @ROF, @RangedWeaponType, @MaxAmmoCount, @MagazineAmmoCount, @DamageDiceAmount, @DamageDiceType)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", weapon.weaponID);
                    command.Parameters.AddWithValue("@Name", weapon.name);
                    command.Parameters.AddWithValue("@DamageDiceAmount", weapon.damageDiceAmount);
                    command.Parameters.AddWithValue("@DamageDiceType", weapon.damageDiceType);
                    command.Parameters.AddWithValue("@ROF", weapon.ROF);                    
                    command.Parameters.AddWithValue("@RangedWeaponType", (int)weapon.type);
                    command.Parameters.AddWithValue("@MaxAmmoCount", weapon.maxAmmoCount);
                    command.Parameters.AddWithValue("@MagazineAmmoCount", weapon.magazineSize);


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

                /*string insertQuery = "INSERT INTO Weapon (ID, Name, Damage, ROF, HandsRequired, Range, Cost, MeleeWeaponType, CanConceal) " +
                "VALUES (@weaponID, @name, @damage, @ROF, @handsRequired, @range, @cost, @type, @canConceal)";*/
                string insertQuery = "INSERT INTO Weapon (Name, ROF, MeleeWeaponType, DamageDiceAmount, DamageDiceType) " +
                "VALUES (@Name, @ROF, @MeleeWeaponType, @DamageDiceAmount, @DamageDiceType)";

                /*string insertQuery = "INSERT INTO Weapon (weaponID, Name, Damage, ROF, Range, Cost, RangedWeaponType, MaxAmmoCount) " +
                "VALUES (@weaponID, @Name, @Damage, @ROF, @Range, @Cost, @RangedWeaponType, @MaxAmmoCount)";*/

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", weapon.weaponID);
                    command.Parameters.AddWithValue("@Name", weapon.name);
                    command.Parameters.AddWithValue("@DamageDiceAmount", weapon.damageDiceAmount);
                    command.Parameters.AddWithValue("@DamageDiceType", weapon.damageDiceType);
                    command.Parameters.AddWithValue("@ROF", weapon.ROF);
                    command.Parameters.AddWithValue("@MeleeWeaponType", (int)weapon.type);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

    }
}

// Database attributes: Name, Damage, ROF, RangedWeaponType, MeleeWeaponType, MaxAmmoCount, MagazineAmmoCount, DamageDiceAmount, DamageDiceType
