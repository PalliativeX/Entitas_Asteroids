using Entitas;
using UnityEngine;
using Views;

namespace Sources.Systems
{
    public sealed class MoveSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _group;

        public MoveSystem(Contexts contexts)
        {
            _contexts = contexts;
            _group = contexts.game.GetGroup(
                GameMatcher.AllOf(GameMatcher.Acceleration, GameMatcher.View));
        }

        public void Execute()
        {
            foreach (GameEntity entity in _group)
            {
                IViewController view = entity.view.Value;
                Vector3 acceleration = entity.acceleration.Value;
                Vector3 position = view.Position;
                
                position += acceleration * _contexts.meta.timeService.Instance.GetDeltaTime();
                
                entity.view.Value.Position = position;
            }
        }
    }
}