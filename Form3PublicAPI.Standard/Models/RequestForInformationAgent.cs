// <copyright file="RequestForInformationAgent.cs" company="APIMatic">
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
    /// RequestForInformationAgent.
    /// </summary>
    public class RequestForInformationAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestForInformationAgent"/> class.
        /// </summary>
        public RequestForInformationAgent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestForInformationAgent"/> class.
        /// </summary>
        /// <param name="identification">identification.</param>
        /// <param name="role">role.</param>
        public RequestForInformationAgent(
            Models.Identification1 identification = null,
            string role = null)
        {
            this.Identification = identification;
            this.Role = role;
        }

        /// <summary>
        /// Gets or sets Identification.
        /// </summary>
        [JsonProperty("identification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Identification1 Identification { get; set; }

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

            return $"RequestForInformationAgent : ({string.Join(", ", toStringOutput)})";
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
            return obj is RequestForInformationAgent other &&                ((this.Identification == null && other.Identification == null) || (this.Identification?.Equals(other.Identification) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Identification = {(this.Identification == null ? "null" : this.Identification.ToString())}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role)}");
        }
    }
}