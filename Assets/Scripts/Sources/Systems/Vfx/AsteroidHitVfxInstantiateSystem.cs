using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Sources.Systems.Vfx
{
    public sealed class AsteroidHitVfxInstantiateSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;
    
        public AsteroidHitVfxInstantiateSystem(Contexts contexts) : base(contexts.game)
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
                GameObject second = entity.collision.Second;
            
                GameEntity vfxEntity = _contexts.game.CreateEntity();
                vfxEntity.AddResource(_contexts.game.gameSetup.value.HitParticleEffect);
                vfxEntity.AddInitialPosition(second.transform.position);
                vfxEntity.AddVfx(_contexts.game.gameSetup.value.AsteroidHitVfxLifetime);
            }
        }
    }
}