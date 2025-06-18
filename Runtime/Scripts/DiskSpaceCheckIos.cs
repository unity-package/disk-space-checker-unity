using System.Runtime.InteropServices;
using UnityEngine;

namespace VirtueSky.DiskSpaceChecker {
    internal static class DiskSpaceCheckIos {
#if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern long _getFreeDiskSpace();
#endif

        internal static long GetAvailableDiskSize() {
#if UNITY_IOS && !UNITY_EDITOR
        try {
            return _getFreeDiskSpace(); // return in bytes
        }
        catch (System.Exception e) {
            Debug.LogError("Failed to get iOS storage: " + e.Message);
            return -1;
        }
#else
            return 0;
#endif
        }
    }
}