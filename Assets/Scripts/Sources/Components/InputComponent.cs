using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Input, Unique]
public class InputComponent : IComponent
{
    public Vector3 Value;
}