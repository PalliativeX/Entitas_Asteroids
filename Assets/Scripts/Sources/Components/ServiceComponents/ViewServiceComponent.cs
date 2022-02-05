using Entitas;
using Entitas.CodeGeneration.Attributes;
using Sources.Services.Views;

namespace Sources.Components.ServiceComponents
{
    [Meta, Unique]
    public class ViewServiceComponent : IComponent
    {
        public IViewService Instance;
    }
}