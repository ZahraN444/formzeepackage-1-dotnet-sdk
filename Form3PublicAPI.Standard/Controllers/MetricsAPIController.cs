// <copyright file="MetricsAPIController.cs" company="APIMatic">
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
    /// MetricsAPIController.
    /// </summary>
    public class MetricsAPIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsAPIController"/> class.
        /// </summary>
        internal MetricsAPIController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Query Endpoint for metrics.
        /// </summary>
        /// <param name="query">Required parameter: Query to Execute.</param>
        /// <param name="time">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="timeout">Optional parameter: See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations.</param>
        /// <returns>Returns the Models.MetricsQueryResponse response from the API call.</returns>
        public Models.MetricsQueryResponse QueryEndpointForMetrics(
                string query,
                string time = null,
                string timeout = null)
            => CoreHelper.RunTask(QueryEndpointForMetricsAsync(query, time, timeout));

        /// <summary>
        /// Query Endpoint for metrics.
        /// </summary>
        /// <param name="query">Required parameter: Query to Execute.</param>
        /// <param name="time">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="timeout">Optional parameter: See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MetricsQueryResponse response from the API call.</returns>
        public async Task<Models.MetricsQueryResponse> QueryEndpointForMetricsAsync(
                string query,
                string time = null,
                string timeout = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MetricsQueryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/metrics/prometheus/api/v1/query")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("query", query))
                      .Query(_query => _query.Setup("time", time))
                      .Query(_query => _query.Setup("timeout", timeout))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new MetricsQueryResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Query Endpoint for metrics.
        /// </summary>
        /// <param name="query">Required parameter: Query to Execute.</param>
        /// <param name="time">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="timeout">Optional parameter: See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations.</param>
        /// <returns>Returns the Models.MetricsQueryResponse response from the API call.</returns>
        public Models.MetricsQueryResponse QueryEndpointForMetrics1(
                string query,
                string time = null,
                string timeout = null)
            => CoreHelper.RunTask(QueryEndpointForMetrics1Async(query, time, timeout));

        /// <summary>
        /// Query Endpoint for metrics.
        /// </summary>
        /// <param name="query">Required parameter: Query to Execute.</param>
        /// <param name="time">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="timeout">Optional parameter: See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MetricsQueryResponse response from the API call.</returns>
        public async Task<Models.MetricsQueryResponse> QueryEndpointForMetrics1Async(
                string query,
                string time = null,
                string timeout = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MetricsQueryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/metrics/prometheus/api/v1/query")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("query", query))
                      .Header(_header => _header.Setup("Content-Type", "application/x-www-form-urlencoded"))
                      .Form(_form => _form.Setup("time", time))
                      .Form(_form => _form.Setup("timeout", timeout))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new MetricsQueryResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Query Range Endpoint for metrics.
        /// </summary>
        /// <param name="query">Required parameter: Query to Execute.</param>
        /// <param name="time">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="timeout">Optional parameter: See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations.</param>
        /// <param name="start">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="end">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="step">Optional parameter: duration or float.</param>
        /// <returns>Returns the Models.MetricsQueryResponse response from the API call.</returns>
        public Models.MetricsQueryResponse QueryRangeEndpointForMetrics(
                string query,
                string time = null,
                string timeout = null,
                string start = null,
                string end = null,
                string step = null)
            => CoreHelper.RunTask(QueryRangeEndpointForMetricsAsync(query, time, timeout, start, end, step));

        /// <summary>
        /// Query Range Endpoint for metrics.
        /// </summary>
        /// <param name="query">Required parameter: Query to Execute.</param>
        /// <param name="time">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="timeout">Optional parameter: See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations.</param>
        /// <param name="start">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="end">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="step">Optional parameter: duration or float.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MetricsQueryResponse response from the API call.</returns>
        public async Task<Models.MetricsQueryResponse> QueryRangeEndpointForMetricsAsync(
                string query,
                string time = null,
                string timeout = null,
                string start = null,
                string end = null,
                string step = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MetricsQueryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/metrics/prometheus/api/v1/query_range")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("query", query))
                      .Query(_query => _query.Setup("time", time))
                      .Query(_query => _query.Setup("timeout", timeout))
                      .Query(_query => _query.Setup("start", start))
                      .Query(_query => _query.Setup("end", end))
                      .Query(_query => _query.Setup("step", step))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new MetricsQueryResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Query Range Endpoint for metrics.
        /// </summary>
        /// <param name="query">Required parameter: Query to Execute.</param>
        /// <param name="time">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="timeout">Optional parameter: See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations.</param>
        /// <param name="start">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="end">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="step">Optional parameter: duration or float.</param>
        /// <returns>Returns the Models.MetricsQueryResponse response from the API call.</returns>
        public Models.MetricsQueryResponse QueryRangeEndpointForMetrics1(
                string query,
                string time = null,
                string timeout = null,
                string start = null,
                string end = null,
                string step = null)
            => CoreHelper.RunTask(QueryRangeEndpointForMetrics1Async(query, time, timeout, start, end, step));

        /// <summary>
        /// Query Range Endpoint for metrics.
        /// </summary>
        /// <param name="query">Required parameter: Query to Execute.</param>
        /// <param name="time">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="timeout">Optional parameter: See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations.</param>
        /// <param name="start">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="end">Optional parameter: RFC3339 or unix_timestamp.</param>
        /// <param name="step">Optional parameter: duration or float.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MetricsQueryResponse response from the API call.</returns>
        public async Task<Models.MetricsQueryResponse> QueryRangeEndpointForMetrics1Async(
                string query,
                string time = null,
                string timeout = null,
                string start = null,
                string end = null,
                string step = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MetricsQueryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/metrics/prometheus/api/v1/query_range")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("query", query))
                      .Header(_header => _header.Setup("Content-Type", "application/x-www-form-urlencoded"))
                      .Form(_form => _form.Setup("time", time))
                      .Form(_form => _form.Setup("timeout", timeout))
                      .Form(_form => _form.Setup("start", start))
                      .Form(_form => _form.Setup("end", end))
                      .Form(_form => _form.Setup("step", step))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new MetricsQueryResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Federate Endpoint for metrics.
        /// </summary>
        /// <param name="match">Required parameter: See https://prometheus.io/docs/prometheus/latest/querying/basics/#instant-vector-selectors.</param>
        /// <returns>Returns the string response from the API call.</returns>
        public string FederateEndpointForMetrics(
                List<string> match)
            => CoreHelper.RunTask(FederateEndpointForMetricsAsync(match));

        /// <summary>
        /// Federate Endpoint for metrics.
        /// </summary>
        /// <param name="match">Required parameter: See https://prometheus.io/docs/prometheus/latest/querying/basics/#instant-vector-selectors.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        public async Task<string> FederateEndpointForMetricsAsync(
                List<string> match,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/metrics/prometheus/federate")
                  .WithAuth("OAuth2")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("match", match))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new MetricsQueryResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}