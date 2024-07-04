# Metrics API

```csharp
MetricsAPIController metricsAPIController = client.MetricsAPIController;
```

## Class Name

`MetricsAPIController`

## Methods

* [Query Endpoint for Metrics](../../doc/controllers/metrics-api.md#query-endpoint-for-metrics)
* [Query Endpoint for Metrics 1](../../doc/controllers/metrics-api.md#query-endpoint-for-metrics-1)
* [Query Range Endpoint for Metrics](../../doc/controllers/metrics-api.md#query-range-endpoint-for-metrics)
* [Query Range Endpoint for Metrics 1](../../doc/controllers/metrics-api.md#query-range-endpoint-for-metrics-1)
* [Federate Endpoint for Metrics](../../doc/controllers/metrics-api.md#federate-endpoint-for-metrics)


# Query Endpoint for Metrics

Query Endpoint for metrics

```csharp
QueryEndpointForMetricsAsync(
    string query,
    string time = null,
    string timeout = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `query` | `string` | Query, Required | Query to Execute |
| `time` | `string` | Query, Optional | RFC3339 or unix_timestamp |
| `timeout` | `string` | Query, Optional | See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations |

## Response Type

[`Task<Models.MetricsQueryResponse>`](../../doc/models/metrics-query-response.md)

## Example Usage

```csharp
string query = "query0";
try
{
    MetricsQueryResponse result = await metricsAPIController.QueryEndpointForMetricsAsync(query);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`MetricsQueryResponseErrorException`](../../doc/models/metrics-query-response-error-exception.md) |
| 403 | Forbidden | `ApiException` |
| 500 | Internal Server Error | `ApiException` |


# Query Endpoint for Metrics 1

Query Endpoint for metrics

```csharp
QueryEndpointForMetrics1Async(
    string query,
    string time = null,
    string timeout = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `query` | `string` | Form, Required | Query to Execute |
| `time` | `string` | Form, Optional | RFC3339 or unix_timestamp |
| `timeout` | `string` | Form, Optional | See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations |

## Response Type

[`Task<Models.MetricsQueryResponse>`](../../doc/models/metrics-query-response.md)

## Example Usage

```csharp
string query = "query0";
try
{
    MetricsQueryResponse result = await metricsAPIController.QueryEndpointForMetrics1Async(query);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`MetricsQueryResponseErrorException`](../../doc/models/metrics-query-response-error-exception.md) |
| 403 | Forbidden | `ApiException` |
| 500 | Internal Server Error | `ApiException` |


# Query Range Endpoint for Metrics

Query Range Endpoint for metrics

```csharp
QueryRangeEndpointForMetricsAsync(
    string query,
    string time = null,
    string timeout = null,
    string start = null,
    string end = null,
    string step = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `query` | `string` | Query, Required | Query to Execute |
| `time` | `string` | Query, Optional | RFC3339 or unix_timestamp |
| `timeout` | `string` | Query, Optional | See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations |
| `start` | `string` | Query, Optional | RFC3339 or unix_timestamp |
| `end` | `string` | Query, Optional | RFC3339 or unix_timestamp |
| `step` | `string` | Query, Optional | duration or float |

## Response Type

[`Task<Models.MetricsQueryResponse>`](../../doc/models/metrics-query-response.md)

## Example Usage

```csharp
string query = "query0";
try
{
    MetricsQueryResponse result = await metricsAPIController.QueryRangeEndpointForMetricsAsync(query);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`MetricsQueryResponseErrorException`](../../doc/models/metrics-query-response-error-exception.md) |
| 403 | Forbidden | `ApiException` |
| 500 | Internal Server Error | `ApiException` |


# Query Range Endpoint for Metrics 1

Query Range Endpoint for metrics

```csharp
QueryRangeEndpointForMetrics1Async(
    string query,
    string time = null,
    string timeout = null,
    string start = null,
    string end = null,
    string step = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `query` | `string` | Form, Required | Query to Execute |
| `time` | `string` | Form, Optional | RFC3339 or unix_timestamp |
| `timeout` | `string` | Form, Optional | See https://prometheus.io/docs/prometheus/latest/querying/basics/#time-durations |
| `start` | `string` | Form, Optional | RFC3339 or unix_timestamp |
| `end` | `string` | Form, Optional | RFC3339 or unix_timestamp |
| `step` | `string` | Form, Optional | duration or float |

## Response Type

[`Task<Models.MetricsQueryResponse>`](../../doc/models/metrics-query-response.md)

## Example Usage

```csharp
string query = "query0";
try
{
    MetricsQueryResponse result = await metricsAPIController.QueryRangeEndpointForMetrics1Async(query);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`MetricsQueryResponseErrorException`](../../doc/models/metrics-query-response-error-exception.md) |
| 403 | Forbidden | `ApiException` |
| 500 | Internal Server Error | `ApiException` |


# Federate Endpoint for Metrics

Federate Endpoint for metrics

```csharp
FederateEndpointForMetricsAsync(
    List<string> match)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `match` | `List<string>` | Query, Required | See https://prometheus.io/docs/prometheus/latest/querying/basics/#instant-vector-selectors |

## Response Type

`Task<string>`

## Example Usage

```csharp
List<string> match = new List<string>
{
    "match5",
    "match6",
};

try
{
    string result = await metricsAPIController.FederateEndpointForMetricsAsync(match);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`MetricsQueryResponseErrorException`](../../doc/models/metrics-query-response-error-exception.md) |
| 403 | Forbidden | `ApiException` |
| 500 | Internal Server Error | `ApiException` |

