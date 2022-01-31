using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game]
public sealed class ViewComponent : IComponent
{
    [EntityIndex]
    public GameObject Value;
}