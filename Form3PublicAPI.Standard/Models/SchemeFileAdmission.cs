// <copyright file="SchemeFileAdmission.cs" company="APIMatic">
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
    /// SchemeFileAdmission.
    /// </summary>
    public class SchemeFileAdmission
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeFileAdmission"/> class.
        /// </summary>
        public SchemeFileAdmission()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeFileAdmission"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="organisationId">organisation_id.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="createdOn">created_on.</param>
        /// <param name="modifiedOn">modified_on.</param>
        /// <param name="relationships">relationships.</param>
        /// <param name="type">type.</param>
        /// <param name="version">version.</param>
        public SchemeFileAdmission(
            Guid id,
            Guid organisationId,
            Models.Attributes40 attributes = null,
            DateTime? createdOn = null,
            DateTime? modifiedOn = null,
            Models.SchemeFileAdmissionRelationships relationships = null,
            Models.TypeEnum? type = null,
            int? version = null)
        {
            this.Attributes = attributes;
            this.CreatedOn = createdOn;
            this.Id = id;
            this.ModifiedOn = modifiedOn;
            this.OrganisationId = organisationId;
            this.Relationships = relationships;
            this.Type = type;
            this.Version = version;
        }

        /// <summary>
        /// Gets or sets Attributes.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Attributes40 Attributes { get; set; }

        /// <summary>
        /// Gets or sets CreatedOn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets ModifiedOn.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("modified_on", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ModifiedOn { get; set; }

        /// <summary>
        /// Unique ID of the organisation this resource is created by
        /// </summary>
        [JsonProperty("organisation_id")]
        public Guid OrganisationId { get; set; }

        /// <summary>
        /// Gets or sets Relationships.
        /// </summary>
        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SchemeFileAdmissionRelationships Relationships { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TypeEnum? Type { get; set; }

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

            return $"SchemeFileAdmission : ({string.Join(", ", toStringOutput)})";
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
            return obj is SchemeFileAdmission other &&                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                ((this.CreatedOn == null && other.CreatedOn == null) || (this.CreatedOn?.Equals(other.CreatedOn) == true)) &&
                this.Id.Equals(other.Id) &&
                ((this.ModifiedOn == null && other.ModifiedOn == null) || (this.ModifiedOn?.Equals(other.ModifiedOn) == true)) &&
                this.OrganisationId.Equals(other.OrganisationId) &&
                ((this.Relationships == null && other.Relationships == null) || (this.Relationships?.Equals(other.Relationships) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : this.Attributes.ToString())}");
            toStringOutput.Add($"this.CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.ModifiedOn = {(this.ModifiedOn == null ? "null" : this.ModifiedOn.ToString())}");
            toStringOutput.Add($"this.OrganisationId = {this.OrganisationId}");
            toStringOutput.Add($"this.Relationships = {(this.Relationships == null ? "null" : this.Relationships.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version.ToString())}");
        }
    }
}