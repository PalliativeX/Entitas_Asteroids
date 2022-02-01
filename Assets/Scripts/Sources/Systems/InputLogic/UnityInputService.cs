using UnityEngine;

namespace Sources.Systems.InputLogic
{
    public class UnityInputService : IInputService
    {
        private const string HorizontalAxisName = "Horizontal";
        private const string VerticalAxisName = "Vertical";
        
        private const string FireButtonKey = "Fire";
        
        private const KeyCode PauseKeyCode = KeyCode.P;

        public Vector3 Movement => 
            new Vector3(Input.GetAxisRaw(HorizontalAxisName), Input.GetAxisRaw(VerticalAxisName), 0f);

        public bool ShootPressed => 
            Input.GetButtonDown(FireButtonKey);
        
        public bool PausePressed => 
            Input.GetKeyDown(PauseKeyCode);
    }
}