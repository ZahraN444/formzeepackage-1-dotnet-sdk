// <copyright file="Attributes33.cs" company="APIMatic">
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
    /// Attributes33.
    /// </summary>
    public class Attributes33
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes33"/> class.
        /// </summary>
        public Attributes33()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes33"/> class.
        /// </summary>
        /// <param name="schemeStatusCode">scheme_status_code.</param>
        /// <param name="schemeStatusCodeDescription">scheme_status_code_description.</param>
        public Attributes33(
            string schemeStatusCode,
            string schemeStatusCodeDescription)
        {
            this.SchemeStatusCode = schemeStatusCode;
            this.SchemeStatusCodeDescription = schemeStatusCodeDescription;
        }

        /// <summary>
        /// Gets or sets SchemeStatusCode.
        /// </summary>
        [JsonProperty("scheme_status_code")]
        public string SchemeStatusCode { get; set; }

        /// <summary>
        /// Gets or sets SchemeStatusCodeDescription.
        /// </summary>
        [JsonProperty("scheme_status_code_description")]
        public string SchemeStatusCodeDescription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes33 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes33 other &&                ((this.SchemeStatusCode == null && other.SchemeStatusCode == null) || (this.SchemeStatusCode?.Equals(other.SchemeStatusCode) == true)) &&
                ((this.SchemeStatusCodeDescription == null && other.SchemeStatusCodeDescription == null) || (this.SchemeStatusCodeDescription?.Equals(other.SchemeStatusCodeDescription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeStatusCode = {(this.SchemeStatusCode == null ? "null" : this.SchemeStatusCode)}");
            toStringOutput.Add($"this.SchemeStatusCodeDescription = {(this.SchemeStatusCodeDescription == null ? "null" : this.SchemeStatusCodeDescription)}");
        }
    }
}