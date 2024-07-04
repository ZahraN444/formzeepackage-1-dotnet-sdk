// <copyright file="Attributes42.cs" company="APIMatic">
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
    /// Attributes42.
    /// </summary>
    public class Attributes42
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes42"/> class.
        /// </summary>
        public Attributes42()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes42"/> class.
        /// </summary>
        /// <param name="fileFormat">file_format.</param>
        /// <param name="fileHash">file_hash.</param>
        /// <param name="fileSize">file_size.</param>
        /// <param name="hashingAlgorithm">hashing_algorithm.</param>
        /// <param name="numberOfParts">number_of_parts.</param>
        /// <param name="paymentScheme">payment_scheme.</param>
        /// <param name="transactionCount">transaction_count.</param>
        /// <param name="transactionData">transaction_data.</param>
        /// <param name="transactionSum">transaction_sum.</param>
        public Attributes42(
            Models.FileFormatEnum fileFormat,
            string fileHash,
            int fileSize,
            string hashingAlgorithm,
            int numberOfParts,
            string paymentScheme,
            int transactionCount,
            object transactionData = null,
            string transactionSum = null)
        {
            this.FileFormat = fileFormat;
            this.FileHash = fileHash;
            this.FileSize = fileSize;
            this.HashingAlgorithm = hashingAlgorithm;
            this.NumberOfParts = numberOfParts;
            this.PaymentScheme = paymentScheme;
            this.TransactionCount = transactionCount;
            this.TransactionData = transactionData;
            this.TransactionSum = transactionSum;
        }

        /// <summary>
        /// The format of the file that will be submitted/admitted to Form3
        /// </summary>
        [JsonProperty("file_format")]
        public Models.FileFormatEnum FileFormat { get; set; }

        /// <summary>
        /// Hashed content of the file
        /// </summary>
        [JsonProperty("file_hash")]
        public string FileHash { get; set; }

        /// <summary>
        /// The size of the file to be uploaded - number of bytes. Max size is 1.4 Gigabyte
        /// </summary>
        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        /// <summary>
        /// The algorithm used to generate the signature
        /// </summary>
        [JsonProperty("hashing_algorithm")]
        public string HashingAlgorithm { get; set; }

        /// <summary>
        /// The count of chunks to be uploaded to the resource
        /// </summary>
        [JsonProperty("number_of_parts")]
        public int NumberOfParts { get; set; }

        /// <summary>
        /// Scheme/gateway that the file is to be processed by
        /// </summary>
        [JsonProperty("payment_scheme")]
        public string PaymentScheme { get; set; }

        /// <summary>
        /// The count of transactions that will be submitted in the file
        /// </summary>
        [JsonProperty("transaction_count")]
        public int TransactionCount { get; set; }

        /// <summary>
        /// All purpose key-value fields containing file specific data (read only).
        /// </summary>
        [JsonProperty("transaction_data", NullValueHandling = NullValueHandling.Ignore)]
        public object TransactionData { get; set; }

        /// <summary>
        /// The sum value of the transactions will be submitted in the file
        /// </summary>
        [JsonProperty("transaction_sum", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionSum { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes42 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes42 other &&                this.FileFormat.Equals(other.FileFormat) &&
                ((this.FileHash == null && other.FileHash == null) || (this.FileHash?.Equals(other.FileHash) == true)) &&
                this.FileSize.Equals(other.FileSize) &&
                ((this.HashingAlgorithm == null && other.HashingAlgorithm == null) || (this.HashingAlgorithm?.Equals(other.HashingAlgorithm) == true)) &&
                this.NumberOfParts.Equals(other.NumberOfParts) &&
                ((this.PaymentScheme == null && other.PaymentScheme == null) || (this.PaymentScheme?.Equals(other.PaymentScheme) == true)) &&
                this.TransactionCount.Equals(other.TransactionCount) &&
                ((this.TransactionData == null && other.TransactionData == null) || (this.TransactionData?.Equals(other.TransactionData) == true)) &&
                ((this.TransactionSum == null && other.TransactionSum == null) || (this.TransactionSum?.Equals(other.TransactionSum) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FileFormat = {this.FileFormat}");
            toStringOutput.Add($"this.FileHash = {(this.FileHash == null ? "null" : this.FileHash)}");
            toStringOutput.Add($"this.FileSize = {this.FileSize}");
            toStringOutput.Add($"this.HashingAlgorithm = {(this.HashingAlgorithm == null ? "null" : this.HashingAlgorithm)}");
            toStringOutput.Add($"this.NumberOfParts = {this.NumberOfParts}");
            toStringOutput.Add($"this.PaymentScheme = {(this.PaymentScheme == null ? "null" : this.PaymentScheme)}");
            toStringOutput.Add($"this.TransactionCount = {this.TransactionCount}");
            toStringOutput.Add($"TransactionData = {(this.TransactionData == null ? "null" : this.TransactionData.ToString())}");
            toStringOutput.Add($"this.TransactionSum = {(this.TransactionSum == null ? "null" : this.TransactionSum)}");
        }
    }
}