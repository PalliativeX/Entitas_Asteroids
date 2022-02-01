using Entitas;

namespace Sources.Systems.InputLogic
{
    public class EmitInputSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IInputService _inputService;

        public EmitInputSystem(Contexts contexts, IInputService inputService)
        {
            _contexts = contexts;
            _inputService = inputService;
        }

        public void Execute()
        {
            
        }
    }
}