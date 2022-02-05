using Entitas;
using UnityEngine;
using Views;

namespace Sources.Systems
{
    public sealed class RotatePlayerSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;

        public RotatePlayerSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Execute()
        {
            float input = _contexts.input.input.Movement.x;
            IViewController playerTransform = _contexts.game.playerEntity.view.Value;
            Vector3 playerRotation = playerTransform.RotationEuler;
            playerRotation.z -= input * _contexts.game.gameSetup.value.RotationSpeed * _contexts.meta.timeService.Instance.GetDeltaTime();
            playerTransform.RotationEuler = playerRotation;
        }
    }
}