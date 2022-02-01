using TMPro;
using UnityEngine;

namespace Views.UI
{
    public class VelocityLabelController : MonoBehaviour, IAnyAccelerationListener
    {
        public TMP_Text Label;

        private void Start()
        {
            GameEntity listener = Contexts.sharedInstance.game.CreateEntity();
            listener.AddAnyAccelerationListener(this);
        }

        public void OnAnyAcceleration(GameEntity entity, Vector3 value)
        {
            if (entity.isPlayer)
                Label.text = $"Accel.: {value}";
        }
    }
}