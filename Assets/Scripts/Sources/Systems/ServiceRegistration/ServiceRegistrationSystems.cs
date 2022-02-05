namespace Sources.Systems.ServiceRegistration
{
    public class ServiceRegistrationSystems : Feature
    {
        public ServiceRegistrationSystems(Contexts contexts, Services.Services services)
        {
            Add(new RegisterInputServiceSystem(contexts, services.Input));
            Add(new RegisterLogServiceSystem(contexts, services.Log));
            Add(new RegisterTimeServiceSystem(contexts, services.Time));
            Add(new RegisterViewServiceSystem(contexts, services.View));
        }
    }
}