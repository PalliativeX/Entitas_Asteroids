using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Configs
{
    [Game, Unique]
    [CreateAssetMenu(fileName = "GameSetup", menuName = "ScriptableObjects/GameSetup", order = 0)]
    public class GameSetup : ScriptableObject
    {
        public string PlayerPath;
        public string LaserPath;
        public string HitParticleEffectPath;
    
        public float RotationSpeed = 180f;
        public float PlayerMovementSpeed = 5f;
        public float LaserSpeed = 10f;
        public float AsteroidSpeed = 0.3f;

        public float AsteroidHitVfxLifetime = 2f;

        public string[] Bigs;
        public string[] Mediums;
        public string[] Smalls;
        public string[] Tinys;
    
    }
}