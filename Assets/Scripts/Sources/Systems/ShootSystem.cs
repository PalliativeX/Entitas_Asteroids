using Entitas;
using UnityEngine;

public class ShootSystem : IExecuteSystem
{
    private Contexts _contexts;

    public ShootSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        if (Input.GetButtonDown("Fire"))
        {
            GameEntity entity = _contexts.game.CreateEntity();
            GameSetup setup = _contexts.game.gameSetup.value;

            Transform playerTransform = _contexts.game.playerEntity.view.Value.transform;
            Vector3 playerForward = playerTransform.up;
            
            entity.AddResource(_contexts.game.gameSetup.value.Laser);
            entity.AddAcceleration(playerForward * setup.LaserSpeed);
            entity.AddInitialPosition(playerTransform.position);
            entity.isLaser = true;
        }
    }
}