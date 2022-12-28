using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Robo_s_Memory_Game
{
    /// <summary>
    /// Manages the saving and loading of player and match data
    /// </summary>
    static class FileManager
    {
        /// <summary>
        /// Player data construct
        /// </summary>
        public struct Player
        {
            public string name { get; set; }

            public int highScore { get; set; }

            public TimeSpan playTime { get; set; }

            public List<Match> matchHistory { get; set; }

            public float winToLoseRatio { get; set; }
        }

        /// <summary>
        /// Match data construct
        /// </summary>
        public struct Match
        {
            public DateTime mathDate { get; set; }

            public string matchType { get; set; }

            public Player[] players { get; set; }

            public Player winner { get; set; }
        }

        /// <summary>
        /// Checks that all required files exist.
        /// If they don't creates them
        /// </summary>
        public static void FileCheck()
        {
            string dataPath = $@"{AppDomain.CurrentDomain.BaseDirectory}\Data";
            string playerDataPath = dataPath + @"\PlayerData.json";
            string matchDataPath = dataPath + @"\MatchData.json";

            DirectoryInfo playerDataDirectory = new DirectoryInfo(dataPath);

            FileInfo playerDataFile = new FileInfo(playerDataPath);
            FileInfo matchDataFile = new FileInfo(matchDataPath);

            if (!playerDataDirectory.Exists)
            {
                playerDataDirectory.Create();
            }

            if (!playerDataFile.Exists)
            {
                playerDataFile.Create().Dispose();
            }

            if (!matchDataFile.Exists)
            {
                matchDataFile.Create().Dispose();
            }

            List<Player> players = new List<Player>();

            string jsonString = File.ReadAllText(playerDataPath);

            if (!string.IsNullOrEmpty(jsonString))
            {
                try
                {
                    players = JsonSerializer.Deserialize<List<Player>>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deserializing players: {ex.Message}");
                }
            }

            Player newPlayer = new Player
            {
                highScore = 0,
                matchHistory = null,
                name = "New Player",
                playTime = TimeSpan.Zero,
                winToLoseRatio = 0
            };

            if (!players.Contains(newPlayer))
            {
                players.Add(newPlayer);

                foreach (Player player in players)
                {
                    SavePlayerData(player);
                }
            }
        }

        /// <summary>
        /// Saves player data
        /// </summary>
        /// <param name="player">Player to save</param>
        public static void SavePlayerData(Player player)
        {
            string dataPath = $@"{AppDomain.CurrentDomain.BaseDirectory}\Data";
            string playerDataPath = dataPath + @"\PlayerData.json";

            List<Player> players = new List<Player>();

            string jsonString = File.ReadAllText(playerDataPath);

            if (!string.IsNullOrEmpty(jsonString))
            {
                try
                {
                    players = JsonSerializer.Deserialize<List<Player>>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deserializing players: {ex.Message}");
                }
            }

            players.Add(player);

            using (FileStream fileStream = File.Open(playerDataPath, FileMode.Open, FileAccess.Write))
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };

                JsonSerializer.Serialize(fileStream, players, jsonSerializerOptions);
            }
        }

        /// <summary>
        /// Loads player data
        /// </summary>
        /// <returns>Player loaded</returns>
        public static List<Player> LoadPlayerData()
        {
            string dataPath = $@"{AppDomain.CurrentDomain.BaseDirectory}\Data";
            string playerDataPath = dataPath + @"\PlayerData.json";

            List<Player> players = new List<Player>();

            string jsonString = File.ReadAllText(playerDataPath);

            if (!string.IsNullOrEmpty(jsonString))
            {
                try
                {
                    players = JsonSerializer.Deserialize<List<Player>>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deserializing players: {ex.Message}");
                }
            }

            return players;
        }

        /// <summary>
        /// Finds a player with a given name
        /// </summary>
        /// <param name="playerName">Name of a player to find</param>
        /// <returns>
        /// Player with the given name, if non can be found returns an empty player.
        /// </returns>
        public static Player FindPlayerWithName(string playerName)
        {
            Player playerFound = new Player();

            List<Player> players = LoadPlayerData();

            foreach (Player player in players)
            {
                if (player.name == playerName)
                {
                    playerFound = player;
                    break;
                }
            }

            return playerFound;
        }

        /// <summary>
        /// Deletes a player with a given name
        /// </summary>
        /// <param name="playerName">Name of the player to delete</param>
        public static void DeletePlayerWithName(string playerName)
        {
            List<Player> players = LoadPlayerData();

            foreach(Player player in players)
            {
                if (player.name == playerName)
                {
                    players.Remove(player);
                    break;
                }
            }

            foreach(Player player in players)
            {
                SavePlayerData(player);
            }
        }
    }
}
