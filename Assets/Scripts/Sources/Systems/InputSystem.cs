using Entitas;
using UnityEngine;

public class InputSystem : IExecuteSystem
{
    private readonly Contexts _contexts;

    public InputSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        _contexts.input.ReplaceInput(new Vector3(horizontal, vertical, 0f));
    }
}