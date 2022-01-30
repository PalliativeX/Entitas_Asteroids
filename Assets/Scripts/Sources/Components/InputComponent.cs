using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game, Unique]
public class InputComponent : IComponent
{
    public Vector3 Value;
}