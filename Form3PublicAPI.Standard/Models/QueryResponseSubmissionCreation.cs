// <copyright file="QueryResponseSubmissionCreation.cs" company="APIMatic">
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
    /// QueryResponseSubmissionCreation.
    /// </summary>
    public class QueryResponseSubmissionCreation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseSubmissionCreation"/> class.
        /// </summary>
        public QueryResponseSubmissionCreation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResponseSubmissionCreation"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public QueryResponseSubmissionCreation(
            Models.NewQueryResponseSubmission data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public Models.NewQueryResponseSubmission Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryResponseSubmissionCreation : ({string.Join(", ", toStringOutput)})";
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
            return obj is QueryResponseSubmissionCreation other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}