// <copyright file="SchemeMessageAdmissionRelationships.cs" company="APIMatic">
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
    /// SchemeMessageAdmissionRelationships.
    /// </summary>
    public class SchemeMessageAdmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeMessageAdmissionRelationships"/> class.
        /// </summary>
        public SchemeMessageAdmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeMessageAdmissionRelationships"/> class.
        /// </summary>
        /// <param name="schemeMessage">scheme_message.</param>
        public SchemeMessageAdmissionRelationships(
            Models.SchemeMessage1 schemeMessage = null)
        {
            this.SchemeMessage = schemeMessage;
        }

        /// <summary>
        /// Gets or sets SchemeMessage.
        /// </summary>
        [JsonProperty("scheme_message", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SchemeMessage1 SchemeMessage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SchemeMessageAdmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is SchemeMessageAdmissionRelationships other &&                ((this.SchemeMessage == null && other.SchemeMessage == null) || (this.SchemeMessage?.Equals(other.SchemeMessage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeMessage = {(this.SchemeMessage == null ? "null" : this.SchemeMessage.ToString())}");
        }
    }
}