namespace Dythervin.Updater
{
    public interface IUpdatableFixedDelta : IUpdatableBase
    {
        void OnUpdate(float deltaTime);
    }
}