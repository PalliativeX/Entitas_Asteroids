using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

public sealed class InstantiateViewSystem : ReactiveSystem<GameEntity>
{
    private readonly Contexts _contexts;
    
    public InstantiateViewSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Resource.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasResource;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            GameObject gameObject = Object.Instantiate(entity.resource.Prefab);
            entity.AddView(gameObject);
            gameObject.Link(entity);

            if (entity.hasInitialPosition)
            {
                gameObject.transform.position = entity.initialPosition.Value;
            }
        }
    }
}