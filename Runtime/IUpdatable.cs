namespace Dythervin.Updaters
{
    public interface IUpdatable : IUpdatableBase
    {
#if UNITY_2021_3_OR_NEWER
        protected internal
#endif
        void OnUpdate();
    }
}