﻿namespace MareSynchronos.API
{
    public record SystemInfoDto
    {
        public double CpuUsage { get; set; }
        public long CacheUsage { get; set; }
        public int UploadedFiles { get; set; }
        public double NetworkIn { get; set; }
        public double NetworkOut { get; set; }
        public int OnlineUsers { get; set; }
        public long RAMUsage { get; set; }
    }
}
