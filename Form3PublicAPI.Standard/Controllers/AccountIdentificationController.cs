// <copyright file="AccountIdentificationController.cs" company="APIMatic">
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
    /// AccountIdentificationController.
    /// </summary>
    public class AccountIdentificationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIdentificationController"/> class.
        /// </summary>
        internal AccountIdentificationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List Account Identifications by Account.
        /// </summary>
        /// <param name="accountId">Required parameter: Account Id to which this identification relates to.</param>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterSecondaryIdentification">Optional parameter: Filter to only include account identifications with specified secondary_identification.</param>
        /// <returns>Returns the Models.AccountIdentificationListResponse response from the API call.</returns>
        public Models.AccountIdentificationListResponse ListAccountIdentificationsByAccount(
                Guid accountId,
                string pageNumber = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                List<string> filterSecondaryIdentification = null)
            => CoreHelper.RunTask(ListAccountIdentificationsByAccountAsync(accountId, pageNumber, pageSize, filterOrganisationId, filterSecondaryIdentification));

        /// <summary>
        /// List Account Identifications by Account.
        /// </summary>
        /// <param name="accountId">Required parameter: Account Id to which this identification relates to.</param>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterOrganisationId">Optional parameter: Filter by organisation id.</param>
        /// <param name="filterSecondaryIdentification">Optional parameter: Filter to only include account identifications with specified secondary_identification.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountIdentificationListResponse response from the API call.</returns>
        public async Task<Models.AccountIdentificationListResponse> ListAccountIdentificationsByAccountAsync(
                Guid accountId,
                string pageNumber = null,
                int? pageSize = null,
                List<Guid> filterOrganisationId = null,
                List<string> filterSecondaryIdentification = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountIdentificationListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/accounts/{account_id}/identifications")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account_id", accountId))
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[secondary_identification]", filterSecondaryIdentification))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create an identification for an existing Account.
        /// </summary>
        /// <param name="accountId">Required parameter: Account Id to which this identification relates to.</param>
        /// <param name="accountIdentificationCreationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.AccountIdentificationResponse response from the API call.</returns>
        public Models.AccountIdentificationResponse CreateAnIdentificationForAnExistingAccount(
                Guid accountId,
                Models.AccountIdentificationRequest accountIdentificationCreationRequest = null)
            => CoreHelper.RunTask(CreateAnIdentificationForAnExistingAccountAsync(accountId, accountIdentificationCreationRequest));

        /// <summary>
        /// Create an identification for an existing Account.
        /// </summary>
        /// <param name="accountId">Required parameter: Account Id to which this identification relates to.</param>
        /// <param name="accountIdentificationCreationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountIdentificationResponse response from the API call.</returns>
        public async Task<Models.AccountIdentificationResponse> CreateAnIdentificationForAnExistingAccountAsync(
                Guid accountId,
                Models.AccountIdentificationRequest accountIdentificationCreationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountIdentificationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/organisation/accounts/{account_id}/identifications")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(accountIdentificationCreationRequest))
                      .Template(_template => _template.Setup("account_id", accountId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("409", CreateErrorCase("Account Identification creation error, constraint violation of secondary identification", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete account identification.
        /// </summary>
        /// <param name="accountId">Required parameter: Account Id.</param>
        /// <param name="identificationId">Required parameter: Account Identification Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        public void DeleteAccountIdentification(
                Guid accountId,
                Guid identificationId,
                int version)
            => CoreHelper.RunVoidTask(DeleteAccountIdentificationAsync(accountId, identificationId, version));

        /// <summary>
        /// Delete account identification.
        /// </summary>
        /// <param name="accountId">Required parameter: Account Id.</param>
        /// <param name="identificationId">Required parameter: Account Identification Id.</param>
        /// <param name="version">Required parameter: Version.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteAccountIdentificationAsync(
                Guid accountId,
                Guid identificationId,
                int version,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/organisation/accounts/{account_id}/identifications/{identification_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account_id", accountId))
                      .Template(_template => _template.Setup("identification_id", identificationId))
                      .Query(_query => _query.Setup("version", version))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Account Identification not found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get an account identification by id.
        /// </summary>
        /// <param name="accountId">Required parameter: Account Id.</param>
        /// <param name="identificationId">Required parameter: Account Identification Id.</param>
        /// <returns>Returns the Models.AccountIdentificationResponse response from the API call.</returns>
        public Models.AccountIdentificationResponse GetAnAccountIdentificationById(
                Guid accountId,
                Guid identificationId)
            => CoreHelper.RunTask(GetAnAccountIdentificationByIdAsync(accountId, identificationId));

        /// <summary>
        /// Get an account identification by id.
        /// </summary>
        /// <param name="accountId">Required parameter: Account Id.</param>
        /// <param name="identificationId">Required parameter: Account Identification Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountIdentificationResponse response from the API call.</returns>
        public async Task<Models.AccountIdentificationResponse> GetAnAccountIdentificationByIdAsync(
                Guid accountId,
                Guid identificationId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountIdentificationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/organisation/accounts/{account_id}/identifications/{identification_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account_id", accountId))
                      .Template(_template => _template.Setup("identification_id", identificationId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Amend Account Identification.
        /// </summary>
        /// <param name="accountId">Required parameter: Account Id.</param>
        /// <param name="identificationId">Required parameter: Account Identification Id; Must match id in the payload.</param>
        /// <param name="accountIdentificationAmendRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.AccountIdentificationResponse response from the API call.</returns>
        public Models.AccountIdentificationResponse AmendAccountIdentification(
                Guid accountId,
                Guid identificationId,
                Models.AccountIdentificationRequest accountIdentificationAmendRequest = null)
            => CoreHelper.RunTask(AmendAccountIdentificationAsync(accountId, identificationId, accountIdentificationAmendRequest));

        /// <summary>
        /// Amend Account Identification.
        /// </summary>
        /// <param name="accountId">Required parameter: Account Id.</param>
        /// <param name="identificationId">Required parameter: Account Identification Id; Must match id in the payload.</param>
        /// <param name="accountIdentificationAmendRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountIdentificationResponse response from the API call.</returns>
        public async Task<Models.AccountIdentificationResponse> AmendAccountIdentificationAsync(
                Guid accountId,
                Guid identificationId,
                Models.AccountIdentificationRequest accountIdentificationAmendRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountIdentificationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/organisation/accounts/{account_id}/identifications/{identification_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(accountIdentificationAmendRequest))
                      .Template(_template => _template.Setup("account_id", accountId))
                      .Template(_template => _template.Setup("identification_id", identificationId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("409", CreateErrorCase("Account Identification update error, constraint violation of secondary identification", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}