// <copyright file="Notification.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Form3PublicAPI.Standard;
    using Form3PublicAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Notification.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification"/> class.
        /// </summary>
        public Notification()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification"/> class.
        /// </summary>
        /// <param name="actionTime">action_time.</param>
        /// <param name="actionedBy">actioned_by.</param>
        /// <param name="data">data.</param>
        /// <param name="dataRecordType">data_record_type.</param>
        /// <param name="eventType">event_type.</param>
        /// <param name="id">id.</param>
        /// <param name="organisationId">organisation_id.</param>
        /// <param name="recordType">record_type.</param>
        /// <param name="version">version.</param>
        public Notification(
            string actionTime = null,
            Guid? actionedBy = null,
            object data = null,
            string dataRecordType = null,
            string eventType = null,
            Guid? id = null,
            Guid? organisationId = null,
            string recordType = null,
            int? version = null)
        {
            this.ActionTime = actionTime;
            this.ActionedBy = actionedBy;
            this.Data = data;
            this.DataRecordType = dataRecordType;
            this.EventType = eventType;
            this.Id = id;
            this.OrganisationId = organisationId;
            this.RecordType = recordType;
            this.Version = version;
        }

        /// <summary>
        /// Timestamp when the event that triggered the notification occurred.
        /// </summary>
        [JsonProperty("action_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionTime { get; set; }

        /// <summary>
        /// The ID of the user that made the change that triggered this notification. This can be the user ID of a customer or a Form3 system user.
        /// </summary>
        [JsonProperty("actioned_by", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ActionedBy { get; set; }

        /// <summary>
        /// The full resource itself (as you would see from a GET request)
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public object Data { get; set; }

        /// <summary>
        /// Internal representation of the record type. Field values are subject to frequent change, evaluation of this field is discouraged.
        /// </summary>
        [JsonProperty("data_record_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DataRecordType { get; set; }

        /// <summary>
        /// The type of event
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// Unique resource ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Unique ID of the organisation this resource is created by
        /// </summary>
        [JsonProperty("organisation_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganisationId { get; set; }

        /// <summary>
        /// The type of resource contained in `data`
        /// </summary>
        [JsonProperty("record_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordType { get; set; }

        /// <summary>
        /// Version number
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Notification : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is Notification other &&                ((this.ActionTime == null && other.ActionTime == null) || (this.ActionTime?.Equals(other.ActionTime) == true)) &&
                ((this.ActionedBy == null && other.ActionedBy == null) || (this.ActionedBy?.Equals(other.ActionedBy) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.DataRecordType == null && other.DataRecordType == null) || (this.DataRecordType?.Equals(other.DataRecordType) == true)) &&
                ((this.EventType == null && other.EventType == null) || (this.EventType?.Equals(other.EventType) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.OrganisationId == null && other.OrganisationId == null) || (this.OrganisationId?.Equals(other.OrganisationId) == true)) &&
                ((this.RecordType == null && other.RecordType == null) || (this.RecordType?.Equals(other.RecordType) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ActionTime = {(this.ActionTime == null ? "null" : this.ActionTime)}");
            toStringOutput.Add($"this.ActionedBy = {(this.ActionedBy == null ? "null" : this.ActionedBy.ToString())}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");
            toStringOutput.Add($"this.DataRecordType = {(this.DataRecordType == null ? "null" : this.DataRecordType)}");
            toStringOutput.Add($"this.EventType = {(this.EventType == null ? "null" : this.EventType)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.OrganisationId = {(this.OrganisationId == null ? "null" : this.OrganisationId.ToString())}");
            toStringOutput.Add($"this.RecordType = {(this.RecordType == null ? "null" : this.RecordType)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version.ToString())}");
        }
    }
}