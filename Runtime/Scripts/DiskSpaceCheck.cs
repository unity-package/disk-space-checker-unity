using UnityEngine;

namespace VirtueSky.DiskSpaceChecker {
    public static class DiskSpaceCheck {
        /// <summary>
        /// Get the available disk size on the device in bytes
        /// </summary>
        /// <returns></returns>
        public static long GetAvailableDiskSize() {
#if UNITY_ANDROID && !UNITY_EDITOR
        return DiskSpaceCheckAndroid.GetAvailableDiskSize();
#elif UNITY_IOS && !UNITY_EDITOR
        return DiskSpaceCheckIos.GetAvailableDiskSize();
#else
            return 0;
#endif
        }

        /// <summary>
        /// Get the available disk size on the device in Megabyte
        /// </summary>
        /// <returns></returns>
        public static float GetAvailableDiskSizeInMB() {
            long availableDiskSize = GetAvailableDiskSize();
            if (availableDiskSize < 0) {
                Debug.LogWarning("Failed to retrieve available disk size.");
                return -1f; // Error case
            }

            return availableDiskSize / (1024f * 1024f); // Convert bytes to MB
        }

        /// <summary>
        /// Get the available disk size on the device in Gigabyte
        /// </summary>
        /// <returns></returns>
        public static float GetAvailableDiskSizeInGB() {
            long availableDiskSize = GetAvailableDiskSize();
            if (availableDiskSize < 0) {
                Debug.LogWarning("Failed to retrieve available disk size.");
                return -1f; // Error case
            }

            return availableDiskSize / (1024f * 1024f * 1024f); // Convert bytes to GB
        }
    }
}