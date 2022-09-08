namespace Dythervin.Updaters
{
    public interface IUpdatableDelta : IUpdatableBase
    {
        void OnUpdate(float deltaTime);
    }
}