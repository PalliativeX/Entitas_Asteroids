using Entitas;
using Sources.Systems.Logging;

public class RegisterLogServiceSystem : IInitializeSystem
{
    private readonly MetaContext _metaContext;
    private readonly ILogService _logService;

    public RegisterLogServiceSystem(Contexts contexts, ILogService logService)
    {
        _metaContext = contexts.meta;
        _logService = logService;
    }

    public void Initialize()
    {
        _metaContext.ReplaceLogService(_logService);
    }
    
}