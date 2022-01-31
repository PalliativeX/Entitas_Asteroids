using Entitas;
using UnityEngine;

[Game]
public sealed class CollisionComponent : IComponent
{
    public GameObject First;
    public GameObject Second;
}