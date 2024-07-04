// <copyright file="Oauth2Controller.cs" company="APIMatic">
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
    /// Oauth2Controller.
    /// </summary>
    public class Oauth2Controller : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Oauth2Controller"/> class.
        /// </summary>
        internal Oauth2Controller(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Request Access Token.
        /// </summary>
        /// <returns>Returns the Models.Token response from the API call.</returns>
        public Models.Token RequestAccessToken()
            => CoreHelper.RunTask(RequestAccessTokenAsync());

        /// <summary>
        /// Request Access Token.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Token response from the API call.</returns>
        public async Task<Models.Token> RequestAccessTokenAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Token>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/oauth2/token")
                  .WithAuth("Basic")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("grant_type", "client_credentials"))
                      .Header(_header => _header.Setup("Content-Type", "application/x-www-form-urlencoded"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("403", CreateErrorCase("Authentication failed", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}