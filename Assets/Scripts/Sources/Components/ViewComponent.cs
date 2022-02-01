using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Sources.Components
{
    [Game]
    public sealed class ViewComponent : IComponent
    {
        [EntityIndex]
        public GameObject Value;
    }
}