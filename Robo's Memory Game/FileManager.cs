using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Robo_s_Memory_Game
{
    /// <summary>
    /// Manages the saving and loading of player and match data
    /// </summary>
    public static class FileManager
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

            public string[] playerNames { get; set; }

            public string winnersName { get; set; }

            public int gridSize { get; set; }
        }

        private static string dataPath = $@"{AppDomain.CurrentDomain.BaseDirectory}\Data"; //Path of the "Data" directory
        private static string playerDataPath = dataPath + @"\PlayerData.json"; //Path of the "PlayerData.json"
        private static string matchDataPath = dataPath + @"\MatchData.json"; //Path of the "MatchData.json"

        /// <summary>
        /// Checks that all required files exist.
        /// If they don't creates them.
        /// </summary>
        public static void FileCheck()
        {
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

            List<Player> players = ReadJsonToPlayerList(playerDataPath);

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
            List<Player> players = ReadJsonToPlayerList(playerDataPath);

            Player playerToRemove = new Player();

            foreach(Player checkPlayer in players)
            {
                if(checkPlayer.name == player.name)
                {
                    playerToRemove = checkPlayer;
                    break;
                }
            }

            players.Remove(playerToRemove);

            players.Add(player);

            WritePlayerListToJson(players, playerDataPath);
        }

        /// <summary>
        /// Delets player data
        /// </summary>
        /// <param name="player">Player to delete</param>
        public static void DeletePlayerData(Player player)
        {
            List<Player> players = ReadJsonToPlayerList(playerDataPath);

            players.Remove(player);

            WritePlayerListToJson(players, playerDataPath);
        }

        /// <summary>
        /// Reads a JSON file
        /// </summary>
        /// <param name="jsonPath">Path of the JSON file to read</param>
        /// <returns>A <c>List</c> of players</returns>
        public static List<Player> ReadJsonToPlayerList(string jsonPath)
        {
            string jsonString = File.ReadAllText(jsonPath);

            List<Player> players = new List<Player>();

            if (!string.IsNullOrEmpty(jsonString))
            {
                players = JsonSerializer.Deserialize<List<Player>>(jsonString);
            }

            return players;
        }

        /// <summary>
        /// Overwrites a given player <c>List</c> to a give JSON file path
        /// </summary>
        /// <param name="players"><c>List</c> of players to write</param>
        /// <param name="jsonPath">Path to JSON file</param>
        public static void WritePlayerListToJson(List<Player> players, string jsonPath)
        {
            FileInfo jsonFile = new FileInfo(jsonPath);

            jsonFile.Delete();

            FileStream fileStream = File.Open(jsonPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            JsonSerializer.Serialize(fileStream, players, jsonSerializerOptions);

            fileStream.Close();
        }

        /// <summary>
        /// Loads player data
        /// </summary>
        /// <returns>Player loaded</returns>
        public static List<Player> LoadPlayerData()
        {
            List<Player> players = new List<Player>();

            string jsonString = File.ReadAllText(playerDataPath);

            if (!string.IsNullOrEmpty(jsonString))
            {
                players = JsonSerializer.Deserialize<List<Player>>(jsonString);
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
            Player foundPlayer = new Player();

            foreach(Player player in players)
            {
                if (player.name == playerName)
                {
                    foundPlayer = player;
                    break;
                }
            }

            DeletePlayerData(foundPlayer);
        }
    }
}
