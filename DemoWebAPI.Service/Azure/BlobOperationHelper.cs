﻿namespace Demo.Services.Azure
{
    /// <summary>
    /// 
    /// </summary>
    public class BlobOperationHelper
    {
        public string SourcePath { get; set; }

        public string DestinationPath { get; set; }

        public string StorageAccountName { get; set; }

        public string ContainerName { get; set; }

        public string StorageEndPoint { get; set; }

        public string BlobName { get; set; }

        public string BlobContentType { get; set; }
    }
}
