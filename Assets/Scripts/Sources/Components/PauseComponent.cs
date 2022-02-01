using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Sources.Components
{
    [Game, Unique]
    public sealed class PauseComponent : IComponent
    {
        public bool Paused;
    }
}