// <copyright file="AccountIdentificationEventRelationships.cs" company="APIMatic">
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
    /// AccountIdentificationEventRelationships.
    /// </summary>
    public class AccountIdentificationEventRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIdentificationEventRelationships"/> class.
        /// </summary>
        public AccountIdentificationEventRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIdentificationEventRelationships"/> class.
        /// </summary>
        /// <param name="account">account.</param>
        public AccountIdentificationEventRelationships(
            Models.RelationshipAccount account = null)
        {
            this.Account = account;
        }

        /// <summary>
        /// Gets or sets Account.
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipAccount Account { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountIdentificationEventRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountIdentificationEventRelationships other &&                ((this.Account == null && other.Account == null) || (this.Account?.Equals(other.Account) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Account = {(this.Account == null ? "null" : this.Account.ToString())}");
        }
    }
}