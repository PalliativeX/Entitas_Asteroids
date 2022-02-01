using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Sources.Systems
{
    public class PauseSystem : ReactiveSystem<InputEntity>
    {
        private readonly Contexts _contexts;

        public PauseSystem(Contexts contexts) : base(contexts.input)
        {
            _contexts = contexts;
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.Input);
        }

        protected override bool Filter(InputEntity entity)
        {
            return entity.hasInput && entity.input.PauseButtonPressed;
        }

        protected override void Execute(List<InputEntity> entities)
        {
            _contexts.game.pause.Paused = !_contexts.game.pause.Paused;
            Time.timeScale = _contexts.game.pause.Paused ? 0f : 1f;
        }
    }
}