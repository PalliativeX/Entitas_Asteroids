using Entitas;
using UnityEngine;

namespace Views
{
    public interface IViewController
    {
        Vector3 Position { get; set; }
        Vector3 UpVector { get; set; }
        Vector3 RotationEuler { get; set; }
        Vector3 Scale { get; set; }
        GameEntity Entity { get; }
        bool Active { get; set; }
        void InitializeView(Contexts contexts, IEntity Entity);
        void DestroyView();
    }
}