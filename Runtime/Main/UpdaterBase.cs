using System;
using Dythervin.Collections;
using Dythervin.Core.Utils;
using Sirenix.OdinInspector;

namespace Dythervin.Updaters.Main
{
    public abstract class UpdaterBase<TUpdater, TElement, TElementDelta> : Singleton<TUpdater>
        where TUpdater : Singleton<TUpdater>, new()
    {
        public event Action<float> OnUpdateDelta;
        public event Action OnUpdate;
        public event Action<float> OnUpdateDeltaOnce;
        public event Action OnUpdateOnce;


#if ODIN_INSPECTOR
        [ShowInInspector, ReadOnly]
#endif
        protected readonly LockableHashSet<TElement> values = new LockableHashSet<TElement>();

#if ODIN_INSPECTOR
        [ShowInInspector, ReadOnly]
#endif
        protected readonly LockableHashSet<TElementDelta> valuesDelta = new LockableHashSet<TElementDelta>();

        public void Set(TElement element, bool value)
        {
            if (value)
                values.Add(element);
            else
                values.Remove(element);
        }

        public void Set(TElementDelta element, bool value)
        {
            if (value)
                valuesDelta.Add(element);
            else
                valuesDelta.Remove(element);
        }

        internal bool Contains(TElement listener)
        {
            return values.Contains(listener);
        }

        internal bool Contains(TElementDelta listener)
        {
            return valuesDelta.Contains(listener);
        }

        protected abstract void ForEach(float deltaTime);

        internal void Update(float deltaTime)
        {
            values.Lock(true);
            valuesDelta.Lock(true);
            ForEach(deltaTime);
            values.Lock(false);
            valuesDelta.Lock(false);


            if (OnUpdateDeltaOnce != null)
            {
                var act = OnUpdateDeltaOnce;
                OnUpdateDeltaOnce = null;
                act.Invoke(deltaTime);
            }

            if (OnUpdateOnce != null)
            {
                Action act = OnUpdateOnce;
                OnUpdateOnce = null;
                act.Invoke();
            }

            // ReSharper disable once PossibleNullReferenceException
            OnUpdateDelta?.Invoke(deltaTime);
            // ReSharper disable once PossibleNullReferenceException
            OnUpdate?.Invoke();
        }
    }
}