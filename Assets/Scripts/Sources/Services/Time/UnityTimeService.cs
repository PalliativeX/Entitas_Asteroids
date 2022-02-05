namespace Sources.Services.Time
{
    public class UnityTimeService : ITimeService
    {
        public float GetDeltaTime()
        {
            return UnityEngine.Time.deltaTime;
        }
    }
}