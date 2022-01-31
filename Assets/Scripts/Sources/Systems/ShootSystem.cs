﻿using Entitas;
using UnityEngine;

public sealed class ShootSystem : IExecuteSystem
{
    private const string FireButtonKey = "Fire";
    
    private readonly Contexts _contexts;

    public ShootSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        if (Input.GetButtonDown(FireButtonKey) && !_contexts.game.pause.Paused)
        {
            GameEntity entity = _contexts.game.CreateEntity();
            GameSetup setup = _contexts.game.gameSetup.value;

            Transform playerTransform = _contexts.game.playerEntity.view.Value.transform;
            Vector3 playerForward = playerTransform.up;
            
            entity.AddResource(_contexts.game.gameSetup.value.Laser);
            entity.AddAcceleration(playerForward * setup.LaserSpeed);
            entity.AddInitialPosition(playerTransform.position);
            entity.isLaser = true;
        }
    }
}