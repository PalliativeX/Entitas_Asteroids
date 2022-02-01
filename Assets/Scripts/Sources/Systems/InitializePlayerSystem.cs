using Entitas;
using UnityEngine;

namespace Sources.Systems
{
    public sealed class InitializePlayerSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitializePlayerSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            GameEntity entity = _contexts.game.CreateEntity();
            entity.isPlayer = true;
            entity.AddResource(_contexts.game.gameSetup.value.Player);
            entity.AddInitialPosition(Vector3.zero);
            entity.AddAcceleration(Vector3.zero);
        }
    }
}