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
                                characterID = reader.GetInt32(reader.GetOrdinal("ID")),
                                name = reader.GetString(reader.GetOrdinal("Name")),
                                intelligence = reader.GetInt32(reader.GetOrdinal("Intelligence")),
                                reflexes = reader.GetInt32(reader.GetOrdinal("Reflexes")),
                                dexterity = reader.GetInt32(reader.GetOrdinal("Dexterity")),
                                technique = reader.GetInt32(reader.GetOrdinal("Technique")),
                                cool = reader.GetInt32(reader.GetOrdinal("Cool")),
                                will = reader.GetInt32(reader.GetOrdinal("Will")),
                                luck = reader.GetInt32(reader.GetOrdinal("Luck")),
                                move = reader.GetInt32(reader.GetOrdinal("Move")),
                                body = reader.GetInt32(reader.GetOrdinal("Body")),
                                empathy = reader.GetInt32(reader.GetOrdinal("Empathy")),
                                concentration = reader.GetInt32(reader.GetOrdinal("Concentration")),
                                perception = reader.GetInt32(reader.GetOrdinal("Perception")),
                                athletics = reader.GetInt32(reader.GetOrdinal("Athletics")),
                                brawling = reader.GetInt32(reader.GetOrdinal("Brawling")),
                                evasion = reader.GetInt32(reader.GetOrdinal("Evasion")),
                                meleeWeapon = reader.GetInt32(reader.GetOrdinal("MeleeWeapon")),
                                archery = reader.GetInt32(reader.GetOrdinal("Archery")),
                                autofire = reader.GetInt32(reader.GetOrdinal("Autofire")),
                                handgun = reader.GetInt32(reader.GetOrdinal("Handgun")),
                                heavyWeapons = reader.GetInt32(reader.GetOrdinal("HeavyWeapons")),
                                shoulderArms = reader.GetInt32(reader.GetOrdinal("ShoulderArms")),
                                currentHp = reader.GetInt32(reader.GetOrdinal("CurrentHp")),
                                maxHp = reader.GetInt32(reader.GetOrdinal("MaxHp")),
                                weapons = reader.GetString(reader.GetOrdinal("Weapons")),
                                helmetArmor = reader.GetInt32(reader.GetOrdinal("HelmetArmor")),
                                bodyArmor = reader.GetInt32(reader.GetOrdinal("BodyArmor"))
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
                    "MeleeWeapon, Archery, Autofire, Handgun, HeavyWeapons, ShoulderArms, CurrentHp, MaxHp, Weapons, HelmetArmor, BodyArmor) " +
                    "VALUES (@Name, @Intelligence, @Reflexes, @Dexterity, @Technique, @Cool, @Will, @Luck, @Move, @Body, " +
                    "@Empathy, @Concentration, @Perception, @Athletics, @Brawling, @Evasion, @MeleeWeapon, @Archery, " +
                    "@Autofire, @Handgun, @HeavyWeapons, @ShoulderArms, @CurrentHp, @MaxHp, @Weapons, @HelmetArmor, @BodyArmor)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", character.name);
                    command.Parameters.AddWithValue("@Intelligence", character.intelligence);
                    command.Parameters.AddWithValue("@Reflexes", character.reflexes);
                    command.Parameters.AddWithValue("@Dexterity", character.dexterity);
                    command.Parameters.AddWithValue("@Technique", character.technique);
                    command.Parameters.AddWithValue("@Cool", character.cool);
                    command.Parameters.AddWithValue("@Will", character.will);
                    command.Parameters.AddWithValue("@Luck", character.luck);
                    command.Parameters.AddWithValue("@Move", character.move);
                    command.Parameters.AddWithValue("@Body", character.body);
                    command.Parameters.AddWithValue("@Empathy", character.empathy);
                    command.Parameters.AddWithValue("@Concentration", character.concentration);
                    command.Parameters.AddWithValue("@Perception", character.perception);
                    command.Parameters.AddWithValue("@Athletics", character.athletics);
                    command.Parameters.AddWithValue("@Brawling", character.brawling);
                    command.Parameters.AddWithValue("@Evasion", character.evasion);
                    command.Parameters.AddWithValue("@MeleeWeapon", character.meleeWeapon);
                    command.Parameters.AddWithValue("@Archery", character.archery);
                    command.Parameters.AddWithValue("@Autofire", character.autofire);
                    command.Parameters.AddWithValue("@Handgun", character.handgun);
                    command.Parameters.AddWithValue("@HeavyWeapons", character.heavyWeapons);
                    command.Parameters.AddWithValue("@ShoulderArms", character.shoulderArms);
                    command.Parameters.AddWithValue("@CurrentHp", character.currentHp);
                    command.Parameters.AddWithValue("@MaxHp", character.maxHp);
                    command.Parameters.AddWithValue("@Weapons", character.weapons);
                    command.Parameters.AddWithValue("@HelmetArmor", character.helmetArmor);
                    command.Parameters.AddWithValue("@BodyArmor", character.bodyArmor);


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
                    "Weapons = @Weapons, " +
                    "HelmetArmor = @HelmetArmor, " +
                    "BodyArmor = @BodyArmor " +
                    "WHERE ID = @CharacterID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@CharacterID", character.characterID);
                    cmd.Parameters.AddWithValue("@Name", character.name);
                    cmd.Parameters.AddWithValue("@Intelligence", character.intelligence);
                    cmd.Parameters.AddWithValue("@Reflexes", character.reflexes);
                    cmd.Parameters.AddWithValue("@Dexterity", character.dexterity);
                    cmd.Parameters.AddWithValue("@Technique", character.technique);
                    cmd.Parameters.AddWithValue("@Cool", character.cool);
                    cmd.Parameters.AddWithValue("@Will", character.will);
                    cmd.Parameters.AddWithValue("@Luck", character.luck);
                    cmd.Parameters.AddWithValue("@Move", character.move);
                    cmd.Parameters.AddWithValue("@Body", character.body);
                    cmd.Parameters.AddWithValue("@Empathy", character.empathy);
                    cmd.Parameters.AddWithValue("@Concentration", character.concentration);
                    cmd.Parameters.AddWithValue("@Perception", character.perception);
                    cmd.Parameters.AddWithValue("@Athletics", character.athletics);
                    cmd.Parameters.AddWithValue("@Brawling", character.brawling);
                    cmd.Parameters.AddWithValue("@Evasion", character.evasion);
                    cmd.Parameters.AddWithValue("@MeleeWeapon", character.meleeWeapon);
                    cmd.Parameters.AddWithValue("@Archery", character.archery);
                    cmd.Parameters.AddWithValue("@Autofire", character.autofire);
                    cmd.Parameters.AddWithValue("@Handgun", character.handgun);
                    cmd.Parameters.AddWithValue("@HeavyWeapons", character.heavyWeapons);
                    cmd.Parameters.AddWithValue("@ShoulderArms", character.shoulderArms);
                    cmd.Parameters.AddWithValue("@CurrentHp", character.currentHp);
                    cmd.Parameters.AddWithValue("@MaxHp", character.maxHp);
                    cmd.Parameters.AddWithValue("@Weapons", character.weapons);
                    cmd.Parameters.AddWithValue("@HelmetArmor", character.helmetArmor);
                    cmd.Parameters.AddWithValue("@BodyArmor", character.bodyArmor);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
