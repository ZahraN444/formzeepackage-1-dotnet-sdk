// <copyright file="Attributes2.cs" company="APIMatic">
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
    /// Attributes2.
    /// </summary>
    public class Attributes2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes2"/> class.
        /// </summary>
        public Attributes2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes2"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="filter">filter.</param>
        /// <param name="recordType">record_type.</param>
        /// <param name="roleId">role_id.</param>
        public Attributes2(
            string action = null,
            string filter = null,
            string recordType = null,
            Guid? roleId = null)
        {
            this.Action = action;
            this.Filter = filter;
            this.RecordType = recordType;
            this.RoleId = roleId;
        }

        /// <summary>
        /// Action that this ACE controls
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets Filter.
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// Type of record that this ACE gives access to
        /// </summary>
        [JsonProperty("record_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordType { get; set; }

        /// <summary>
        /// Role ID of the role that this ACE belongs to
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? RoleId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes2 other &&                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true)) &&
                ((this.Filter == null && other.Filter == null) || (this.Filter?.Equals(other.Filter) == true)) &&
                ((this.RecordType == null && other.RecordType == null) || (this.RecordType?.Equals(other.RecordType) == true)) &&
                ((this.RoleId == null && other.RoleId == null) || (this.RoleId?.Equals(other.RoleId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Action = {(this.Action == null ? "null" : this.Action)}");
            toStringOutput.Add($"this.Filter = {(this.Filter == null ? "null" : this.Filter)}");
            toStringOutput.Add($"this.RecordType = {(this.RecordType == null ? "null" : this.RecordType)}");
            toStringOutput.Add($"this.RoleId = {(this.RoleId == null ? "null" : this.RoleId.ToString())}");
        }
    }
}