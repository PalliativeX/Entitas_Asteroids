using System.Collections.Generic;
using Entitas;

namespace Sources.Systems.Logging
{
    public class HandleDebugLogMessageSystem : ReactiveSystem<GameEntity>
    {
        private readonly ILogService _logService;

        public HandleDebugLogMessageSystem(Contexts contexts, ILogService logService) : base(contexts.game)
        {
            _logService = logService;
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
                _logService.LogMessage(entity.debugLog.Message);
                entity.isDestroyed = true;
            }
        }
    }
}