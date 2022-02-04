using System.Collections.Generic;
using Entitas;

namespace Sources.Systems.Logging
{
    public class HandleDebugLogMessageSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;
        
        public HandleDebugLogMessageSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.DebugLog);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasDebugLog;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                _contexts.meta.logService.Instance.LogMessage(entity.debugLog.Message);
                entity.isDestroyed = true;
            }
        }
    }
}