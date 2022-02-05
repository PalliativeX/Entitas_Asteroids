using Entitas;
using UnityEngine;

namespace Sources.Components
{
    [Game]
    public sealed class AssetComponent : IComponent
    {
        public string Value;
    }
}