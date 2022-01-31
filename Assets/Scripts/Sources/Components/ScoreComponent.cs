using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Unique, Event(EventTarget.Any)]
public sealed class ScoreComponent : IComponent
{
    public int Value;
}