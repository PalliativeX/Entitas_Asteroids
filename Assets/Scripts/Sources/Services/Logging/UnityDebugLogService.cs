using UnityEngine;

namespace Sources.Systems.Logging
{
    public class UnityDebugLogService : ILogService
    {
        public void LogMessage(string message)
        {
            Debug.Log(message);
        }
    }
}