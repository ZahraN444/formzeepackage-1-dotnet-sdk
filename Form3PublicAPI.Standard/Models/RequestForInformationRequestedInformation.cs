// <copyright file="RequestForInformationRequestedInformation.cs" company="APIMatic">
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
    /// RequestForInformationRequestedInformation.
    /// </summary>
    public class RequestForInformationRequestedInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestForInformationRequestedInformation"/> class.
        /// </summary>
        public RequestForInformationRequestedInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestForInformationRequestedInformation"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="type">type.</param>
        /// <param name="additionalInformation">additional_information.</param>
        public RequestForInformationRequestedInformation(
            string code,
            Models.Type6Enum type,
            string additionalInformation = null)
        {
            this.AdditionalInformation = additionalInformation;
            this.Code = code;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets AdditionalInformation.
        /// </summary>
        [JsonProperty("additional_information", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public Models.Type6Enum Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RequestForInformationRequestedInformation : ({string.Join(", ", toStringOutput)})";
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
            return obj is RequestForInformationRequestedInformation other &&                ((this.AdditionalInformation == null && other.AdditionalInformation == null) || (this.AdditionalInformation?.Equals(other.AdditionalInformation) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                this.Type.Equals(other.Type);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AdditionalInformation = {(this.AdditionalInformation == null ? "null" : this.AdditionalInformation)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.Type = {this.Type}");
        }
    }
}