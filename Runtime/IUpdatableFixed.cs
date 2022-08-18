namespace Dythervin.Updater
{
    public interface IUpdatableFixed : IUpdatableBase
    {
#if UNITY_2021_3_OR_NEWER
        protected internal
#endif
        void OnUpdate();
    }
}