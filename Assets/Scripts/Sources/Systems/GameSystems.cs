using Sources.Systems.InputLogic;
using Sources.Systems.Logging;
using Sources.Systems.Vfx;

namespace Sources.Systems
{
    public sealed class GameSystems : Feature
    {
        public GameSystems(Contexts contexts)
        {
            Add(new LoadAssetSystem(contexts));
            Add(new InitializePlayerSystem(contexts));
            Add(new InitializeAsteroidsSystem(contexts));
            Add(new InitializePauseSystem(contexts));

            Add(new HandleDebugLogMessageSystem(contexts));

            Add(new ScoreSystem(contexts));

            Add(new GameEventSystems(contexts));

            Add(new RotateLaserSystem(contexts));

            Add(new PauseSystem(contexts));
            Add(new InputSystem(contexts));
            Add(new ShootSystem(contexts));

            Add(new RotatePlayerSystem(contexts));
            Add(new ReplaceAccelerationSystem(contexts));
            Add(new MapAsteroidLevelToResourceSystem(contexts));
            Add(new HitAsteroidSystem(contexts));
            Add(new AsteroidHitVfxInstantiateSystem(contexts));
            Add(new VfxUpdateLifetimeSystem(contexts));

            Add(new MoveSystem(contexts));

            Add(new DestroySystem(contexts));
        }
    }
}