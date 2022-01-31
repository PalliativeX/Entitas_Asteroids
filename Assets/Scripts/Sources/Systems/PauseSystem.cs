using Entitas;
using UnityEngine;

public sealed class PauseSystem : IExecuteSystem
{
    private const KeyCode PauseKeyCode = KeyCode.P;
    
    private readonly Contexts _contexts;

    public PauseSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        if (Input.GetKeyDown(PauseKeyCode))
        {
            _contexts.game.pause.Paused = !_contexts.game.pause.Paused;
            Time.timeScale = _contexts.game.pause.Paused ? 0f : 1f;
        }
    }
}