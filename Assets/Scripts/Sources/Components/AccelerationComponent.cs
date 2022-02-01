using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Sources.Components
{
    [Game, Event(EventTarget.Any)]
    public sealed class AccelerationComponent : IComponent
    {
        public Vector3 Value;
    }
}