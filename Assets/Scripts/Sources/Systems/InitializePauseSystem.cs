using Entitas;

namespace Sources.Systems
{
    public sealed class InitializePauseSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitializePauseSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            GameEntity entity = _contexts.game.CreateEntity();
            entity.AddPause(false);
        }
    }
}