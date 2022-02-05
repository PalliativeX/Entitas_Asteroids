using Sources.Services.Input;
using Sources.Services.Logging;
using Sources.Services.Time;
using Sources.Services.Views;
using Sources.Systems.InputLogic;
using Sources.Systems.Logging;

namespace Sources.Services
{
    public class Services
    {
        public readonly IInputService Input;
        public readonly ILogService Log;
        public readonly ITimeService Time;
        public readonly IViewService View;

        public Services(IInputService input, ILogService log, ITimeService time, IViewService view)
        {
            Input = input;
            Log = log;
            Time = time;
            View = view;
        }
        
    }
}