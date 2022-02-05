using Entitas;
using UnityEngine;
using Views;

namespace Sources.Services.Views
{
    public class UnityViewService : IViewService
    {
        public IViewController LoadAsset(Contexts contexts, IEntity entity, string assetName)
        {
            GameObject viewGo = Object.Instantiate(Resources.Load<GameObject>("Prefabs/" + assetName));
            if (viewGo == null)
                return null;
            
            IViewController viewController = viewGo.GetComponent<IViewController>();
            viewController?.InitializeView(contexts, entity);
            
            return viewController;
        }
    }
}