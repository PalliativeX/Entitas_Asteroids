using Entitas;
using UnityEngine;

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
            Transform playerTransform = _contexts.game.playerEntity.view.Value.transform;
            Vector3 playerRotation = playerTransform.rotation.eulerAngles;
            playerRotation.z -= input * _contexts.game.gameSetup.value.RotationSpeed * Time.deltaTime;
            playerTransform.rotation = Quaternion.Euler(playerRotation);
        }
    }
}