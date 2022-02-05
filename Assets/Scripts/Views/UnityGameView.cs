using Entitas;
using UnityEngine;

namespace Views
{
    public class UnityGameView : MonoBehaviour, IViewController
    {
        private Contexts _contexts;
        private GameEntity _entity;

        public Vector3 Position
        {
            get => transform.position;
            set => transform.position = value;
        }

        public Vector3 UpVector
        {
            get => transform.up;
            set => transform.up = value;
        }

        public Vector3 RotationEuler
        {
            get => transform.eulerAngles;
            set => transform.eulerAngles = value;
        }

        public Vector3 Scale { get; set; }

        public GameEntity Entity => _entity;

        public bool Active
        {
            get => gameObject.activeSelf;
            set => gameObject.SetActive(value);
        }

        public void InitializeView(Contexts contexts, IEntity entity)
        {
            _contexts = contexts;
            _entity = (GameEntity) entity;
        }

        public void DestroyView()
        {
            Destroy(gameObject);
        }
    }
}