
# Attributes 14

## Structure

`Attributes14`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SchemeStatusCode` | `string` | Optional | Scheme-specific status code. Refer to scheme documentation where available. |
| `SchemeStatusCodeDescription` | `string` | Optional | Description of `scheme_status_code` |
| `SourceGateway` | `string` | Optional | - |
| `Status` | [`ReversalAdmissionStatusEnum?`](../../doc/models/reversal-admission-status-enum.md) | Optional | Status of the reversal admission |

## Example (as JSON)

```json
{
  "scheme_status_code": "0",
  "scheme_status_code_description": "Field 1 (destination sorting code) was invalid",
  "status": "confirmed",
  "source_gateway": "source_gateway2"
}
```

