// <copyright file="AccountValidationController.cs" company="APIMatic">
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
    /// AccountValidationController.
    /// </summary>
    public class AccountValidationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountValidationController"/> class.
        /// </summary>
        internal AccountValidationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Fetch sort code details.
        /// </summary>
        /// <param name="sortcode">Required parameter: Sort code.</param>
        /// <returns>Returns the Models.SortCodeDetailsResponse response from the API call.</returns>
        public Models.SortCodeDetailsResponse FetchSortCodeDetails(
                string sortcode)
            => CoreHelper.RunTask(FetchSortCodeDetailsAsync(sortcode));

        /// <summary>
        /// Fetch sort code details.
        /// </summary>
        /// <param name="sortcode">Required parameter: Sort code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SortCodeDetailsResponse response from the API call.</returns>
        public async Task<Models.SortCodeDetailsResponse> FetchSortCodeDetailsAsync(
                string sortcode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SortCodeDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/validations/gbdsc/sortcodes/{sortcode}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("sortcode", sortcode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Validation failed", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Validate sortcode and account number details.
        /// </summary>
        /// <param name="sortcode">Required parameter: Sort code.</param>
        /// <param name="accountnumber">Required parameter: Account number.</param>
        /// <returns>Returns the Models.AccountNumberDetailsResponse response from the API call.</returns>
        public Models.AccountNumberDetailsResponse ValidateSortcodeAndAccountNumberDetails(
                string sortcode,
                string accountnumber)
            => CoreHelper.RunTask(ValidateSortcodeAndAccountNumberDetailsAsync(sortcode, accountnumber));

        /// <summary>
        /// Validate sortcode and account number details.
        /// </summary>
        /// <param name="sortcode">Required parameter: Sort code.</param>
        /// <param name="accountnumber">Required parameter: Account number.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountNumberDetailsResponse response from the API call.</returns>
        public async Task<Models.AccountNumberDetailsResponse> ValidateSortcodeAndAccountNumberDetailsAsync(
                string sortcode,
                string accountnumber,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountNumberDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/validations/gbdsc/sortcodes/{sortcode}/accountnumbers/{accountnumber}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("sortcode", sortcode))
                      .Template(_template => _template.Setup("accountnumber", accountnumber))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Validation error", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Validation failed", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}