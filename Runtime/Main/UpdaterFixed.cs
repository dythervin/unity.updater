using System;
using UnityEngine;

namespace Dythervin.Updaters.Main
{
    public sealed class UpdaterFixed : UpdaterBase<UpdaterFixed, IUpdatableFixed, IUpdatableFixedDelta>
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