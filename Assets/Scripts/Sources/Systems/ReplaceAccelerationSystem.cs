using Entitas;
using UnityEngine;

public class ReplaceAccelerationSystem : IExecuteSystem
{
    private readonly Contexts _contexts;
    private readonly IGroup<GameEntity> _group;


    public ReplaceAccelerationSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        float input = _contexts.game.input.Value.y;
        GameEntity player = _contexts.game.playerEntity;
        Transform playerTransform = player.view.Value.transform;
        Vector3 forward = playerTransform.up;
        float movementSpeed = _contexts.game.gameSetup.value.PlayerMovementSpeed;

        Vector3 acceleration = player.acceleration.Value;
        player.ReplaceAcceleration(acceleration + input * forward * movementSpeed * Time.deltaTime);
    }
}