using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Sources.Components
{
    [Game, Unique, Event(EventTarget.Any)]
    public sealed class ScoreComponent : IComponent
    {
        public int Value;
    }
}