// <copyright file="SchemeFileSubmissionRelationships.cs" company="APIMatic">
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
    /// SchemeFileSubmissionRelationships.
    /// </summary>
    public class SchemeFileSubmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeFileSubmissionRelationships"/> class.
        /// </summary>
        public SchemeFileSubmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeFileSubmissionRelationships"/> class.
        /// </summary>
        /// <param name="schemeFile">scheme_file.</param>
        public SchemeFileSubmissionRelationships(
            Models.SchemeFile1 schemeFile = null)
        {
            this.SchemeFile = schemeFile;
        }

        /// <summary>
        /// Gets or sets SchemeFile.
        /// </summary>
        [JsonProperty("scheme_file", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SchemeFile1 SchemeFile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SchemeFileSubmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is SchemeFileSubmissionRelationships other &&                ((this.SchemeFile == null && other.SchemeFile == null) || (this.SchemeFile?.Equals(other.SchemeFile) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeFile = {(this.SchemeFile == null ? "null" : this.SchemeFile.ToString())}");
        }
    }
}