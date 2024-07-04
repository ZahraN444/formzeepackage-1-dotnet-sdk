// <copyright file="Attributes39.cs" company="APIMatic">
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
    /// Attributes39.
    /// </summary>
    public class Attributes39
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes39"/> class.
        /// </summary>
        public Attributes39()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes39"/> class.
        /// </summary>
        /// <param name="fileFormat">file_format.</param>
        /// <param name="fileHash">file_hash.</param>
        /// <param name="fileSize">file_size.</param>
        /// <param name="fileType">file_type.</param>
        /// <param name="hashingAlgorithm">hashing_algorithm.</param>
        /// <param name="numberOfParts">number_of_parts.</param>
        /// <param name="paymentScheme">payment_scheme.</param>
        public Attributes39(
            string fileFormat,
            string fileHash,
            int fileSize,
            Models.FileTypeEnum fileType,
            string hashingAlgorithm,
            int numberOfParts,
            Models.PaymentScheme2Enum paymentScheme)
        {
            this.FileFormat = fileFormat;
            this.FileHash = fileHash;
            this.FileSize = fileSize;
            this.FileType = fileType;
            this.HashingAlgorithm = hashingAlgorithm;
            this.NumberOfParts = numberOfParts;
            this.PaymentScheme = paymentScheme;
        }

        /// <summary>
        /// The format of the file that will be submitted to Form3
        /// </summary>
        [JsonProperty("file_format")]
        public string FileFormat { get; set; }

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
        /// The file type
        /// </summary>
        [JsonProperty("file_type")]
        public Models.FileTypeEnum FileType { get; set; }

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
        public Models.PaymentScheme2Enum PaymentScheme { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attributes39 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attributes39 other &&                ((this.FileFormat == null && other.FileFormat == null) || (this.FileFormat?.Equals(other.FileFormat) == true)) &&
                ((this.FileHash == null && other.FileHash == null) || (this.FileHash?.Equals(other.FileHash) == true)) &&
                this.FileSize.Equals(other.FileSize) &&
                this.FileType.Equals(other.FileType) &&
                ((this.HashingAlgorithm == null && other.HashingAlgorithm == null) || (this.HashingAlgorithm?.Equals(other.HashingAlgorithm) == true)) &&
                this.NumberOfParts.Equals(other.NumberOfParts) &&
                this.PaymentScheme.Equals(other.PaymentScheme);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FileFormat = {(this.FileFormat == null ? "null" : this.FileFormat)}");
            toStringOutput.Add($"this.FileHash = {(this.FileHash == null ? "null" : this.FileHash)}");
            toStringOutput.Add($"this.FileSize = {this.FileSize}");
            toStringOutput.Add($"this.FileType = {this.FileType}");
            toStringOutput.Add($"this.HashingAlgorithm = {(this.HashingAlgorithm == null ? "null" : this.HashingAlgorithm)}");
            toStringOutput.Add($"this.NumberOfParts = {this.NumberOfParts}");
            toStringOutput.Add($"this.PaymentScheme = {this.PaymentScheme}");
        }
    }
}