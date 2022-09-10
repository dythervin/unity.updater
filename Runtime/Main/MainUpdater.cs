using Dythervin.Core.Utils;
using UnityEngine;

namespace Dythervin.Updaters.Main
{
    [AddComponentMenu("")]
    internal class MainUpdater : MonoBehaviour
    {
        private void Update()
        {
            Updater.Instance.Update(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            UpdaterFixed.Instance.Update(Time.fixedDeltaTime);
        }

        private void LateUpdate()
        {
            UpdaterLate.Instance.Update(Time.deltaTime);
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void InitStatic()
        {
            GameObject gameObject = PersistentRoot.Get("MainUpdater");
            gameObject.AddComponent<MainUpdater>();
            gameObject.hideFlags = HideFlags.NotEditable;
        }
    }
}