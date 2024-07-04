// <copyright file="Relationships19.cs" company="APIMatic">
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
    /// Relationships19.
    /// </summary>
    public class Relationships19
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships19"/> class.
        /// </summary>
        public Relationships19()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationships19"/> class.
        /// </summary>
        /// <param name="validations">validations.</param>
        public Relationships19(
            Models.RelationshipLinks validations = null)
        {
            this.Validations = validations;
        }

        /// <summary>
        /// Gets or sets Validations.
        /// </summary>
        [JsonProperty("validations", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks Validations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Relationships19 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Relationships19 other &&                ((this.Validations == null && other.Validations == null) || (this.Validations?.Equals(other.Validations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Validations = {(this.Validations == null ? "null" : this.Validations.ToString())}");
        }
    }
}