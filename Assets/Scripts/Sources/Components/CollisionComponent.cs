using Entitas;
using UnityEngine;
using Views;

namespace Sources.Components
{
    [Game]
    public sealed class CollisionComponent : IComponent
    {
        public IViewController First;
        public IViewController Second;
    }
}