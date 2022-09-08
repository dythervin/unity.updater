namespace Dythervin.Updaters
{
    public interface IUpdatableFixedDelta : IUpdatableBase
    {
        void OnUpdate(float deltaTime);
    }
}