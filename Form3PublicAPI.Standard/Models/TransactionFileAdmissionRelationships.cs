// <copyright file="TransactionFileAdmissionRelationships.cs" company="APIMatic">
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
    /// TransactionFileAdmissionRelationships.
    /// </summary>
    public class TransactionFileAdmissionRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFileAdmissionRelationships"/> class.
        /// </summary>
        public TransactionFileAdmissionRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFileAdmissionRelationships"/> class.
        /// </summary>
        /// <param name="transactionFiles">transaction_files.</param>
        public TransactionFileAdmissionRelationships(
            Models.TransactionFiles transactionFiles = null)
        {
            this.TransactionFiles = transactionFiles;
        }

        /// <summary>
        /// Gets or sets TransactionFiles.
        /// </summary>
        [JsonProperty("transaction_files", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TransactionFiles TransactionFiles { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TransactionFileAdmissionRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is TransactionFileAdmissionRelationships other &&                ((this.TransactionFiles == null && other.TransactionFiles == null) || (this.TransactionFiles?.Equals(other.TransactionFiles) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TransactionFiles = {(this.TransactionFiles == null ? "null" : this.TransactionFiles.ToString())}");
        }
    }
}