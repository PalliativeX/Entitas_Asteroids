using Entitas;
using UnityEngine;

namespace Sources.Components
{
    [Game]
    public sealed class InitialPositionComponent : IComponent
    {
        public Vector3 Value;
    }
}