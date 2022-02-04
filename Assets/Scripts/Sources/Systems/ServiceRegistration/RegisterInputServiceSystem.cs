using Entitas;
using Sources.Systems.InputLogic;

public class RegisterInputServiceSystem : IInitializeSystem
{
    private readonly MetaContext _metaContext;
    private readonly IInputService _inputService;

    public RegisterInputServiceSystem(Contexts contexts, IInputService inputService)
    {
        _inputService = inputService;
        _metaContext = contexts.meta;
    }

    public void Initialize()
    {
        _metaContext.ReplaceInputService(_inputService);
    }
}