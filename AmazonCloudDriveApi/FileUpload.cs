﻿// <copyright file="AmazonFiles.cs" company="Rambalac">
// Copyright (c) Rambalac. All rights reserved.
// </copyright>

using System;
using System.IO;
using System.Threading;

namespace Azi.Amazon.CloudDrive
{
    /// <summary>
    /// Information about file to upload
    /// </summary>
    public class FileUpload
    {
        /// <summary>
        /// Gets or sets folder Id to place new file into.
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or sets file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets Stream creator func with content to upload. Can be requested multiple time in case of retry.
        /// </summary>
        public Func<Stream> StreamOpener { get; set; }

        /// <summary>
        /// Gets or sets upload Cancellation Token
        /// </summary>
        public CancellationToken CancellationToken { get; set; }

        /// <summary>
        /// Gets or sets flag to allow duplicate uploads.
        /// If it's False and file MD5 is the same as some other file in the cloud then HTTP error Conflict will be thrown
        /// </summary>
        public bool AllowDuplicate { get; set; }

        /// <summary>
        /// Gets or sets progress func.
        /// </summary>
        public Func<long, long> Progress { get; set; } = null;
    }
}