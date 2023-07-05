namespace Dythervin.UpdateSystem
{
    public interface IUpdatableFixedDelta : IUpdatableBase
    {
#if UNITY_2021_3_OR_NEWER
        protected internal
#endif
        void OnUpdate(float deltaTime);
    }
}