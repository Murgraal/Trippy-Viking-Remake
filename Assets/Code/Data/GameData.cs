using System.Collections.Generic;
using UnityEngine;

namespace Code
{
    public static class GameData
    {
        public static GameSettings Settings;
        public static Dictionary<int,LocationData> LocationDatas;
        public static Dictionary<int, GameObject> Entities;
        public static float PlayerScore;
        public static float GlobalMoveSpeed;
        public static int Difficulty;
        public static int ProjectileCount;
        public static PlayerWeaponType PlayerWeaponType;
        public static GamePhase GamePhase;


        public static void AddScore()
        {
            
        }

        public static void Reset()
        {
            LocationDatas = new Dictionary<int, LocationData>();
            PlayerScore = 0f;
            PlayerWeaponType = PlayerWeaponType.Default;
            GamePhase = GamePhase.Regular;

            if (Difficulty > Settings.StartSpeeds.Length) return;
            if (Difficulty > Settings.StartProjectiles.Length) return;
            
            GlobalMoveSpeed = Settings.StartSpeeds[Difficulty];
            ProjectileCount = Settings.StartProjectiles[Difficulty];
        }
    
        public static void UpdateData(int instanceId, LocationData data)
        {
            if (!LocationDatas.ContainsKey(instanceId))
            {
                LocationDatas.Add(instanceId,data);
            }
            LocationDatas[instanceId] = data;
        }

        public static LocationData GetLocationData(int guid)
        {
            return LocationDatas[guid];
        }
    }

    public enum PlayerWeaponType
    {
        Default,
        Spread,
        Penetrator,
    }
}