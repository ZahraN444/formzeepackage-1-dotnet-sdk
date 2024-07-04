// <copyright file="Attributes18.cs" company="APIMatic">
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
    /// Attributes18.
    /// </summary>
    public class Attributes18
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes18"/> class.
        /// </summary>
        public Attributes18()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes18"/> class.
        /// </summary>
        /// <param name="actionTime">action_time.</param>
        /// <param name="actionedBy">actioned_by.</param>
        /// <param name="afterData">after_data.</param>
        /// <param name="beforeData">before_data.</param>
        /// <param name="description">description.</param>
        /// <param name="recordId">record_id.</param>
        /// <param name="recordType">record_type.</param>
        public Attributes18(
            DateTime? actionTime = null,
            Guid? actionedBy = null,
            object afterData = null,
            object beforeData = null,
            string description = null,
            Guid? recordId = null,
            string recordType = null)
        {
            this.ActionTime = actionTime;
            this.ActionedBy = actionedBy;
            this.AfterData = afterData;
            this.BeforeData = beforeData;
            this.Description = description;
            this.RecordId = recordId;
            this.RecordType = recordType;
        }

        /// <summary>
        /// Timestamp when the change was requested
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("action_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ActionTime { get; set; }

        /// <summary>
        /// User ID of the user who requested the change
        /// </summary>
        [JsonProperty("actioned_by", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ActionedBy { get; set; }

        /// <summary>
        /// Snapshot of what the data would be after the change (empty if the request was to DELETE a record)
        /// </summary>
        [JsonProperty("after_data", NullValueHandling = NullValueHandling.Ignore)]
        public object AfterData { get; set; }

        /// <summary>
        /// Snapshot of the data before the change (empty if the request was to CREATE a new record)
        /// </summary>
        [JsonProperty("before_data", NullValueHandling = NullValueHandling.Ignore)]
        public object BeforeData { get; set; }

        /// <summary>
        /// Textual description of the change being made
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// ID of the resource that is being changed
        /// </summary>
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? RecordId { get; set; }

        /// <summary>
        /// Type of the resource that is being changed
        /// </summary>
        [JsonProperty("record_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes18 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes18 other &&                ((this.ActionTime == null && other.ActionTime == null) || (this.ActionTime?.Equals(other.ActionTime) == true)) &&
                ((this.ActionedBy == null && other.ActionedBy == null) || (this.ActionedBy?.Equals(other.ActionedBy) == true)) &&
                ((this.AfterData == null && other.AfterData == null) || (this.AfterData?.Equals(other.AfterData) == true)) &&
                ((this.BeforeData == null && other.BeforeData == null) || (this.BeforeData?.Equals(other.BeforeData) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.RecordId == null && other.RecordId == null) || (this.RecordId?.Equals(other.RecordId) == true)) &&
                ((this.RecordType == null && other.RecordType == null) || (this.RecordType?.Equals(other.RecordType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ActionTime = {(this.ActionTime == null ? "null" : this.ActionTime.ToString())}");
            toStringOutput.Add($"this.ActionedBy = {(this.ActionedBy == null ? "null" : this.ActionedBy.ToString())}");
            toStringOutput.Add($"AfterData = {(this.AfterData == null ? "null" : this.AfterData.ToString())}");
            toStringOutput.Add($"BeforeData = {(this.BeforeData == null ? "null" : this.BeforeData.ToString())}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.RecordId = {(this.RecordId == null ? "null" : this.RecordId.ToString())}");
            toStringOutput.Add($"this.RecordType = {(this.RecordType == null ? "null" : this.RecordType)}");
        }
    }
}