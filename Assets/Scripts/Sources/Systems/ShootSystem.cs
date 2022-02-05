using Configs;
using Entitas;
using UnityEngine;
using Views;

namespace Sources.Systems
{
    public sealed class ShootSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;

        public ShootSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Execute()
        {
            if (_contexts.input.input.ShootPressed && !_contexts.game.pause.Paused)
            {
                GameEntity entity = _contexts.game.CreateEntity();
                GameSetup setup = _contexts.game.gameSetup.value;

                IViewController playerView = _contexts.game.playerEntity.view.Value;
                Vector3 playerForward = playerView.UpVector;

                entity.AddAsset(_contexts.game.gameSetup.value.LaserPath);
                entity.AddAcceleration(playerForward * setup.LaserSpeed);
                entity.AddInitialPosition(playerView.Position);
                entity.isLaser = true;
            }
        }
    }
}