using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameSetup GameSetup;
    
    private Systems _systems;
    
    private void Start()
    {
        Contexts contexts = Contexts.sharedInstance;

        contexts.game.SetGameSetup(GameSetup);
        
        _systems = new GameSystems(contexts);
        
        _systems.Initialize();
    }

    private void Update()
    {
        _systems.Execute();
        _systems.Cleanup();
    }
}
