// <copyright file="RequestForInformationReference.cs" company="APIMatic">
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
    /// RequestForInformationReference.
    /// </summary>
    public class RequestForInformationReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestForInformationReference"/> class.
        /// </summary>
        public RequestForInformationReference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestForInformationReference"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="mValue">value.</param>
        public RequestForInformationReference(
            string type,
            string mValue)
        {
            this.Type = type;
            this.MValue = mValue;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RequestForInformationReference : ({string.Join(", ", toStringOutput)})";
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
            return obj is RequestForInformationReference other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
        }
    }
}