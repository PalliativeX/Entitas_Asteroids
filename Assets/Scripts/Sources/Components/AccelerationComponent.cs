using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game, Event(EventTarget.Any)]
public sealed class AccelerationComponent : IComponent
{
    public Vector3 Value;
}