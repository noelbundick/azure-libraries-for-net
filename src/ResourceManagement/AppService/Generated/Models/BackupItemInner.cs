// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Backup description.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackupItemInner : ProxyOnlyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the BackupItemInner class.
        /// </summary>
        public BackupItemInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupItemInner class.
        /// </summary>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="backupId">Id of the backup.</param>
        /// <param name="storageAccountUrl">SAS URL for the storage account
        /// container which contains this backup.</param>
        /// <param name="blobName">Name of the blob which contains data for
        /// this backup.</param>
        /// <param name="backupItemName">Name of this backup.</param>
        /// <param name="status">Backup status. Possible values include:
        /// 'InProgress', 'Failed', 'Succeeded', 'TimedOut', 'Created',
        /// 'Skipped', 'PartiallySucceeded', 'DeleteInProgress',
        /// 'DeleteFailed', 'Deleted'</param>
        /// <param name="sizeInBytes">Size of the backup in bytes.</param>
        /// <param name="created">Timestamp of the backup creation.</param>
        /// <param name="log">Details regarding this backup. Might contain an
        /// error message.</param>
        /// <param name="databases">List of databases included in the
        /// backup.</param>
        /// <param name="scheduled">True if this backup has been created due to
        /// a schedule being triggered.</param>
        /// <param name="lastRestoreTimeStamp">Timestamp of a last restore
        /// operation which used this backup.</param>
        /// <param name="finishedTimeStamp">Timestamp when this backup
        /// finished.</param>
        /// <param name="correlationId">Unique correlation identifier. Please
        /// use this along with the timestamp while communicating with Azure
        /// support.</param>
        /// <param name="websiteSizeInBytes">Size of the original web app which
        /// has been backed up.</param>
        public BackupItemInner(string id = default(string), string name = default(string), string type = default(string), string kind = default(string), int? backupId = default(int?), string storageAccountUrl = default(string), string blobName = default(string), string backupItemName = default(string), BackupItemStatus? status = default(BackupItemStatus?), long? sizeInBytes = default(long?), System.DateTime? created = default(System.DateTime?), string log = default(string), IList<DatabaseBackupSetting> databases = default(IList<DatabaseBackupSetting>), bool? scheduled = default(bool?), System.DateTime? lastRestoreTimeStamp = default(System.DateTime?), System.DateTime? finishedTimeStamp = default(System.DateTime?), string correlationId = default(string), long? websiteSizeInBytes = default(long?))
            : base(id, name, type, kind)
        {
            BackupId = backupId;
            StorageAccountUrl = storageAccountUrl;
            BlobName = blobName;
            BackupItemName = backupItemName;
            Status = status;
            SizeInBytes = sizeInBytes;
            Created = created;
            Log = log;
            Databases = databases;
            Scheduled = scheduled;
            LastRestoreTimeStamp = lastRestoreTimeStamp;
            FinishedTimeStamp = finishedTimeStamp;
            CorrelationId = correlationId;
            WebsiteSizeInBytes = websiteSizeInBytes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets id of the backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.id")]
        public int? BackupId { get; private set; }

        /// <summary>
        /// Gets SAS URL for the storage account container which contains this
        /// backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountUrl")]
        public string StorageAccountUrl { get; private set; }

        /// <summary>
        /// Gets name of the blob which contains data for this backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.blobName")]
        public string BlobName { get; private set; }

        /// <summary>
        /// Gets name of this backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string BackupItemName { get; private set; }

        /// <summary>
        /// Gets backup status. Possible values include: 'InProgress',
        /// 'Failed', 'Succeeded', 'TimedOut', 'Created', 'Skipped',
        /// 'PartiallySucceeded', 'DeleteInProgress', 'DeleteFailed', 'Deleted'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public BackupItemStatus? Status { get; private set; }

        /// <summary>
        /// Gets size of the backup in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sizeInBytes")]
        public long? SizeInBytes { get; private set; }

        /// <summary>
        /// Gets timestamp of the backup creation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; private set; }

        /// <summary>
        /// Gets details regarding this backup. Might contain an error message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.log")]
        public string Log { get; private set; }

        /// <summary>
        /// Gets list of databases included in the backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databases")]
        public IList<DatabaseBackupSetting> Databases { get; private set; }

        /// <summary>
        /// Gets true if this backup has been created due to a schedule being
        /// triggered.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scheduled")]
        public bool? Scheduled { get; private set; }

        /// <summary>
        /// Gets timestamp of a last restore operation which used this backup.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastRestoreTimeStamp")]
        public System.DateTime? LastRestoreTimeStamp { get; private set; }

        /// <summary>
        /// Gets timestamp when this backup finished.
        /// </summary>
        [JsonProperty(PropertyName = "properties.finishedTimeStamp")]
        public System.DateTime? FinishedTimeStamp { get; private set; }

        /// <summary>
        /// Gets unique correlation identifier. Please use this along with the
        /// timestamp while communicating with Azure support.
        /// </summary>
        [JsonProperty(PropertyName = "properties.correlationId")]
        public string CorrelationId { get; private set; }

        /// <summary>
        /// Gets size of the original web app which has been backed up.
        /// </summary>
        [JsonProperty(PropertyName = "properties.websiteSizeInBytes")]
        public long? WebsiteSizeInBytes { get; private set; }

    }
}
