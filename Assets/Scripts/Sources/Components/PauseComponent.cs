using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Unique]
public sealed class PauseComponent : IComponent
{
    public bool Paused;
}