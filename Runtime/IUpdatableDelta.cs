namespace Dythervin.Updater
{
    public interface IUpdatableDelta : IUpdatableBase
    {
        void OnUpdate(float deltaTime);
    }
}