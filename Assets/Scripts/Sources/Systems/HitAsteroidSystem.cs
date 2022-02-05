using System.Collections.Generic;
using Entitas;
using UnityEngine;
using Views;

namespace Sources.Systems
{
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
                IViewController first = entity.collision.First;
                IViewController second = entity.collision.Second;
                
                var firstEntity = first.Entity;
                var secondEntity = second.Entity;
                
                if (secondEntity.asteroid.Level > 0)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        GameEntity newEntity = _contexts.game.CreateEntity();
                        newEntity.AddAsteroid(secondEntity.asteroid.Level - 1);
                        newEntity.AddInitialPosition(
                            second.Position + new Vector3(Random.Range(-0.05f, 0.05f), Random.Range(-0.05f, 0.05f), 0f));
                    }
                }
                
                firstEntity.isDestroyed = true;
                secondEntity.isDestroyed = true;
            }
        }
    }
}