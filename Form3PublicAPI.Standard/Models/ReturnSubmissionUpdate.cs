// <copyright file="ReturnSubmissionUpdate.cs" company="APIMatic">
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
    /// ReturnSubmissionUpdate.
    /// </summary>
    public class ReturnSubmissionUpdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnSubmissionUpdate"/> class.
        /// </summary>
        public ReturnSubmissionUpdate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnSubmissionUpdate"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="organisationId">organisation_id.</param>
        /// <param name="version">version.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="relationships">relationships.</param>
        /// <param name="type">type.</param>
        public ReturnSubmissionUpdate(
            Guid id,
            Guid organisationId,
            int version,
            Models.Attributes65 attributes = null,
            Models.ReturnSubmissionUpdateRelationships relationships = null,
            string type = null)
        {
            this.Attributes = attributes;
            this.Id = id;
            this.OrganisationId = organisationId;
            this.Relationships = relationships;
            this.Type = type;
            this.Version = version;
        }

        /// <summary>
        /// Gets or sets Attributes.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Attributes65 Attributes { get; set; }

        /// <summary>
        /// Unique resource ID
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Unique ID of the organisation this resource is created by
        /// </summary>
        [JsonProperty("organisation_id")]
        public Guid OrganisationId { get; set; }

        /// <summary>
        /// Gets or sets Relationships.
        /// </summary>
        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReturnSubmissionUpdateRelationships Relationships { get; set; }

        /// <summary>
        /// Name of the resource type
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Version number
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReturnSubmissionUpdate : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReturnSubmissionUpdate other &&                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                this.Id.Equals(other.Id) &&
                this.OrganisationId.Equals(other.OrganisationId) &&
                ((this.Relationships == null && other.Relationships == null) || (this.Relationships?.Equals(other.Relationships) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                this.Version.Equals(other.Version);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.OrganisationId = {this.OrganisationId}");
            toStringOutput.Add($"this.Relationships = {(this.Relationships == null ? "null" : this.Relationships.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Version = {this.Version}");
        }
    }
}