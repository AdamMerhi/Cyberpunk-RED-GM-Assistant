using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Cyberpunk_RED_GM_Assistant
{
    internal class CharacterDatabase
    {
        private string ConnectionString;

        public CharacterDatabase(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public Character GetCharacterByID(int characterID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Character WHERE ID = @CharacterID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CharacterID", characterID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a new Character object and populate it with data from the database
                            Character character = new Character
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Intelligence = reader.GetInt32(reader.GetOrdinal("Intelligence")),
                                Reflexes = reader.GetInt32(reader.GetOrdinal("Reflexes")),
                                Dexterity = reader.GetInt32(reader.GetOrdinal("Dexterity")),
                                Technique = reader.GetInt32(reader.GetOrdinal("Technique")),
                                Cool = reader.GetInt32(reader.GetOrdinal("Cool")),
                                Will = reader.GetInt32(reader.GetOrdinal("Will")),
                                Luck = reader.GetInt32(reader.GetOrdinal("Luck")),
                                Move = reader.GetInt32(reader.GetOrdinal("Move")),
                                Body = reader.GetInt32(reader.GetOrdinal("Body")),
                                Empathy = reader.GetInt32(reader.GetOrdinal("Empathy")),
                                Concentration = reader.GetInt32(reader.GetOrdinal("Concentration")),
                                Perception = reader.GetInt32(reader.GetOrdinal("Perception")),
                                Athletics = reader.GetInt32(reader.GetOrdinal("Athletics")),
                                Brawling = reader.GetInt32(reader.GetOrdinal("Brawling")),
                                Evasion = reader.GetInt32(reader.GetOrdinal("Evasion")),
                                MeleeWeapon = reader.GetInt32(reader.GetOrdinal("MeleeWeapon")),
                                Archery = reader.GetInt32(reader.GetOrdinal("Archery")),
                                Autofire = reader.GetInt32(reader.GetOrdinal("Autofire")),
                                Handgun = reader.GetInt32(reader.GetOrdinal("Handgun")),
                                HeavyWeapons = reader.GetInt32(reader.GetOrdinal("HeavyWeapons")),
                                ShoulderArms = reader.GetInt32(reader.GetOrdinal("ShoulderArms")),
                                CurrentHp = reader.GetInt32(reader.GetOrdinal("CurrentHp")),
                                MaxHp = reader.GetInt32(reader.GetOrdinal("MaxHp")),
                                Weapon1 = reader.GetString(reader.GetOrdinal("Weapon1")),
                               // Weapon2 = reader.GetString(reader.GetOrdinal("Weapon2")),
                                Armor1 = reader.GetString(reader.GetOrdinal("Armor1")),
                                Armor2 = reader.GetString(reader.GetOrdinal("Armor2"))
                            };

                            return character;
                        }
                    }
                }
            }

            return null; // Character not found
        }
        public void InsertCharacter(Character character)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Character (Name, Intelligence, Reflexes, Dexterity, Technique, Cool, " +
                    "Will, Luck, Move, Body, Empathy, Concentration, Perception, Athletics, Brawling, Evasion, " +
                    "MeleeWeapon, Archery, Autofire, Handgun, HeavyWeapons, ShoulderArms, CurrentHp, MaxHp, Weapon1, Armor1, Armor2) " +
                    "VALUES (@Name, @Intelligence, @Reflexes, @Dexterity, @Technique, @Cool, @Will, @Luck, @Move, @Body, " +
                    "@Empathy, @Concentration, @Perception, @Athletics, @Brawling, @Evasion, @MeleeWeapon, @Archery, " +
                    "@Autofire, @Handgun, @HeavyWeapons, @ShoulderArms, @CurrentHp, @MaxHp, @Weapon1, @Armor1, @Armor2)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", character.Name);
                    command.Parameters.AddWithValue("@Intelligence", character.Intelligence);
                    command.Parameters.AddWithValue("@Reflexes", character.Reflexes);
                    command.Parameters.AddWithValue("@Dexterity", character.Dexterity);
                    command.Parameters.AddWithValue("@Technique", character.Technique);
                    command.Parameters.AddWithValue("@Cool", character.Cool);
                    command.Parameters.AddWithValue("@Will", character.Will);
                    command.Parameters.AddWithValue("@Luck", character.Luck);
                    command.Parameters.AddWithValue("@Move", character.Move);
                    command.Parameters.AddWithValue("@Body", character.Body);
                    command.Parameters.AddWithValue("@Empathy", character.Empathy);
                    command.Parameters.AddWithValue("@Concentration", character.Concentration);
                    command.Parameters.AddWithValue("@Perception", character.Perception);
                    command.Parameters.AddWithValue("@Athletics", character.Athletics);
                    command.Parameters.AddWithValue("@Brawling", character.Brawling);
                    command.Parameters.AddWithValue("@Evasion", character.Evasion);
                    command.Parameters.AddWithValue("@MeleeWeapon", character.MeleeWeapon);
                    command.Parameters.AddWithValue("@Archery", character.Archery);
                    command.Parameters.AddWithValue("@Autofire", character.Autofire);
                    command.Parameters.AddWithValue("@Handgun", character.Handgun);
                    command.Parameters.AddWithValue("@HeavyWeapons", character.HeavyWeapons);
                    command.Parameters.AddWithValue("@ShoulderArms", character.ShoulderArms);
                    command.Parameters.AddWithValue("@CurrentHp", character.CurrentHp);
                    command.Parameters.AddWithValue("@MaxHp", character.MaxHp);
                    command.Parameters.AddWithValue("@Weapon1", character.Weapon1);
                    //command.Parameters.AddWithValue("@Weapon2", character.Weapon2);
                    command.Parameters.AddWithValue("@Armor1", character.Armor1);
                    command.Parameters.AddWithValue("@Armor2", character.Armor2);


                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateCharacter(Character character)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Character SET " +
                    "Name = @Name, " +
                    "Intelligence = @Intelligence, " +
                    "Reflexes = @Reflexes, " +
                    "Dexterity = @Dexterity, " +
                    "Technique = @Technique, " +
                    "Cool = @Cool, " +
                    "Will = @Will, " +
                    "Luck = @Luck, " +
                    "Move = @Move, " +
                    "Body = @Body, " +
                    "Empathy = @Empathy, " +
                    "Concentration = @Concentration, " +
                    "Perception = @Perception, " +
                    "Athletics = @Athletics, " +
                    "Brawling = @Brawling, " +
                    "Evasion = @Evasion, " +
                    "MeleeWeapon = @MeleeWeapon, " +
                    "Archery = @Archery, " +
                    "Autofire = @Autofire, " +
                    "Handgun = @Handgun, " +
                    "HeavyWeapons = @HeavyWeapons, " +
                    "ShoulderArms = @ShoulderArms, " +
                    "CurrentHp = @CurrentHp, " +
                    "MaxHp = @MaxHp, " +
                    "Weapon1 = @Weapon1, " +
                   /* "Weapon2 = @Weapon2, " +*/
                    "Armor1 = @Armor1, " +
                    "Armor2 = @Armor2 " +
                    "WHERE ID = @CharacterID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@CharacterID", character.ID);
                    cmd.Parameters.AddWithValue("@Name", character.Name);
                    cmd.Parameters.AddWithValue("@Intelligence", character.Intelligence);
                    cmd.Parameters.AddWithValue("@Reflexes", character.Reflexes);
                    cmd.Parameters.AddWithValue("@Dexterity", character.Dexterity);
                    cmd.Parameters.AddWithValue("@Technique", character.Technique);
                    cmd.Parameters.AddWithValue("@Cool", character.Cool);
                    cmd.Parameters.AddWithValue("@Will", character.Will);
                    cmd.Parameters.AddWithValue("@Luck", character.Luck);
                    cmd.Parameters.AddWithValue("@Move", character.Move);
                    cmd.Parameters.AddWithValue("@Body", character.Body);
                    cmd.Parameters.AddWithValue("@Empathy", character.Empathy);
                    cmd.Parameters.AddWithValue("@Concentration", character.Concentration);
                    cmd.Parameters.AddWithValue("@Perception", character.Perception);
                    cmd.Parameters.AddWithValue("@Athletics", character.Athletics);
                    cmd.Parameters.AddWithValue("@Brawling", character.Brawling);
                    cmd.Parameters.AddWithValue("@Evasion", character.Evasion);
                    cmd.Parameters.AddWithValue("@MeleeWeapon", character.MeleeWeapon);
                    cmd.Parameters.AddWithValue("@Archery", character.Archery);
                    cmd.Parameters.AddWithValue("@Autofire", character.Autofire);
                    cmd.Parameters.AddWithValue("@Handgun", character.Handgun);
                    cmd.Parameters.AddWithValue("@HeavyWeapons", character.HeavyWeapons);
                    cmd.Parameters.AddWithValue("@ShoulderArms", character.ShoulderArms);
                    cmd.Parameters.AddWithValue("@CurrentHp", character.CurrentHp);
                    cmd.Parameters.AddWithValue("@MaxHp", character.MaxHp);
                    cmd.Parameters.AddWithValue("@Weapon1", character.Weapon1);
                    //cmd.Parameters.AddWithValue("@Weapon2", character.Weapon2);
                    cmd.Parameters.AddWithValue("@Armor1", character.Armor1);
                    cmd.Parameters.AddWithValue("@Armor2", character.Armor2);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Remove this character by passing in the character ID
        // WIP, Untested, and IDK if it works or not
        public void RemoveCharacterByID(int characterID)
        {
            // Just similar implementation with GetCharacterByID
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "DELECT FROM Character WHERE ID = @CharacterID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CharacterID", characterID);

                    command.ExecuteNonQuery();

                    /*using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a new Character object and populate it with data from the database
                            Character character = new Character
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Intelligence = reader.GetInt32(reader.GetOrdinal("Intelligence")),
                                Reflexes = reader.GetInt32(reader.GetOrdinal("Reflexes")),
                                Dexterity = reader.GetInt32(reader.GetOrdinal("Dexterity")),
                                Technique = reader.GetInt32(reader.GetOrdinal("Technique")),
                                Cool = reader.GetInt32(reader.GetOrdinal("Cool")),
                                Will = reader.GetInt32(reader.GetOrdinal("Will")),
                                Luck = reader.GetInt32(reader.GetOrdinal("Luck")),
                                Move = reader.GetInt32(reader.GetOrdinal("Move")),
                                Body = reader.GetInt32(reader.GetOrdinal("Body")),
                                Empathy = reader.GetInt32(reader.GetOrdinal("Empathy")),
                                Concentration = reader.GetInt32(reader.GetOrdinal("Concentration")),
                                Perception = reader.GetInt32(reader.GetOrdinal("Perception")),
                                Athletics = reader.GetInt32(reader.GetOrdinal("Athletics")),
                                Brawling = reader.GetInt32(reader.GetOrdinal("Brawling")),
                                Evasion = reader.GetInt32(reader.GetOrdinal("Evasion")),
                                MeleeWeapon = reader.GetInt32(reader.GetOrdinal("MeleeWeapon")),
                                Archery = reader.GetInt32(reader.GetOrdinal("Archery")),
                                Autofire = reader.GetInt32(reader.GetOrdinal("Autofire")),
                                Handgun = reader.GetInt32(reader.GetOrdinal("Handgun")),
                                HeavyWeapons = reader.GetInt32(reader.GetOrdinal("HeavyWeapons")),
                                ShoulderArms = reader.GetInt32(reader.GetOrdinal("ShoulderArms")),
                                CurrentHp = reader.GetInt32(reader.GetOrdinal("CurrentHp")),
                                MaxHp = reader.GetInt32(reader.GetOrdinal("MaxHp")),
                                Weapon1 = reader.GetString(reader.GetOrdinal("Weapon1")),
                                Weapon2 = reader.GetString(reader.GetOrdinal("Weapon2")),
                                Armor1 = reader.GetString(reader.GetOrdinal("Armor1")),
                                Armor2 = reader.GetString(reader.GetOrdinal("Armor2"))
                            };

                            return character;
                        }
                    }*/
                }
            }
        }

    }
}
