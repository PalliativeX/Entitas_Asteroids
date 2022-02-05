using Entitas;
using Views;

namespace Sources.Components
{
    [Game]
    public sealed class ViewComponent : IComponent
    {
        public IViewController Value;
    }
}