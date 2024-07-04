
# Prometheus Result Item

## Structure

`PrometheusResultItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Metric` | `Dictionary<string, string>` | Optional | - |
| `MValue` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "metric": {
    "key0": "metric0"
  },
  "value": [
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    }
  ]
}
```

