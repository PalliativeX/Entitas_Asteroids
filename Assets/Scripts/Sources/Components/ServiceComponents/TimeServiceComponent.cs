using Entitas;
using Entitas.CodeGeneration.Attributes;
using Sources.Services.Time;

namespace Sources.Components.ServiceComponents
{
    [Meta, Unique]
    public class TimeServiceComponent : IComponent
    {
        public ITimeService Instance;
    }
}