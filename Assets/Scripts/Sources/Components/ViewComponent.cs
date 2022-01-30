using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game]
public class ViewComponent : IComponent
{
    [EntityIndex]
    public GameObject Value;
}