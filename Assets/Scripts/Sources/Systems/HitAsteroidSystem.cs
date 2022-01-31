﻿using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

public sealed class HitAsteroidSystem : ReactiveSystem<GameEntity>
{
    private readonly Contexts _contexts;
    
    public HitAsteroidSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Collision);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasCollision;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            GameObject first = entity.collision.First;
            GameObject second = entity.collision.Second;

            var firstEntity = _contexts.game.GetEntitiesWithView(first).SingleEntity();
            var secondEntity = _contexts.game.GetEntitiesWithView(second).SingleEntity();

            if (secondEntity.asteroid.Level > 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    GameEntity newEntity = _contexts.game.CreateEntity();
                    newEntity.AddAsteroid(secondEntity.asteroid.Level - 1);
                    newEntity.AddInitialPosition(
                        second.transform.position + new Vector3(Random.Range(-0.05f, 0.05f), Random.Range(-0.05f, 0.05f), 0f));
                }
            }

            firstEntity.isDestroyed = true;
            secondEntity.isDestroyed = true;
        }
    }
}