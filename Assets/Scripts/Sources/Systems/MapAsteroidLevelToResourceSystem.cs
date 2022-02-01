using System.Collections.Generic;
using Configs;
using Entitas;
using UnityEngine;
using Utils;

namespace Sources.Systems
{
    public sealed class MapAsteroidLevelToResourceSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;
    
        public MapAsteroidLevelToResourceSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Asteroid);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasAsteroid;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            GameSetup setup = _contexts.game.gameSetup.value;
            foreach (GameEntity entity in entities)
            {
                entity.AddResource(MapAsteroidLevelToResource(entity.asteroid.Level, setup));
            
                float speed = _contexts.game.gameSetup.value.AsteroidSpeed;
                float randomAngle = Random.Range(0f, 2f);
                entity.AddAcceleration(new Vector3(
                    speed * Mathf.Cos(randomAngle),
                    speed * Mathf.Sin(randomAngle), 0f));
            }
        }

        private GameObject MapAsteroidLevelToResource(int level, GameSetup setup)
        {
            switch (level)
            {
                case 0:
                    return setup.Tinys.GetRandom();
                case 1:
                    return setup.Smalls.GetRandom();
                case 2:
                    return setup.Mediums.GetRandom();
                default:
                    return setup.Bigs.GetRandom();
            }
        }
    }
}