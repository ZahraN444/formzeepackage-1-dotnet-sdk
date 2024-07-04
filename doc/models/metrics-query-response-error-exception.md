
# Metrics Query Response Error Exception

## Structure

`MetricsQueryResponseErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`PrometheusMetricData`](../../doc/models/prometheus-metric-data.md) | Optional | - |
| `Error` | `string` | Optional | - |
| `ErrorType` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `Warnings` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "data": {
    "result": [
      {
        "metric": {
          "key0": "metric6",
          "key1": "metric5",
          "key2": "metric4"
        },
        "value": [
          {
            "key1": "val1",
            "key2": "val2"
          }
        ]
      },
      {
        "metric": {
          "key0": "metric6",
          "key1": "metric5",
          "key2": "metric4"
        },
        "value": [
          {
            "key1": "val1",
            "key2": "val2"
          }
        ]
      },
      {
        "metric": {
          "key0": "metric6",
          "key1": "metric5",
          "key2": "metric4"
        },
        "value": [
          {
            "key1": "val1",
            "key2": "val2"
          }
        ]
      }
    ],
    "resultType": "resultType0"
  },
  "error": "error0",
  "errorType": "errorType4",
  "status": "status8",
  "warnings": [
    "warnings2"
  ]
}
```

