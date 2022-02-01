using Entitas;
using UnityEngine;

namespace Sources.Components
{
    [Game]
    public sealed class ResourceComponent : IComponent
    {
        public GameObject Prefab;
    }
}