using UnityEngine;

namespace Views
{
    public class EmitTriggerEntityBehaviour : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            GameEntity entity = Contexts.sharedInstance.game.CreateEntity();
            entity.AddCollision(GetComponent<IViewController>(), other.GetComponent<IViewController>());
            Debug.Log(entity.collision.First + " " + entity.collision.Second);
        }
    }
}