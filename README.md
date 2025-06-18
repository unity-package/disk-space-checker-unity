## How To Install

### Add the line below to `Packages/manifest.json`

for version `1.0.0`
```json
"com.unity-package.disk-space-checker":"https://github.com/unity-package/disk-space-checker-unity.git#1.0.0",
```

## Use

- Example usage script:

```csharp
    public void CheckDisk() {
        long freeSpace = DiskSpaceCheck.GetAvailableDiskSize();
        float freeSpaceMB = DiskSpaceCheck.GetAvailableDiskSizeInMB();
        float freeSpaceGB = DiskSpaceCheck.GetAvailableDiskSizeInGB();
        Debug.Log($"free space available on disk: {freeSpace} / {freeSpaceMB} MB / {freeSpaceGB}.");
    }
```
