// <copyright file="SchemeMessageAdmission.cs" company="APIMatic">
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
    /// SchemeMessageAdmission.
    /// </summary>
    public class SchemeMessageAdmission
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeMessageAdmission"/> class.
        /// </summary>
        public SchemeMessageAdmission()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeMessageAdmission"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="organisationId">organisation_id.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="relationships">relationships.</param>
        /// <param name="type">type.</param>
        /// <param name="version">version.</param>
        public SchemeMessageAdmission(
            Guid id,
            Guid organisationId,
            Models.SchemeMessageAdmissionAttributes attributes = null,
            Models.SchemeMessageAdmissionRelationships relationships = null,
            Models.Type15Enum? type = null,
            int? version = null)
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
        public Models.SchemeMessageAdmissionAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets OrganisationId.
        /// </summary>
        [JsonProperty("organisation_id")]
        public Guid OrganisationId { get; set; }

        /// <summary>
        /// Gets or sets Relationships.
        /// </summary>
        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SchemeMessageAdmissionRelationships Relationships { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type15Enum? Type { get; set; }

        /// <summary>
        /// Gets or sets Version.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SchemeMessageAdmission : ({string.Join(", ", toStringOutput)})";
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
            return obj is SchemeMessageAdmission other &&                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                this.Id.Equals(other.Id) &&
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
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.OrganisationId = {this.OrganisationId}");
            toStringOutput.Add($"this.Relationships = {(this.Relationships == null ? "null" : this.Relationships.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version.ToString())}");
        }
    }
}