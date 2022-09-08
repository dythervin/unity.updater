namespace Dythervin.Updaters
{
    public interface IUpdatableLateDelta : IUpdatableBase
    {
        void OnUpdate(float deltaTime);
    }
}