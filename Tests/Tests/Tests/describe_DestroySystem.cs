using NSpec;

namespace Tests.Tests
{
    class describe_DestroySystem : nspec
    {
        void when_executing()
        {
            it["destroys entity"] = () =>
            {
                // given
                var contexts = new Contexts();
                var destroySystem = new DestroySystem(contexts);
                
                var entity = contexts.game.CreateEntity();
                entity.isDestroy = true;
                
                // when
                destroySystem.Execute();
                
                // then
                entity.isDestroy.should_be_false();
            };
        }
    }
}