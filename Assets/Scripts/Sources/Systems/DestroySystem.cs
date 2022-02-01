using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace Sources.Systems
{
    public sealed class DestroySystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;
    
        public DestroySystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Destroyed);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.isDestroyed;
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
}