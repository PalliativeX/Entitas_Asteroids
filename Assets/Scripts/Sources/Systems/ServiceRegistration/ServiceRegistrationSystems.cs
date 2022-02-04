using Entitas;
using Sources.Services;

public class ServiceRegistrationSystems : Feature
{
    public ServiceRegistrationSystems(Contexts contexts, Services services)
    {
        Add(new RegisterInputServiceSystem(contexts, services.Input));
        Add(new RegisterLogServiceSystem(contexts, services.Log));
    }
}