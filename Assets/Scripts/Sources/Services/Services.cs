using Sources.Systems.InputLogic;
using Sources.Systems.Logging;

namespace Sources.Services
{
    public class Services
    {
        public readonly IInputService Input;
        public readonly ILogService Log;

        public Services(IInputService input, ILogService log)
        {
            Input = input;
            Log = log;
        }
        
    }
}