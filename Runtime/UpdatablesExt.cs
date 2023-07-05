using Dythervin.UpdateSystem.Main;

namespace Dythervin.UpdateSystem
{
    public static class UpdatablesExt
    {
        public static void SetUpdater(this IUpdatable updatable, bool value)
        {
            Main.Updater.Instance.Set(updatable, value);
        }

        public static bool GetUpdater(this IUpdatableDelta updatable)
        {
            return Main.Updater.Instance.Contains(updatable);
        }

        public static bool GetUpdater(this IUpdatable updatable)
        {
            return Main.Updater.Instance.Contains(updatable);
        }

        public static bool GetFixedUpdater(this IUpdatableFixed updatable)
        {
            return UpdaterFixed.Instance.Contains(updatable);
        }


        public static bool GetLateUpdater(this IUpdatableLate updatable)
        {
            return UpdaterLate.Instance.Contains(updatable);
        }

        public static bool GetLateUpdater(this IUpdatableLateDelta updatable)
        {
            return UpdaterLate.Instance.Contains(updatable);
        }

        public static void SetUpdater(this IUpdatableDelta updatable, bool value)
        {
            Main.Updater.Instance.Set(updatable, value);
        }

        public static bool GetUpdatableInterval(this IUpdatableInterval updatable)
        {
            return Main.UpdaterInterval.Instance.Contains(updatable);
        }

        public static void SetUpdatableInterval(this IUpdatableInterval updatable, bool value)
        {
            Main.UpdaterInterval.Instance.Set(updatable, value);
        }

        public static bool GetFixedUpdater(this IUpdatableFixedDelta updatable)
        {
            return UpdaterFixed.Instance.Contains(updatable);
        }

        public static void SetFixedUpdater(this IUpdatableFixed updatable, bool value)
        {
            UpdaterFixed.Instance.Set(updatable, value);
        }

        public static void SetFixedUpdater(this IUpdatableFixedDelta updatable, bool value)
        {
            UpdaterFixed.Instance.Set(updatable, value);
        }

        public static void SetLateUpdater(this IUpdatableLate updatable, bool value)
        {
            UpdaterLate.Instance.Set(updatable, value);
        }


        public static void SetLateUpdater(this IUpdatableLateDelta updatable, bool value)
        {
            UpdaterLate.Instance.Set(updatable, value);
        }
    }
}