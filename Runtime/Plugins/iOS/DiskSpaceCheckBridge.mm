#import <sys/mount.h>

extern "C" {
    long _getFreeDiskSpace() {
        struct statfs stats;
        if (statfs("/", &stats) == 0) {
            return (long)stats.f_bsize * stats.f_bavail;
        }
        return -1;
    }
}
