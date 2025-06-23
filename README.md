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

## Test results

- Check logcat: 

![Screenshot 2025-06-18 114102](https://github.com/user-attachments/assets/103a5467-9412-48cc-b50a-e10f531b35bd)

- Check disk by PC:

![Screenshot 2025-06-18 114201](https://github.com/user-attachments/assets/8e9e7556-8043-445a-a63d-5022999d4d2b)

- Check disk by device:

![Image_20250618_114503_683](https://github.com/user-attachments/assets/a10ee713-a847-4346-b807-c371b00a2e67)

- Note:

```
Maybe the way each OS calculates memory is different so there is a small difference.
```
