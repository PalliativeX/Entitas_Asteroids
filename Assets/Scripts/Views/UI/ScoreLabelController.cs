using TMPro;
using UnityEngine;

namespace Views.UI
{
    public class ScoreLabelController : MonoBehaviour, IAnyScoreListener
    {
        public TMP_Text Label;

        private void Start()
        {
            GameEntity listener = Contexts.sharedInstance.game.CreateEntity();
            listener.AddAnyScoreListener(this);
        }

        public void OnAnyScore(GameEntity entity, int value)
        {
            Label.text = $"Score: {value}";
        }
    }
}