// <copyright file="SchemeFileAdmissionRelationships.cs" company="APIMatic">
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
    /// SchemeFileAdmissionRelationships.
    /// </summary>
    public class SchemeFileAdmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeFileAdmissionRelationships"/> class.
        /// </summary>
        public SchemeFileAdmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeFileAdmissionRelationships"/> class.
        /// </summary>
        /// <param name="schemeFiles">scheme_files.</param>
        public SchemeFileAdmissionRelationships(
            Models.SchemeFiles schemeFiles = null)
        {
            this.SchemeFiles = schemeFiles;
        }

        /// <summary>
        /// Gets or sets SchemeFiles.
        /// </summary>
        [JsonProperty("scheme_files", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SchemeFiles SchemeFiles { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SchemeFileAdmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is SchemeFileAdmissionRelationships other &&                ((this.SchemeFiles == null && other.SchemeFiles == null) || (this.SchemeFiles?.Equals(other.SchemeFiles) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SchemeFiles = {(this.SchemeFiles == null ? "null" : this.SchemeFiles.ToString())}");
        }
    }
}