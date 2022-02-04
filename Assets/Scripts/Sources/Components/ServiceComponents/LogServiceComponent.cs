using Entitas;
using Entitas.CodeGeneration.Attributes;
using Sources.Systems.Logging;

[Meta, Unique]
public class LogServiceComponent : IComponent
{
    public ILogService Instance;
}