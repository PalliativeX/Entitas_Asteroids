using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Sources.Components
{
    [Input, Unique]
    public sealed class InputComponent : IComponent
    {
        public Vector3 Movement;
        public bool ShootPressed;
        public bool PauseButtonPressed;
    }
}