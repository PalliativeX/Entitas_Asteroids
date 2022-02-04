using UnityEngine;

namespace Sources.Systems.InputLogic
{
    public interface IInputService
    {
        Vector3 Movement { get; }
        bool ShootPressed { get; }
        bool PausePressed { get; }
    }
}