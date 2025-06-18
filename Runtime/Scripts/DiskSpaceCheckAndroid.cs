using UnityEngine;

namespace VirtueSky.DiskSpaceChecker {
    internal static class DiskSpaceCheckAndroid {
        internal static long GetAvailableDiskSize() {
#if UNITY_ANDROID && !UNITY_EDITOR
        try {
            using (AndroidJavaObject file = new AndroidJavaObject("java.io.File", Application.persistentDataPath))
            using (AndroidJavaObject statFs =
                   new AndroidJavaObject("android.os.StatFs", file.Call<string>("getAbsolutePath"))) {
                long blockSize = statFs.Call<long>("getBlockSizeLong");
                long availableBlocks = statFs.Call<long>("getAvailableBlocksLong");
                return blockSize * availableBlocks;
            }
        }
        catch (System.Exception e) {
            Debug.LogError("Failed to get Android storage: " + e.Message);
            return -1;
        }
#else
            return 0;
#endif
        }
    }
}