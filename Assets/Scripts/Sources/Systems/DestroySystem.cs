using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

public class DestroySystem : ReactiveSystem<GameEntity>
{
    private readonly Contexts _contexts;
    
    public DestroySystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Destroy);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isDestroy;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            if (entity.hasView)
            {
                GameObject view = entity.view.Value;
                view.Unlink();
                Object.Destroy(view);
            }
            
            entity.Destroy();
        }
    }
}