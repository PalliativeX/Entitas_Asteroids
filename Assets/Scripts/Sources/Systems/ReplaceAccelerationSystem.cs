using Entitas;
using UnityEngine;
using Views;

namespace Sources.Systems
{
    public sealed class ReplaceAccelerationSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;

        public ReplaceAccelerationSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Execute()
        {
            float input = _contexts.input.input.Movement.y;
            GameEntity player = _contexts.game.playerEntity;
            IViewController view = player.view.Value;
            Vector3 forward = view.UpVector;
            float movementSpeed = _contexts.game.gameSetup.value.PlayerMovementSpeed;
            
            Vector3 acceleration = player.acceleration.Value;
            player.ReplaceAcceleration(acceleration + input * forward * movementSpeed * _contexts.meta.timeService.Instance.GetDeltaTime());
        }
    }
}