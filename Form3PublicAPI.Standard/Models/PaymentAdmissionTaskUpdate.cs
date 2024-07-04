// <copyright file="PaymentAdmissionTaskUpdate.cs" company="APIMatic">
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
    /// PaymentAdmissionTaskUpdate.
    /// </summary>
    public class PaymentAdmissionTaskUpdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAdmissionTaskUpdate"/> class.
        /// </summary>
        public PaymentAdmissionTaskUpdate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAdmissionTaskUpdate"/> class.
        /// </summary>
        /// <param name="attributes">attributes.</param>
        /// <param name="id">id.</param>
        /// <param name="organisationId">organisation_id.</param>
        /// <param name="type">type.</param>
        /// <param name="version">version.</param>
        public PaymentAdmissionTaskUpdate(
            Models.Attributes53 attributes = null,
            Guid? id = null,
            Guid? organisationId = null,
            Models.Type9Enum? type = null,
            int? version = null)
        {
            this.Attributes = attributes;
            this.Id = id;
            this.OrganisationId = organisationId;
            this.Type = type;
            this.Version = version;
        }

        /// <summary>
        /// Gets or sets Attributes.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Attributes53 Attributes { get; set; }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Unique ID of the organisation this resource is created by
        /// </summary>
        [JsonProperty("organisation_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganisationId { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type9Enum? Type { get; set; }

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

            return $"PaymentAdmissionTaskUpdate : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentAdmissionTaskUpdate other &&                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.OrganisationId == null && other.OrganisationId == null) || (this.OrganisationId?.Equals(other.OrganisationId) == true)) &&
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
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.OrganisationId = {(this.OrganisationId == null ? "null" : this.OrganisationId.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version.ToString())}");
        }
    }
}