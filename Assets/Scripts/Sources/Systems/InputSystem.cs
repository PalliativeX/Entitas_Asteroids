using Entitas;
using UnityEngine;

public sealed class InputSystem : IExecuteSystem
{
    private const string HorizontalAxisName = "Horizontal";
    private const string VerticalAxisName = "Vertical";
    
    private readonly Contexts _contexts;

    public InputSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        float horizontal = Input.GetAxisRaw(HorizontalAxisName);
        float vertical = Input.GetAxisRaw(VerticalAxisName);
        
        _contexts.input.ReplaceInput(new Vector3(horizontal, vertical, 0f));
    }
}