using Entitas;
using UnityEngine;

namespace Sources.Systems
{
    public sealed class InitializeAsteroidsSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitializeAsteroidsSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            for (int i = 0; i < 4; i++)
            {
                GameEntity entity = _contexts.game.CreateEntity();
                entity.AddAsteroid(3);
                entity.AddInitialPosition(new Vector3(Random.Range(-4f, 4f), Random.Range(-3f, 3f), 0f));
            }
        }
    }
}