// <copyright file="SchemeMessagesController.cs" company="APIMatic">
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
    /// SchemeMessagesController.
    /// </summary>
    public class SchemeMessagesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeMessagesController"/> class.
        /// </summary>
        internal SchemeMessagesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// List messages.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterUniqueSchemeId">Optional parameter: Filter by Unique SchemeId.</param>
        /// <param name="filterSchemeMessageType">Optional parameter: Filter by Scheme Message Type.</param>
        /// <param name="filterPaymentScheme">Optional parameter: Filter by Payment Scheme.</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Filter by Admission DateTime.</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Filter by Admission DateTime.</param>
        /// <returns>Returns the Models.SchemeMessageDetailsListResponse response from the API call.</returns>
        public Models.SchemeMessageDetailsListResponse ListMessages(
                string pageNumber = null,
                int? pageSize = 100,
                string filterUniqueSchemeId = null,
                string filterSchemeMessageType = null,
                string filterPaymentScheme = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null)
            => CoreHelper.RunTask(ListMessagesAsync(pageNumber, pageSize, filterUniqueSchemeId, filterSchemeMessageType, filterPaymentScheme, filterAdmissionAdmissionDateFrom, filterAdmissionAdmissionDateTo));

        /// <summary>
        /// List messages.
        /// </summary>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="filterUniqueSchemeId">Optional parameter: Filter by Unique SchemeId.</param>
        /// <param name="filterSchemeMessageType">Optional parameter: Filter by Scheme Message Type.</param>
        /// <param name="filterPaymentScheme">Optional parameter: Filter by Payment Scheme.</param>
        /// <param name="filterAdmissionAdmissionDateFrom">Optional parameter: Filter by Admission DateTime.</param>
        /// <param name="filterAdmissionAdmissionDateTo">Optional parameter: Filter by Admission DateTime.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SchemeMessageDetailsListResponse response from the API call.</returns>
        public async Task<Models.SchemeMessageDetailsListResponse> ListMessagesAsync(
                string pageNumber = null,
                int? pageSize = 100,
                string filterUniqueSchemeId = null,
                string filterSchemeMessageType = null,
                string filterPaymentScheme = null,
                DateTime? filterAdmissionAdmissionDateFrom = null,
                DateTime? filterAdmissionAdmissionDateTo = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SchemeMessageDetailsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/notification/schememessages")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", (pageSize != null) ? pageSize : 100))
                      .Query(_query => _query.Setup("filter[unique_scheme_id]", filterUniqueSchemeId))
                      .Query(_query => _query.Setup("filter[scheme_message_type]", filterSchemeMessageType))
                      .Query(_query => _query.Setup("filter[payment_scheme]", filterPaymentScheme))
                      .Query(_query => _query.Setup("filter[admission.admission_date_from]", filterAdmissionAdmissionDateFrom.HasValue ? filterAdmissionAdmissionDateFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[admission.admission_date_to]", filterAdmissionAdmissionDateTo.HasValue ? filterAdmissionAdmissionDateTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch message.
        /// </summary>
        /// <param name="id">Required parameter: Scheme Message Id.</param>
        /// <returns>Returns the Models.SchemeMessageDetailsResponse response from the API call.</returns>
        public Models.SchemeMessageDetailsResponse FetchMessage(
                Guid id)
            => CoreHelper.RunTask(FetchMessageAsync(id));

        /// <summary>
        /// Fetch message.
        /// </summary>
        /// <param name="id">Required parameter: Scheme Message Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SchemeMessageDetailsResponse response from the API call.</returns>
        public async Task<Models.SchemeMessageDetailsResponse> FetchMessageAsync(
                Guid id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SchemeMessageDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/notification/schememessages/{id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Scheme Message Not found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get Scheme Message Admission By AdmissionId.
        /// </summary>
        /// <param name="id">Required parameter: Scheme Message Id.</param>
        /// <param name="admissionId">Required parameter: Scheme Message Admission Id.</param>
        /// <returns>Returns the Models.SchemeMessageAdmissionDetailsResponse response from the API call.</returns>
        public Models.SchemeMessageAdmissionDetailsResponse GetSchemeMessageAdmissionByAdmissionId(
                Guid id,
                Guid admissionId)
            => CoreHelper.RunTask(GetSchemeMessageAdmissionByAdmissionIdAsync(id, admissionId));

        /// <summary>
        /// Get Scheme Message Admission By AdmissionId.
        /// </summary>
        /// <param name="id">Required parameter: Scheme Message Id.</param>
        /// <param name="admissionId">Required parameter: Scheme Message Admission Id.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SchemeMessageAdmissionDetailsResponse response from the API call.</returns>
        public async Task<Models.SchemeMessageAdmissionDetailsResponse> GetSchemeMessageAdmissionByAdmissionIdAsync(
                Guid id,
                Guid admissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SchemeMessageAdmissionDetailsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/notification/schememessages/{id}/admissions/{admissionId}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("admissionId", admissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Scheme Message Admission by Id bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Scheme Message Not found", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}