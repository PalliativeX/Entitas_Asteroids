using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Sources.Systems.Vfx
{
    public sealed class VfxUpdateLifetimeSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;

        public VfxUpdateLifetimeSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Vfx);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasVfx;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                float newLifetimeLeft = entity.vfx.DurationLeft - Time.deltaTime;
                entity.ReplaceVfx(newLifetimeLeft);

                if (newLifetimeLeft <= 0f)
                    entity.isDestroyed = true;
            }
        }
    }
}