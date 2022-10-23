using System;
using UnityEngine;

namespace Dythervin.UpdateSystem.Main
{
    public sealed class UpdaterLate : UpdaterBase<UpdaterLate, IUpdatableLate, IUpdatableLateDelta>
    {
        protected override void ForEach(float deltaTime)
        {
            foreach (var updatable in values)
            {
                try
                {
                    if (!values.IsToRemove(updatable))
                        updatable.OnUpdate();
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }

            foreach (var updatable in valuesDelta)
            {
                try
                {
                    if (!valuesDelta.IsToRemove(updatable))
                        updatable.OnUpdate(deltaTime);
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }
        }
    }
}