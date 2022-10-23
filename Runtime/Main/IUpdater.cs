using System;

namespace Dythervin.UpdateSystem.Main
{
    public interface IUpdater
    {
        event Action<float> OnUpdateDelta;
        event Action OnUpdate;
        event Action<float> OnUpdateDeltaOnce;
        event Action OnUpdateOnce;
    }
}