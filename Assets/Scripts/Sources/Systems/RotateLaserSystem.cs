using System.Collections.Generic;
using Entitas;
using UnityEngine;
using Views;

namespace Sources.Systems
{
    public sealed class RotateLaserSystem : ReactiveSystem<GameEntity>
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
                IViewController view = entity.view.Value;
                Vector3 acceleration = entity.acceleration.Value;
                
                view.UpVector = acceleration.normalized;
            }
        }
    }
}