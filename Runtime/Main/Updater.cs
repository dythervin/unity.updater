using System;
using UnityEngine;

namespace Dythervin.Updater.Main
{
    public sealed class Updater : UpdaterBase<Updater, IUpdatable, IUpdatableDelta>
    {
        protected override void ForEach(float deltaTime)
        {
            foreach (var updatable in values)
            {
                try
                {
                    if (!values.ToRemove(updatable))
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
                    if (!valuesDelta.ToRemove(updatable))
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