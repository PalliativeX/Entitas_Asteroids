using System.Collections.Generic;
using Entitas;
using UnityEngine;

public sealed class ScoreSystem : ReactiveSystem<GameEntity>, IInitializeSystem
{
    private readonly Contexts _contexts;
    
    public ScoreSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        _contexts.game.SetScore(0);
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
        _contexts.game.ReplaceScore(_contexts.game.score.Value + entities.Count);
    }
}