﻿using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Configs
{
    [Game, Unique]
    [CreateAssetMenu(fileName = "GameSetup", menuName = "ScriptableObjects/GameSetup", order = 0)]
    public class GameSetup : ScriptableObject
    {
        public GameObject Player;
        public GameObject Laser;
        public GameObject HitParticleEffect;
    
        public float RotationSpeed = 180f;
        public float PlayerMovementSpeed = 5f;
        public float LaserSpeed = 10f;
        public float AsteroidSpeed = 0.3f;

        public float AsteroidHitVfxLifetime = 2f;

        public GameObject[] Bigs;
        public GameObject[] Mediums;
        public GameObject[] Smalls;
        public GameObject[] Tinys;
    
    }
}