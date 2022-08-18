namespace Dythervin.Updater
{
    public interface IUpdatableLateDelta : IUpdatableBase
    {
        void OnUpdate(float deltaTime);
    }
}