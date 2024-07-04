// <copyright file="PlatformsecurityapiController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Form3PublicAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Form3PublicAPI.Standard;
    using Form3PublicAPI.Standard.Exceptions;
    using Form3PublicAPI.Standard.Http.Client;
    using Form3PublicAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// PlatformsecurityapiController.
    /// </summary>
    public class PlatformsecurityapiController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformsecurityapiController"/> class.
        /// </summary>
        internal PlatformsecurityapiController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Get a list of Signing Keys.
        /// </summary>
        /// <returns>Returns the Models.SigningKeysListResponse response from the API call.</returns>
        public Models.SigningKeysListResponse GetAListOfSigningKeys()
            => CoreHelper.RunTask(GetAListOfSigningKeysAsync());

        /// <summary>
        /// Get a list of Signing Keys.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SigningKeysListResponse response from the API call.</returns>
        public async Task<Models.SigningKeysListResponse> GetAListOfSigningKeysAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SigningKeysListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/platform/security/signing_keys")
                  .WithAuth("OAuth2"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Action Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("502", CreateErrorCase("Bad Gateway", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch a Signing Key.
        /// </summary>
        /// <param name="signingkeyId">Required parameter: Signing Key ID.</param>
        /// <returns>Returns the Models.SigningKeysResponse response from the API call.</returns>
        public Models.SigningKeysResponse FetchASigningKey(
                Guid signingkeyId)
            => CoreHelper.RunTask(FetchASigningKeyAsync(signingkeyId));

        /// <summary>
        /// Fetch a Signing Key.
        /// </summary>
        /// <param name="signingkeyId">Required parameter: Signing Key ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SigningKeysResponse response from the API call.</returns>
        public async Task<Models.SigningKeysResponse> FetchASigningKeyAsync(
                Guid signingkeyId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SigningKeysResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/platform/security/signing_keys/{signingkey_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("signingkey_id", signingkeyId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Action Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("502", CreateErrorCase("Bad Gateway", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected Error", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}