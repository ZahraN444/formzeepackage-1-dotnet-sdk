// <copyright file="QueryApiController.cs" company="APIMatic">
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
    /// QueryApiController.
    /// </summary>
    public class QueryApiController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryApiController"/> class.
        /// </summary>
        internal QueryApiController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Get Query.
        /// </summary>
        /// <param name="filterOrganisationId">Optional parameter: The organisations to filter on.</param>
        /// <param name="filterStatus">Optional parameter: Find all queries for a given status.</param>
        /// <param name="filterQueryType">Optional parameter: Find all queries for a given query type.</param>
        /// <param name="filterAutoHandled">Optional parameter: Find all queries for given auto handled flag.</param>
        /// <param name="filterProcessingDateFrom">Optional parameter: Find all queries from a certain value date..</param>
        /// <param name="filterProcessingDateTo">Optional parameter: Find all queries up to a certain value date..</param>
        /// <param name="filterCreatedOnFrom">Optional parameter: Find all queries from a certain created date..</param>
        /// <param name="filterCreatedOnTo">Optional parameter: Find all queries up to a certain created date..</param>
        /// <param name="filterPaymentId">Optional parameter: Find all queries with a certain payment id..</param>
        /// <param name="filterPaymentAdmissionId">Optional parameter: Find all queries with a certain payment admission id..</param>
        /// <param name="filterPaymentSubmissionId">Optional parameter: Find all queries with a certain payment submission id..</param>
        /// <param name="filterRecallId">Optional parameter: Find all queries with a certain recall id..</param>
        /// <param name="filterRecallSubmissionId">Optional parameter: Find all queries with a certain recall submission id..</param>
        /// <param name="filterQueryId">Optional parameter: Find all queries with a certain query id..</param>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <returns>Returns the Models.QueryListResponse response from the API call.</returns>
        public Models.QueryListResponse ListQueries(
                List<Guid> filterOrganisationId = null,
                Models.ReportRequestStatusEnum? filterStatus = null,
                string filterQueryType = null,
                bool? filterAutoHandled = null,
                DateTime? filterProcessingDateFrom = null,
                DateTime? filterProcessingDateTo = null,
                DateTime? filterCreatedOnFrom = null,
                DateTime? filterCreatedOnTo = null,
                Guid? filterPaymentId = null,
                Guid? filterPaymentAdmissionId = null,
                Guid? filterPaymentSubmissionId = null,
                Guid? filterRecallId = null,
                Guid? filterRecallSubmissionId = null,
                Guid? filterQueryId = null,
                string pageNumber = null,
                int? pageSize = null)
            => CoreHelper.RunTask(ListQueriesAsync(filterOrganisationId, filterStatus, filterQueryType, filterAutoHandled, filterProcessingDateFrom, filterProcessingDateTo, filterCreatedOnFrom, filterCreatedOnTo, filterPaymentId, filterPaymentAdmissionId, filterPaymentSubmissionId, filterRecallId, filterRecallSubmissionId, filterQueryId, pageNumber, pageSize));

        /// <summary>
        /// Get Query.
        /// </summary>
        /// <param name="filterOrganisationId">Optional parameter: The organisations to filter on.</param>
        /// <param name="filterStatus">Optional parameter: Find all queries for a given status.</param>
        /// <param name="filterQueryType">Optional parameter: Find all queries for a given query type.</param>
        /// <param name="filterAutoHandled">Optional parameter: Find all queries for given auto handled flag.</param>
        /// <param name="filterProcessingDateFrom">Optional parameter: Find all queries from a certain value date..</param>
        /// <param name="filterProcessingDateTo">Optional parameter: Find all queries up to a certain value date..</param>
        /// <param name="filterCreatedOnFrom">Optional parameter: Find all queries from a certain created date..</param>
        /// <param name="filterCreatedOnTo">Optional parameter: Find all queries up to a certain created date..</param>
        /// <param name="filterPaymentId">Optional parameter: Find all queries with a certain payment id..</param>
        /// <param name="filterPaymentAdmissionId">Optional parameter: Find all queries with a certain payment admission id..</param>
        /// <param name="filterPaymentSubmissionId">Optional parameter: Find all queries with a certain payment submission id..</param>
        /// <param name="filterRecallId">Optional parameter: Find all queries with a certain recall id..</param>
        /// <param name="filterRecallSubmissionId">Optional parameter: Find all queries with a certain recall submission id..</param>
        /// <param name="filterQueryId">Optional parameter: Find all queries with a certain query id..</param>
        /// <param name="pageNumber">Optional parameter: Which page to select.</param>
        /// <param name="pageSize">Optional parameter: Number of items to select.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QueryListResponse response from the API call.</returns>
        public async Task<Models.QueryListResponse> ListQueriesAsync(
                List<Guid> filterOrganisationId = null,
                Models.ReportRequestStatusEnum? filterStatus = null,
                string filterQueryType = null,
                bool? filterAutoHandled = null,
                DateTime? filterProcessingDateFrom = null,
                DateTime? filterProcessingDateTo = null,
                DateTime? filterCreatedOnFrom = null,
                DateTime? filterCreatedOnTo = null,
                Guid? filterPaymentId = null,
                Guid? filterPaymentAdmissionId = null,
                Guid? filterPaymentSubmissionId = null,
                Guid? filterRecallId = null,
                Guid? filterRecallSubmissionId = null,
                Guid? filterQueryId = null,
                string pageNumber = null,
                int? pageSize = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QueryListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/queries")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("filter[organisation_id]", filterOrganisationId))
                      .Query(_query => _query.Setup("filter[status]", (filterStatus.HasValue) ? ApiHelper.JsonSerialize(filterStatus.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter[query_type]", filterQueryType))
                      .Query(_query => _query.Setup("filter[auto_handled]", filterAutoHandled))
                      .Query(_query => _query.Setup("filter[processing_date_from]", filterProcessingDateFrom.HasValue ? filterProcessingDateFrom.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[processing_date_to]", filterProcessingDateTo.HasValue ? filterProcessingDateTo.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[created_on_from]", filterCreatedOnFrom.HasValue ? filterCreatedOnFrom.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[created_on_to]", filterCreatedOnTo.HasValue ? filterCreatedOnTo.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[payment.id]", filterPaymentId))
                      .Query(_query => _query.Setup("filter[payment_admission.id]", filterPaymentAdmissionId))
                      .Query(_query => _query.Setup("filter[payment_submission.id]", filterPaymentSubmissionId))
                      .Query(_query => _query.Setup("filter[recall.id]", filterRecallId))
                      .Query(_query => _query.Setup("filter[recall_submission.id]", filterRecallSubmissionId))
                      .Query(_query => _query.Setup("filter[query.id]", filterQueryId))
                      .Query(_query => _query.Setup("page[number]", pageNumber))
                      .Query(_query => _query.Setup("page[size]", pageSize))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Query bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("502", CreateErrorCase("Query gateway issue", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a Query.
        /// </summary>
        /// <param name="creationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.QueryFetchResponse response from the API call.</returns>
        public Models.QueryFetchResponse CreateQuery(
                Models.QueryCreation creationRequest = null)
            => CoreHelper.RunTask(CreateQueryAsync(creationRequest));

        /// <summary>
        /// Create a Query.
        /// </summary>
        /// <param name="creationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QueryFetchResponse response from the API call.</returns>
        public async Task<Models.QueryFetchResponse> CreateQueryAsync(
                Models.QueryCreation creationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QueryFetchResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/queries")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(creationRequest))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("502", CreateErrorCase("gateway issue", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch a Query.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <returns>Returns the Models.QueryFetchResponse response from the API call.</returns>
        public Models.QueryFetchResponse GetQuery(
                Guid queryId)
            => CoreHelper.RunTask(GetQueryAsync(queryId));

        /// <summary>
        /// Fetch a Query.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QueryFetchResponse response from the API call.</returns>
        public async Task<Models.QueryFetchResponse> GetQueryAsync(
                Guid queryId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QueryFetchResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/queries/{query_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("query_id", queryId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("forbidden", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch a Query Admission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="queryAdmissionId">Required parameter: Query Admission ID.</param>
        /// <returns>Returns the Models.QueryAdmissionResponse response from the API call.</returns>
        public Models.QueryAdmissionResponse GetQueryAdmission(
                Guid queryId,
                Guid queryAdmissionId)
            => CoreHelper.RunTask(GetQueryAdmissionAsync(queryId, queryAdmissionId));

        /// <summary>
        /// Fetch a Query Admission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="queryAdmissionId">Required parameter: Query Admission ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QueryAdmissionResponse response from the API call.</returns>
        public async Task<Models.QueryAdmissionResponse> GetQueryAdmissionAsync(
                Guid queryId,
                Guid queryAdmissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QueryAdmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/queries/{query_id}/admissions/{query_admission_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("query_id", queryId))
                      .Template(_template => _template.Setup("query_admission_id", queryAdmissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("forbidden", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a Query Response.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="creationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.QueryResponseResponse response from the API call.</returns>
        public Models.QueryResponseResponse CreateQueryResponse(
                Guid queryId,
                Models.QueryResponseCreation creationRequest = null)
            => CoreHelper.RunTask(CreateQueryResponseAsync(queryId, creationRequest));

        /// <summary>
        /// Create a Query Response.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="creationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QueryResponseResponse response from the API call.</returns>
        public async Task<Models.QueryResponseResponse> CreateQueryResponseAsync(
                Guid queryId,
                Models.QueryResponseCreation creationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QueryResponseResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/queries/{query_id}/responses")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(creationRequest))
                      .Template(_template => _template.Setup("query_id", queryId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("502", CreateErrorCase("gateway issue", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch a Query Response.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="queryResponseId">Required parameter: Query Response ID.</param>
        /// <returns>Returns the Models.QueryResponseResponse response from the API call.</returns>
        public Models.QueryResponseResponse GetQueryResponse(
                Guid queryId,
                Guid queryResponseId)
            => CoreHelper.RunTask(GetQueryResponseAsync(queryId, queryResponseId));

        /// <summary>
        /// Fetch a Query Response.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="queryResponseId">Required parameter: Query Response ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QueryResponseResponse response from the API call.</returns>
        public async Task<Models.QueryResponseResponse> GetQueryResponseAsync(
                Guid queryId,
                Guid queryResponseId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QueryResponseResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/queries/{query_id}/responses/{query_response_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("query_id", queryId))
                      .Template(_template => _template.Setup("query_response_id", queryResponseId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch a Query Response Admission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="queryResponseId">Required parameter: Query Response ID.</param>
        /// <param name="queryResponseAdmissionId">Required parameter: Query Response Admission ID.</param>
        /// <returns>Returns the Models.QueryResponseAdmissionResponse response from the API call.</returns>
        public Models.QueryResponseAdmissionResponse GetQueryResponseAdmission(
                Guid queryId,
                Guid queryResponseId,
                Guid queryResponseAdmissionId)
            => CoreHelper.RunTask(GetQueryResponseAdmissionAsync(queryId, queryResponseId, queryResponseAdmissionId));

        /// <summary>
        /// Fetch a Query Response Admission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="queryResponseId">Required parameter: Query Response ID.</param>
        /// <param name="queryResponseAdmissionId">Required parameter: Query Response Admission ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QueryResponseAdmissionResponse response from the API call.</returns>
        public async Task<Models.QueryResponseAdmissionResponse> GetQueryResponseAdmissionAsync(
                Guid queryId,
                Guid queryResponseId,
                Guid queryResponseAdmissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QueryResponseAdmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/queries/{query_id}/responses/{query_response_id}/admissions/{query_response_admission_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("query_id", queryId))
                      .Template(_template => _template.Setup("query_response_id", queryResponseId))
                      .Template(_template => _template.Setup("query_response_admission_id", queryResponseAdmissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("forbidden", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a Query Response Submission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="queryResponseId">Required parameter: Query Response ID.</param>
        /// <param name="creationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.QueryResponseSubmissionResponse response from the API call.</returns>
        public Models.QueryResponseSubmissionResponse CreateQueryResponseSubmission(
                Guid queryId,
                Guid queryResponseId,
                Models.QueryResponseSubmissionCreation creationRequest = null)
            => CoreHelper.RunTask(CreateQueryResponseSubmissionAsync(queryId, queryResponseId, creationRequest));

        /// <summary>
        /// Create a Query Response Submission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="queryResponseId">Required parameter: Query Response ID.</param>
        /// <param name="creationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QueryResponseSubmissionResponse response from the API call.</returns>
        public async Task<Models.QueryResponseSubmissionResponse> CreateQueryResponseSubmissionAsync(
                Guid queryId,
                Guid queryResponseId,
                Models.QueryResponseSubmissionCreation creationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QueryResponseSubmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/queries/{query_id}/responses/{query_response_id}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(creationRequest))
                      .Template(_template => _template.Setup("query_id", queryId))
                      .Template(_template => _template.Setup("query_response_id", queryResponseId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("502", CreateErrorCase("gateway issue", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch a Query Response Submission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="queryResponseId">Required parameter: Query Response ID.</param>
        /// <param name="queryResponseSubmissionId">Required parameter: Query Response Submission ID.</param>
        /// <returns>Returns the Models.QueryResponseSubmissionResponse response from the API call.</returns>
        public Models.QueryResponseSubmissionResponse GetQueryResponseSubmission(
                Guid queryId,
                Guid queryResponseId,
                Guid queryResponseSubmissionId)
            => CoreHelper.RunTask(GetQueryResponseSubmissionAsync(queryId, queryResponseId, queryResponseSubmissionId));

        /// <summary>
        /// Fetch a Query Response Submission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="queryResponseId">Required parameter: Query Response ID.</param>
        /// <param name="queryResponseSubmissionId">Required parameter: Query Response Submission ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QueryResponseSubmissionResponse response from the API call.</returns>
        public async Task<Models.QueryResponseSubmissionResponse> GetQueryResponseSubmissionAsync(
                Guid queryId,
                Guid queryResponseId,
                Guid queryResponseSubmissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QueryResponseSubmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/queries/{query_id}/responses/{query_response_id}/submissions/{query_response_submission_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("query_id", queryId))
                      .Template(_template => _template.Setup("query_response_id", queryResponseId))
                      .Template(_template => _template.Setup("query_response_submission_id", queryResponseSubmissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("forbidden", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a Query submission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="creationRequest">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.QuerySubmissionResponse response from the API call.</returns>
        public Models.QuerySubmissionResponse CreateQuerySubmission(
                Guid queryId,
                Models.QuerySubmissionCreation creationRequest = null)
            => CoreHelper.RunTask(CreateQuerySubmissionAsync(queryId, creationRequest));

        /// <summary>
        /// Create a Query submission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="creationRequest">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QuerySubmissionResponse response from the API call.</returns>
        public async Task<Models.QuerySubmissionResponse> CreateQuerySubmissionAsync(
                Guid queryId,
                Models.QuerySubmissionCreation creationRequest = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QuerySubmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction/queries/{query_id}/submissions")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(creationRequest))
                      .Template(_template => _template.Setup("query_id", queryId))
                      .Header(_header => _header.Setup("Content-Type", "application/vnd.api+json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("forbidden", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("502", CreateErrorCase("gateway issue", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetch a Query submission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="querySubmissionId">Required parameter: Query Submission ID.</param>
        /// <returns>Returns the Models.QuerySubmissionResponse response from the API call.</returns>
        public Models.QuerySubmissionResponse GetQuerySubmission(
                Guid queryId,
                Guid querySubmissionId)
            => CoreHelper.RunTask(GetQuerySubmissionAsync(queryId, querySubmissionId));

        /// <summary>
        /// Fetch a Query submission.
        /// </summary>
        /// <param name="queryId">Required parameter: Query ID.</param>
        /// <param name="querySubmissionId">Required parameter: Query Submission ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.QuerySubmissionResponse response from the API call.</returns>
        public async Task<Models.QuerySubmissionResponse> GetQuerySubmissionAsync(
                Guid queryId,
                Guid querySubmissionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QuerySubmissionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transaction/queries/{query_id}/submissions/{query_submission_id}")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("query_id", queryId))
                      .Template(_template => _template.Setup("query_submission_id", querySubmissionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("bad request", (_reason, _context) => new ApiErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("forbidden", (_reason, _context) => new ApiErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}