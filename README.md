<p align="left">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
    <img alt="License" src="https://img.shields.io/github/license/unity-package/disk-space-checker-unity?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/unity-package/disk-space-checker-unity?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/unity-package/disk-space-checker-unity?logo=VirtualBox">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/unity-package/disk-space-checker-unity?include_prereleases&logo=Dropbox&color=yellow">
  </a>
</p>

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

![Image_20250618_114503_683](https://github.com/user-attachments/assets/75bcd8d9-9153-422a-9dd5-671683c59632)


- Note:

```
Maybe the way each OS calculates memory is different so there is a small difference.
```
