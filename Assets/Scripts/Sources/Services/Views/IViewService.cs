using Entitas;
using Views;

namespace Sources.Services.Views
{
    public interface IViewService
    {
        IViewController LoadAsset(Contexts contexts, IEntity entity, string assetName);
    }
}