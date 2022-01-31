using NSpec;

class describe_Tests : nspec
{
    void when_testing()
    {
        it["adds 1"] = () =>
        {
            // given
            var i = 0;
            
            // when
            i += 1;
            
            // then
            i.should_be(1);
        };
    }
    
    
}