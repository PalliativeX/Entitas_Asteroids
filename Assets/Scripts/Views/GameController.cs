using Configs;
using Entitas;
using Sources.Services;
using Sources.Systems;
using Sources.Systems.InputLogic;
using Sources.Systems.Logging;
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

            _services = new Services(new UnityInputService(), new UnityDebugLogService());
            
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
    }
}
