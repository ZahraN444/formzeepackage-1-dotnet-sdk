// <copyright file="AccountAttributesOrganisationIdentificationActor.cs" company="APIMatic">
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
    /// AccountAttributesOrganisationIdentificationActor.
    /// </summary>
    public class AccountAttributesOrganisationIdentificationActor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAttributesOrganisationIdentificationActor"/> class.
        /// </summary>
        public AccountAttributesOrganisationIdentificationActor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAttributesOrganisationIdentificationActor"/> class.
        /// </summary>
        /// <param name="birthDate">birth_date.</param>
        /// <param name="name">name.</param>
        /// <param name="residency">residency.</param>
        /// <param name="role">role.</param>
        public AccountAttributesOrganisationIdentificationActor(
            DateTime? birthDate = null,
            List<string> name = null,
            string residency = null,
            string role = null)
        {
            this.BirthDate = birthDate;
            this.Name = name;
            this.Residency = residency;
            this.Role = role;
        }

        /// <summary>
        /// Gets or sets BirthDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Actor names (for example title, first name, last name). Used for Confirmation of Payee matching.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// ISO 3166-1 code used to identify the domicile of the actor
        /// </summary>
        [JsonProperty("residency", NullValueHandling = NullValueHandling.Ignore)]
        public string Residency { get; set; }

        /// <summary>
        /// Gets or sets Role.
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountAttributesOrganisationIdentificationActor : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountAttributesOrganisationIdentificationActor other &&                ((this.BirthDate == null && other.BirthDate == null) || (this.BirthDate?.Equals(other.BirthDate) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Residency == null && other.Residency == null) || (this.Residency?.Equals(other.Residency) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BirthDate = {(this.BirthDate == null ? "null" : this.BirthDate.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : $"[{string.Join(", ", this.Name)} ]")}");
            toStringOutput.Add($"this.Residency = {(this.Residency == null ? "null" : this.Residency)}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role)}");
        }
    }
}