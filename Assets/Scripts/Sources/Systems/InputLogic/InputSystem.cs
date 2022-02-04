using Entitas;
using UnityEngine;

namespace Sources.Systems.InputLogic
{
    public sealed class InputSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;

        public InputSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Execute()
        {
            IInputService inputService = _contexts.meta.inputService.Instance;
            
            Vector3 movement = inputService.Movement;
            bool shootPressed = inputService.ShootPressed;
            bool pausePressed = inputService.PausePressed;
        
            _contexts.input.ReplaceInput(movement, shootPressed, pausePressed);
        }
    }
}