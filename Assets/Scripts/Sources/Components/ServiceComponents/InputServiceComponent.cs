using Entitas;
using Entitas.CodeGeneration.Attributes;
using Sources.Systems.InputLogic;

[Meta, Unique]
public sealed class InputServiceComponent : IComponent
{
    public IInputService Instance;
}