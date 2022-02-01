using Entitas;
using UnityEngine;

namespace Sources.Components
{
    [Game]
    public sealed class CollisionComponent : IComponent
    {
        public GameObject First;
        public GameObject Second;
    }
}