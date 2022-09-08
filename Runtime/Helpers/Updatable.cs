using System;

namespace Dythervin.Updaters.Helpers
{
    public class Updatable : IUpdatable, IUpdatableListener
    {
        public event Action OnUpdate;

        public bool enabled
        {
            get => this.GetUpdater();
            set => this.SetUpdater(value);
        }

        public Updatable(Action onUpdate = null, bool enabled = false)
        {
            OnUpdate = onUpdate;
            if (enabled)
                this.enabled = true;
        }

        void IUpdatable.OnUpdate()
        {
            OnUpdate?.Invoke();
        }
    }
}