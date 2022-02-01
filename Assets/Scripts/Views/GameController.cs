using Configs;
using Entitas;
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
    
        private void Start()
        {
            Contexts contexts = Contexts.sharedInstance;

            contexts.game.SetGameSetup(GameSetup);
        
            _systems = new GameSystems(contexts, new UnityDebugLogService(), new UnityInputService());
        
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }
    }
}
