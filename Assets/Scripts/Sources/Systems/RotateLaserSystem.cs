using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class RotateLaserSystem : ReactiveSystem<GameEntity>
{
    private readonly Contexts _contexts;
    
    public RotateLaserSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.AllOf(
            GameMatcher.View, GameMatcher.Laser, GameMatcher.Acceleration));
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasView && entity.isLaser && entity.hasAcceleration;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            Transform view = entity.view.Value.transform;
            Vector3 acceleration = entity.acceleration.Value;

            view.transform.up = acceleration.normalized;
        }
    }
}