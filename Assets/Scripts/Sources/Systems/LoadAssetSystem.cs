using System.Collections.Generic;
using Entitas;
using Sources.Services.Views;
using Views;

public class LoadAssetSystem : ReactiveSystem<GameEntity>, IInitializeSystem
{
    private readonly Contexts _contexts;
    private IViewService _viewService;

    public LoadAssetSystem(Contexts contexts) : base(contexts.game)
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        _viewService = _contexts.meta.viewService.Instance;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Asset);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasAsset && !entity.hasView;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            IViewController view = _viewService.LoadAsset(_contexts, entity, entity.asset.Value); 
            if (view != null) 
                entity.ReplaceView(view);

            if (entity.hasInitialPosition) 
                view.Position = entity.initialPosition.Value;
        }
    }
}