using Entitas;
using UnityEngine;

namespace Sources.Systems.InputLogic
{
    public sealed class InputSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IInputService _inputService;

        public InputSystem(Contexts contexts, IInputService inputService)
        {
            _contexts = contexts;
            _inputService = inputService;
        }

        public void Execute()
        {
            Vector3 movement = _inputService.Movement;
            bool shootPressed = _inputService.ShootPressed;
            bool pausePressed = _inputService.PausePressed;
        
            _contexts.input.ReplaceInput(movement, shootPressed, pausePressed);
        }
    }
}