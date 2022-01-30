using Entitas;
using UnityEngine;

public class InitializeAsteroidsSystem : IInitializeSystem
{
    private readonly Contexts _contexts;

    public InitializeAsteroidsSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        for (int i = 0; i < 4; i++)
        {
            GameEntity entity = _contexts.game.CreateEntity();
            entity.AddAsteroid(3);
            entity.AddInitialPosition(new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), 0f));
        }
    }
}