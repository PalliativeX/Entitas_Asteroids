using Entitas;
using Sources.Services.Views;

namespace Sources.Systems.ServiceRegistration
{
    public class RegisterViewServiceSystem : IInitializeSystem
    {
        private readonly MetaContext _metaContext;
        private readonly IViewService _viewService;

        public RegisterViewServiceSystem(Contexts contexts, IViewService viewService)
        {
            _metaContext = contexts.meta;
            _viewService = viewService;
        }

        public void Initialize()
        {
            _metaContext.ReplaceViewService(_viewService);
        }
    }
}