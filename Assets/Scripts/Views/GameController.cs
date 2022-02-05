using Configs;
using Entitas;
using Sources.Services;
using Sources.Services.Input;
using Sources.Services.Logging;
using Sources.Services.Time;
using Sources.Services.Views;
using Sources.Systems;
using Sources.Systems.InputLogic;
using Sources.Systems.Logging;
using Sources.Systems.ServiceRegistration;
using UnityEngine;

namespace Views
{
    public class GameController : MonoBehaviour
    {
        public GameSetup GameSetup;
    
        private Systems _systems;
        private ServiceRegistrationSystems _registrationSystems;
        private Services _services;

        private void Start()
        {
            Contexts contexts = Contexts.sharedInstance;

            contexts.game.SetGameSetup(GameSetup);

            _services = CreateServices();
            
            _registrationSystems = new ServiceRegistrationSystems(contexts, _services);
            _registrationSystems.Initialize();
            
            _systems = new GameSystems(contexts);
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private static Services CreateServices()
        {
            return new Services(
                new UnityInputService(), 
                new UnityDebugLogService(), 
                new UnityTimeService(),
                new UnityViewService());
        }
    }
}
