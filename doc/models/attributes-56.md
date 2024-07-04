
# Attributes 56

## Structure

`Attributes56`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdmissionDatetime` | `DateTime?` | Optional | Date and time the recall admission was created |
| `SourceGateway` | `string` | Optional | - |
| `Status` | [`RecallAdmissionStatusEnum?`](../../doc/models/recall-admission-status-enum.md) | Optional | [Status](http://draft-api-docs.form3.tech/api.html#enumerations-payment-admission-status) of the recall admission |
| `StatusReason` | `string` | Optional | Human-readable reason for failure if admission status is failed |

## Example (as JSON)

```json
{
  "admission_datetime": "09/26/2018 15:26:57",
  "status": "confirmed",
  "status_reason": "payment does not exist",
  "source_gateway": "source_gateway8"
}
```

