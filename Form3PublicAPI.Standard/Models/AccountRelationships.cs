// <copyright file="AccountRelationships.cs" company="APIMatic">
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
    /// AccountRelationships.
    /// </summary>
    public class AccountRelationships
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRelationships"/> class.
        /// </summary>
        public AccountRelationships()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRelationships"/> class.
        /// </summary>
        /// <param name="accountEvents">account_events.</param>
        /// <param name="masterAccount">master_account.</param>
        public AccountRelationships(
            Models.RelationshipLinks accountEvents = null,
            Models.RelationshipLinks masterAccount = null)
        {
            this.AccountEvents = accountEvents;
            this.MasterAccount = masterAccount;
        }

        /// <summary>
        /// Gets or sets AccountEvents.
        /// </summary>
        [JsonProperty("account_events", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks AccountEvents { get; set; }

        /// <summary>
        /// Gets or sets MasterAccount.
        /// </summary>
        [JsonProperty("master_account", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RelationshipLinks MasterAccount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountRelationships : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountRelationships other &&                ((this.AccountEvents == null && other.AccountEvents == null) || (this.AccountEvents?.Equals(other.AccountEvents) == true)) &&
                ((this.MasterAccount == null && other.MasterAccount == null) || (this.MasterAccount?.Equals(other.MasterAccount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountEvents = {(this.AccountEvents == null ? "null" : this.AccountEvents.ToString())}");
            toStringOutput.Add($"this.MasterAccount = {(this.MasterAccount == null ? "null" : this.MasterAccount.ToString())}");
        }
    }
}